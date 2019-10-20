using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using shunshine.App.ApplicationServices.ServiceInterfaces;
using shunshine.App.Models.ViewModels;
using shunshine.App.Utilities.Dtos;

namespace shunshine.Areas.Admin.Controllers
{
    public class ProductCategoryController : BaseController
    {
        private IProductCategoryServiceInterface _categoryService;

        public ProductCategoryController(IProductCategoryServiceInterface categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllCategoryTree()
        {
            List<ProductCategoryViewModel> productCatogory = await _categoryService.GetAll();

            List<Object> arrayResult = new List<Object>();

            foreach (var items in productCatogory.Where(x => string.IsNullOrEmpty(x.ParentId.ToString())))
            {
                arrayResult.Add( new { parent = items, chirld = productCatogory.Where(x => x.ParentId == items.Id) });
            }

            return new OkObjectResult(arrayResult);
        }

        public async Task<IActionResult> GetAllTable()
        {
            List<ProductCategoryViewModel> productCatogory = await _categoryService.GetAll();

            return new OkObjectResult(productCatogory);
        }

        [HttpGet]
        public IActionResult GetAllPaginate()
        {
            // KEYWORD Query String (GET data)
            //var values = Request.Query.ToList ()
            int pageCurrent = Int32.Parse(HttpContext.Request.Query["pageCurrent"].ToString());

            int pageSize = Int32.Parse(HttpContext.Request.Query["pageSize"].ToString());

            string keyword = HttpContext.Request.Query["keyword"].ToString();

            var lstCategory = _categoryService.GetAllPaginate (pageCurrent, pageSize, keyword);

            return new OkObjectResult(lstCategory);
        }

        public async Task<IActionResult> GetListParent()
        {
            List<ProductCategoryViewModel> parents = await _categoryService.GetAllParent();

            return new OkObjectResult(parents);
        }

        [HttpPost]
        public IActionResult SaveEntity(ProductCategoryViewModel productCategoryViewModel)
        {
  
            try
            {
                if (!ModelState.IsValid)
                {
                    IEnumerable<ModelError> modelErrors = ModelState.Values.SelectMany(x => x.Errors);

                    return new OkObjectResult(new GenericResult(false, new { modelErrors }));
                }
                else
                {
                    if (!string.IsNullOrEmpty(productCategoryViewModel.SeoAlias))
                    {            
                        productCategoryViewModel.SeoAlias = Helper.ToUnsignString(productCategoryViewModel.SeoAlias);
                    }

                    if (!_categoryService.IsUnique(productCategoryViewModel.SeoAlias))
                    {
                        return new OkObjectResult(new GenericResult(false, new { SeoAlias = "The slug must be unique" }));
                    }

                    if (productCategoryViewModel.Id == 0)
                    {
                        _categoryService.Create(productCategoryViewModel);
                    }
                    else
                    {
                        _categoryService.Update(productCategoryViewModel);
                    }
                    _categoryService.Save();
                }

                return new OkObjectResult( new GenericResult(true));
            }
            catch(Exception exception)
            {
                return new OkObjectResult(new GenericResult(false, new { Message = exception.Message.ToString() }));
            }
        }

        public IActionResult GetById(int Id)
        {
            try
            {
                ProductCategoryViewModel productCategoryViewModelParent = new ProductCategoryViewModel();

                var productCategoryViewModel = _categoryService.FindById(Id);

                if (!string.IsNullOrEmpty(productCategoryViewModel.ParentId.ToString()))
                {
                    productCategoryViewModelParent = _categoryService.FindById(int.Parse(productCategoryViewModel.ParentId.ToString()));
                }

                ViewBag.ParentName = productCategoryViewModelParent.Name;

                return PartialView("View", productCategoryViewModel);
            }
            catch(Exception exception)
            {
                return new OkObjectResult(new GenericResult(false, new { Data = exception.Message.ToString()}));
            }
        }

        [HttpPost]
        public IActionResult DeleteCategoryById(int Id)
        {
            try
            {
                _categoryService.DeleteById(Id);
                _categoryService.Save();

                return new OkObjectResult(new GenericResult(true));
            }
            catch(Exception exception)
            {
                return new OkObjectResult(new GenericResult(false, new { Data = exception.Message.ToString()}));
            }
        }
    }
}
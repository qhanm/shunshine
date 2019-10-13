using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shunshine.App.ApplicationServices.ServiceInterfaces;
using shunshine.App.Models.ViewModels;

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
    }
}
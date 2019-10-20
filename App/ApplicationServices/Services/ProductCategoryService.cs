using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using shunshine.App.ApplicationServices.Repositories;
using shunshine.App.ApplicationServices.ServiceInterfaces;
using shunshine.App.AutoMapper;
using shunshine.App.EntityCodeFirst;
using shunshine.App.Models.ViewModels;
using shunshine.App.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.ApplicationServices.Services
{
    public class ProductCategoryService : IProductCategoryServiceInterface
    {
        private IRepository<ProductCategory, int> _repository;

        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public ProductCategoryService(IRepository<ProductCategory, int> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        //public List<ProductCategoryViewModel> GetAll()
        //{
        //    List<ProductCategoryViewModel> productCategoryViewModels = _repository.FindAll().OrderBy(x => x.DateModified).ProjectTo<ProductCategoryViewModel>(AutoMapperConfig.RegisterMapping()).ToList();

        //    return productCategoryViewModels;
        //}

        public Task<List<ProductCategoryViewModel>> GetAll()
        {

            var productCategoryViewModels = _repository.FindAll().OrderBy(x => x.DateModified).ProjectTo<ProductCategoryViewModel>(AutoMapperConfig.RegisterMapping()).ToListAsync();

            return productCategoryViewModels;
        }

        public PageResult<ProductCategoryViewModel> GetAllPaginate(int pageCurrent, int pageSize, string keyword)
        {
            var query = _repository.FindAll();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Name.Contains(keyword.ToString()) || x.Description.Contains(keyword) || x.SeoAlias.Contains(keyword));
            }

            int totalRow = query.Count();

            query = query.OrderBy(x => x.DateModified).Skip((pageCurrent -1) * pageSize).Take(pageSize);

            var data = query.ProjectTo<ProductCategoryViewModel>(AutoMapperConfig.RegisterMapping()).ToList();

            var paginateResult = new PageResult<ProductCategoryViewModel>()
            {
                Results = data,
                CurrnetPage = pageCurrent,
                PageSize = pageSize,
                RowCount = totalRow

            };

            return paginateResult;
        }

        public Task<List<ProductCategoryViewModel>> GetAllParent()
        {
            var parents = _repository.FindAll().Where(x => string.IsNullOrEmpty(x.ParentId.ToString())).ProjectTo<ProductCategoryViewModel>(AutoMapperConfig.RegisterMapping()).ToListAsync();

            return parents;
        }

        public void Create(ProductCategoryViewModel productCategoryViewModel)
        {
            var category = _mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryViewModel);

            _repository.Add(category);
        }

        public void Update(ProductCategoryViewModel productCategoryViewModel)
        {
            var category = _mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryViewModel);

            _repository.Update(category);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public bool IsUnique(string slug)
        {
            if (!string.IsNullOrEmpty(slug))
            {
                var query = _repository.FindAll()
                            .Where(x => x.SeoAlias == slug)
                            .ProjectTo<ProductCategoryViewModel>(AutoMapperConfig.RegisterMapping())
                            .ToList();
                if(query.Count() > 0)
                {
                    return false;
                }
                return true;
            }

            return false;
        }

        public ProductCategoryViewModel FindById(int id)
        {
            ProductCategory query = _repository.FindById(id);

            //var category = _mapper.Map<ProductCategory, ProductCategoryViewModel>(query);
            var category = _repository.FindAll().Where(x => x.Id.Equals(id))
                                       .ProjectTo<ProductCategoryViewModel>(AutoMapperConfig.RegisterMapping()).FirstOrDefault();
            return (ProductCategoryViewModel)category;
        }

        public void DeleteById(int id)
        {
            _repository.Remove(id);
        }
    }
}

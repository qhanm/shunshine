﻿using shunshine.App.Models.ViewModels;
using shunshine.App.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.ApplicationServices.ServiceInterfaces
{
    public interface IProductCategoryServiceInterface : IDisposable
    {
        Task<List<ProductCategoryViewModel>> GetAll();

        PageResult<ProductCategoryViewModel> GetAllPaginate(int pageCurrent, int pageSize, string keyword);

        Task<List<ProductCategoryViewModel>> GetAllParent();

        void Create(ProductCategoryViewModel productCategoryViewModel);

        void Update(ProductCategoryViewModel productCategoryViewModel);

        void Save();

        bool IsUnique(string slug);

        ProductCategoryViewModel FindById(int id);

        void DeleteById(int id);
    }
}

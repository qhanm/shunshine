using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using shunshine.App.ApplicationServices.Repositories;
using shunshine.App.ApplicationServices.ServiceInterfaces;
using shunshine.App.AutoMapper;
using shunshine.App.EntityCodeFirst;
using shunshine.App.EntityCodeFirst.Entities;
using shunshine.App.Models.ViewModels;
using shunshine.App.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.ApplicationServices.Services
{
    public class ImageService : IImageServiceInterface
    {
        private readonly IRepository<Image, int> _repository;

        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public ImageService(IRepository<Image, int> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public void Add(ImageViewModel imageViewModel)
        {
            var image = _mapper.Map<ImageViewModel, Image>(imageViewModel);

            _repository.Add(image);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public PageResult<ImageViewModel> GetAll(int pageCurrent, int pageSize, string keyword)
        {
            var query = _repository.FindAll();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Name == keyword);
            }

            int totalRow = query.Count();

            query = query.OrderByDescending(x => x.DateModified).Skip((pageCurrent - 1) * pageSize).Take(pageSize);

            var data = query.ProjectTo<ImageViewModel>(AutoMapperConfig.RegisterMapping()).ToList();

            var paginateResult = new PageResult<ImageViewModel>()
            {
                Results = data,
                CurrnetPage = pageCurrent,
                PageSize = pageSize,
                RowCount = totalRow
            };

            return paginateResult;

        }

        public List<ImageViewModel> GetAll(string query)
        {
            var images = _repository.FindAll();

            if (!string.IsNullOrEmpty(query))
            {
                images = images.Where(x => x.Month == int.Parse(query));
            }

            var result = images.OrderByDescending(x => x.DateCreated).ProjectTo<ImageViewModel>(AutoMapperConfig.RegisterMapping()).ToList();

            return result;
        }

        public List<ImageViewModel> GetAll(string year, string month)
        {
            var images = _repository.FindAll();

            if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
            {
                images = images.Where(x => x.Year == int.Parse(year) && x.Month == int.Parse(month));
            }

            var result = images.OrderByDescending(x => x.DateCreated).ProjectTo<ImageViewModel>(AutoMapperConfig.RegisterMapping()).ToList();

            return result;
        }

        public List<ImageViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ImageViewModel> GetByMonthFolder(Guid userId, int folder)
        {
            var Images = _repository.FindAll().Where(x => x.UserId == userId && x.Month == folder)
                .OrderBy(x => x.DateCreated).ProjectTo<ImageViewModel>(AutoMapperConfig.RegisterMapping()).ToList();

            return Images;
        }

        public List<ImageViewModel> GetByUser(Guid userId)
        {
            var Images = _repository.FindAll().Where(x => x.UserId == userId)
                .OrderBy(x => x.DateCreated).ProjectTo<ImageViewModel>(AutoMapperConfig.RegisterMapping()).ToList();

            return Images;
        }

        public List<string> GetListMonth(int year)
        {
            var images = _repository.FindAll().Where(x => x.Year == year).OrderBy(x => x.Month)
                        .ProjectTo<ImageViewModel>(AutoMapperConfig.RegisterMapping()).ToList();

            var result = images.Select(x => x.Month).Distinct();

            List<string> lstResult = new List<string>();

            foreach(var r in result)
            {
                lstResult.Add(r.Value.ToString());
            }


            return lstResult;
        }

        public List<string> GetListYear()
        {
        
            var images = _repository.FindAll()
                            .OrderBy(x => x.Year)
                            .ProjectTo<ImageViewModel>(AutoMapperConfig.RegisterMapping())
                            .ToList();

            var result = images.Select(x => x.Year).Distinct();

            List<string> lstResult = new List<string>();

            foreach(var r in result)
            {
                lstResult.Add(r.Value.ToString());
            }

            return lstResult;
        }

        public void InsertMuilty(List<ImageViewModel> imageViewModels)
        {
            foreach(var imageViewModel in imageViewModels)
            {
                var image = _mapper.Map<ImageViewModel, Image>(imageViewModel);

                _repository.Add(image);
            }
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

    }
}

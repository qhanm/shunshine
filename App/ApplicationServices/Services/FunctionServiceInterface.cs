using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using shunshine.App.ApplicationServices.Repositories;
using shunshine.App.ApplicationServices.ServiceInterfaces;
using shunshine.App.AutoMapper;
using shunshine.App.EntityCodeFirst;
using shunshine.App.EntityCodeFirst.Constant;
using shunshine.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.ApplicationServices.Services
{
    public class FunctionServiceInterface : IFunctionServiceInterface
    {
        private readonly IRepository<Function, string> _repository;

        public FunctionServiceInterface(IRepository<Function, string> repository)
        {
            _repository = repository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task<List<FunctionViewModel>> GetAll()
        {
            var functions = _repository.FindAll().OrderBy(x => x.Name).Where(x => x.Status == Status.Active).ProjectTo<FunctionViewModel>(AutoMapperConfig.RegisterMapping()).ToListAsync();
            return functions;
        }
    }
}

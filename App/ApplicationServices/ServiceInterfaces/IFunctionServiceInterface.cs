using shunshine.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.ApplicationServices.ServiceInterfaces
{
    public interface IFunctionServiceInterface: IDisposable
    {
        Task<List<FunctionViewModel>> GetAll();

    }
}

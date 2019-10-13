using Microsoft.AspNetCore.Mvc;
using shunshine.App.ApplicationServices.ServiceInterfaces;
using shunshine.App.Models.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace shunshine.Areas.Admin.Components
{
    public class FunctionViewComponent : ViewComponent
    {
        private IFunctionServiceInterface _functionServiceInterface;

        public FunctionViewComponent(IFunctionServiceInterface functionServiceInterface)
        {
            _functionServiceInterface = functionServiceInterface;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<FunctionViewModel> functions = await _functionServiceInterface.GetAll();

            return View(functions);
        }
    }
}
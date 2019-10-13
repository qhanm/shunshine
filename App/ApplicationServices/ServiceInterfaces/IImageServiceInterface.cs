using shunshine.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.ApplicationServices.ServiceInterfaces
{
    public interface IImageServiceInterface : IDisposable
    {
        List<ImageViewModel> GetAll();

        List<ImageViewModel> GetByMonthFolder(Guid userId, int folder);

        List<ImageViewModel> GetByUser(Guid userId);

        void InsertMuilty(List<ImageViewModel> imageViewModels);

        void Add(ImageViewModel imageViewModel);

        void SaveChanges();

        List<string> GetListYear();

        List<string> GetListMonth(int year);

        List<ImageViewModel> GetAll(string query);
    }
}

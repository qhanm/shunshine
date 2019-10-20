using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shunshine.App.ApplicationServices.ServiceInterfaces;
using shunshine.App.Models.ViewModels;
using shunshine.App.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;

namespace shunshine.Areas.Admin.Controllers
{
    public class FileManagerController : BaseController
    {
        private readonly IImageServiceInterface _imageServiceInterface;

        private readonly IHostingEnvironment _hostingEnvironment;

        public FileManagerController(IImageServiceInterface imageServiceInterface, IHostingEnvironment hostingEnvironment)
        {
            _imageServiceInterface = imageServiceInterface;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllFolder()
        {
            try
            {
                string pathRootFolder = HttpContext.Request.Query["folderRoot"].ToString();

                string pathRoot = Directory.GetCurrentDirectory().ToString() + "/" + pathRootFolder;
                var listFolder = Directory.GetDirectories(pathRoot);

                List<string> folderResult = new List<string>();

                foreach (var folder in listFolder)
                {
                    folderResult.Add(DirectoryFileManager.ReplacePathFolder(pathRoot, folder));
                }

                return new OkObjectResult(folderResult);
            }
            catch (Exception e)
            {
                return new OkObjectResult(e.Message.ToString());
            }
        }

        [HttpGet]
        public IActionResult GetListFile()
        {
            try
            {
                string pathFolder = HttpContext.Request.Query["pathFolder"].ToString();

                string path = Directory.GetCurrentDirectory().ToString() + "/" + pathFolder;

                var listFile = Directory.GetFiles(path);

                return new OkObjectResult(listFile);
            }
            catch (Exception e)
            {
                return new OkObjectResult(e.Message.ToString());
            }
        }

        [HttpPost]
        public IActionResult UploadImage()
        {
            try
            {
                var baseRootUrl = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host;

                string webRootPath = _hostingEnvironment.WebRootPath;
                string contentRootPath = _hostingEnvironment.ContentRootPath;

                var files = HttpContext.Request.Form.Files;

                string yearCurrent = DateTime.Now.Year.ToString();

                string monthCurrent = DateTime.Now.Month.ToString();

                List<ImageViewModel> Images = new List<ImageViewModel>();

                foreach (var file in files)
                {
                    string timeCurrent = DateTime.Now.ToString("yyyyMMddHHmmssffff");

                    string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                    fileName = timeCurrent + fileName;

                    string imageFolder = $@"\uploaded\images\{yearCurrent}\{monthCurrent}";

                    string folder = _hostingEnvironment.WebRootPath + imageFolder;

                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    string filePath = Path.Combine(folder, fileName);

                    using (FileStream fileStream = System.IO.File.Create(filePath))
                    {
                        file.CopyTo(fileStream);
                        fileStream.Flush();
                    }

                    ImageViewModel imageViewModel = new ImageViewModel();

                    imageViewModel.Year = int.Parse(yearCurrent);
                    imageViewModel.Month = int.Parse(monthCurrent);
                    imageViewModel.Name = fileName;
                    imageViewModel.Url = baseRootUrl + imageFolder.Replace("\\", "/") + "/" + fileName;
                    imageViewModel.Size = int.Parse(file.Length.ToString());
                    imageViewModel.Type = file.ContentType;
                    imageViewModel.Extension = Path.GetExtension(fileName);

                    Images.Add(imageViewModel);
                }

                _imageServiceInterface.InsertMuilty(Images);
                _imageServiceInterface.SaveChanges();

                return new OkObjectResult(new GenericResult(true, "Upload success"));
            }
            catch (Exception exception)
            {
                return new OkObjectResult(new GenericResult(false, exception.Message.ToString()));
            }
        }

        [HttpGet]
        public IActionResult GetListYeas()
        {
            var years = _imageServiceInterface.GetListYear();

            return new OkObjectResult(years);
        }

        public IActionResult GetListMonths()
        {
            int year = int.Parse(HttpContext.Request.Query["year"].ToString());

            var months = _imageServiceInterface.GetListMonth(year);

            return new OkObjectResult(months);
        }

        public IActionResult GetListImage()
        {
            string year = HttpContext.Request.Query["year"];

            string month = HttpContext.Request.Query["month"];

            var images = _imageServiceInterface.GetAll(year, month);

            return new OkObjectResult(images);
        }

        public IActionResult getListPaginageImage()
        {
            int pageCurrent = int.Parse(HttpContext.Request.Query["pageCurrent"]);

            int pageSize = int.Parse(HttpContext.Request.Query["pageSize"]);

            string keyword = HttpContext.Request.Query["keyword"];

            var results = _imageServiceInterface.GetAll(pageCurrent, pageSize, keyword);

            return new OkObjectResult(results);
        }

        public PartialViewResult GetFileManagerPartial()
        {
            return PartialView("Index");
        }
    }
}
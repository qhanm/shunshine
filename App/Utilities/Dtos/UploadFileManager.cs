using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.Utilities.Dtos
{
    public class UploadFileManager
    {
        public static string Upload(IFormFile file)
        {
            return file.Name;
        }
    }
}

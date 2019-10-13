using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class ColorViewModel
    {
        [StringLength(250)]
        public string Name
        {
            get; set;
        }

        [StringLength(250)]
        public string Code { get; set; }
    }
}
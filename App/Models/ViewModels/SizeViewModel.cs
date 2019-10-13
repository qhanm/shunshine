using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class SizeViewModel
    {
        [StringLength(250)]
        public string Name { get; set; }
    }
}
using shunshine.App.EntityCodeFirst.Constant;
using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class PageViewModel
    {
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }
        public Status Status { set; get; }
    }
}
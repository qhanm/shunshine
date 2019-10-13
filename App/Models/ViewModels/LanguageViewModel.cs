using shunshine.App.EntityCodeFirst.Constant;
using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class LanguageViewModel
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
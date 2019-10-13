using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class TagViewModel
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}
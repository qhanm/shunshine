using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class ProductTagViewModel
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        public string TagId { set; get; }

        public ProductViewModel Product { set; get; }
        public TagViewModel Tag { set; get; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shunshine.App.EntityCodeFirst
{
    public class ProductTag : EntityPrimaryKey<int>
    {
        public ProductTag(int productId, string tagId)
        {
            ProductId = productId;
            TagId = tagId;
        }
        public int ProductId { get; set; }

        [StringLength(50)]
        public string TagId { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
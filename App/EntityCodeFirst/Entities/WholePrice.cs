using System.ComponentModel.DataAnnotations.Schema;
 
namespace shunshine.App.EntityCodeFirst
{
    [Table("WholePrices")]
    public class WholePrice : EntityPrimaryKey<int>
    {
        public WholePrice(int productId, int fromQuantity, int toQuantity,decimal price)
        {
            ProductId = productId;
            FromQuantity = fromQuantity;
            ToQuantity = toQuantity;
            Price = Price;

        }
        public int ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
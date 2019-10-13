using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shunshine.App.EntityCodeFirst
{
    [Table("Sizes")]
    public class Size : EntityPrimaryKey<int>
    {
        public Size() { }
        public Size(string name)
        {
            Name = name;
        }
        [StringLength(250)]
        public string Name
        {
            get; set;
        }
    }
}
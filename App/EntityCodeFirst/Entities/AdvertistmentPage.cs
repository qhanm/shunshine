using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace shunshine.App.EntityCodeFirst
{
    [Table("AdvertistmentPages")]
    public class AdvertistmentPage : EntityPrimaryKey<string>
    {
        public AdvertistmentPage() { }
        public AdvertistmentPage(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public virtual ICollection<AdvertistmentPosition> AdvertistmentPositions { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace shunshine.App.EntityCodeFirst
{
    public class Tag : EntityPrimaryKey<string>
    {
        public Tag(string name, string type)
        {
            Name = name;
            Type = type;
        }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}
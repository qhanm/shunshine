using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shunshine.App.EntityCodeFirst
{
    [Table("Footers")]
    public class Footer : EntityPrimaryKey<string>
    {
        public Footer(string content)
        {
            Content = content;
        }
        [Required]
        public string Content { set; get; }
    }
}
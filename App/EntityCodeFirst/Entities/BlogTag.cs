using System.ComponentModel.DataAnnotations.Schema;

namespace shunshine.App.EntityCodeFirst
{
    [Table("BlogTags")]
    public class BlogTag : EntityPrimaryKey<int>
    {
        public BlogTag(int blogId, string tagId)
        {
            BlogId = blogId;
            TagId = tagId;
        }

        public int BlogId { set; get; }

        public string TagId { set; get; }

        [ForeignKey("BlogId")]
        public virtual Blog Blog { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
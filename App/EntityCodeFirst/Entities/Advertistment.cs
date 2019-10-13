using qhn.Data.Entity.Interfaces;
using qhnam.Data.Entity.Interfaces;
using shunshine.App.EntityCodeFirst.Constant;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shunshine.App.EntityCodeFirst
{
    [Table("Advertistments")]
    public class Advertistment : EntityPrimaryKey<string>, ISwitchable, ISortable
    {
        public Advertistment()
        {
        }

        public Advertistment(string name, string desciption, string image, string url, string positionId, Status status, DateTime dateCreate, DateTime dateModified, int sortOrder)
        {
            Name = name;
            Description = desciption;
            Image = image;
            Url = url;
            PositionId = positionId;
            Status = status;
            DateCreated = dateCreate;
            DateModified = dateModified;
            SortOrder = sortOrder;
        }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        [StringLength(20)]
        public string PositionId { get; set; }

        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public int SortOrder { set; get; }

        [ForeignKey("PositionId")]
        public virtual AdvertistmentPosition AdvertistmentPosition { get; set; }
    }
}
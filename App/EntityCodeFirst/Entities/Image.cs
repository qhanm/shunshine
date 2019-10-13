using qhnam.Data.Entity.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shunshine.App.EntityCodeFirst.Entities
{
    [Table("Images")]
    public class Image : EntityPrimaryKey<int>, IDateTracking
    {
        public Image()
        {
        }

        public Image(int id, string name, Guid? userId, string caption, string description, string alt, string url, int? year, int? month, string type, int size, string extension)
        {
            Id = id;
            Name = name;
            Caption = caption;
            Description = description;
            Alt = alt;
            Url = url;
            UserId = userId;
            Month = month;
            Year = year;
            Type = type;
            Size = size;
            Extension = extension;
        }

        public Image(string name, Guid? userId, string caption, string description, string alt, string url, int? year, int? month, string type, int size, string extension)
        {
            Name = name;
            Caption = caption;
            Description = description;
            Alt = alt;
            UserId = userId;
            Month = month;
            Year = year;
            Type = type;
            Size = size;
            Extension = extension;
        }

        public Guid? UserId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public string Caption { get; set; }

        public string Description { get; set; }

        [StringLength(150)]
        public string Alt { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public int Size { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(20)]
        public string Extension { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
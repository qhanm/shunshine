using System;
using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class ImageViewModel
    {
        public int Id { get; set; }

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
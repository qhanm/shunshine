using shunshine.App.EntityCodeFirst.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class AnnouncementViewModel
    {
        [Required]
        [StringLength(250)]
        public string Title { set; get; }

        [StringLength(250)]
        public string Content { set; get; }

        public Guid UserId { set; get; }

        public AppUserViewModel AppUser { get; set; }

        public ICollection<AnnouncementUserViewModel> AnnouncementUsers { get; set; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
    }
}
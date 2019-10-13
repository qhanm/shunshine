using System;
using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class AnnouncementUserViewModel
    {
        [StringLength(128)]
        [Required]
        public string AnnouncementId { get; set; }

        public Guid UserId { get; set; }

        public bool? HasRead { get; set; }
        public AnnouncementViewModel Announcement { get; set; }
    }
}
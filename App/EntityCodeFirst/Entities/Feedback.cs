using qhn.Data.Entity.Interfaces;
using qhnam.Data.Entity.Interfaces;
using shunshine.App.EntityCodeFirst.Constant;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shunshine.App.EntityCodeFirst
{
    [Table("Feedbacks")]
    public class Feedback : EntityPrimaryKey<int>, ISwitchable, IDateTracking
    {
        public Feedback()
        {
        }

        public Feedback(string name, string email, string message, Status status)
        {
            Name = name;
            Email = email;
            Message = message;
            Status = status;
        }

        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(500)]
        public string Message { set; get; }

        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
    }
}
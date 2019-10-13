using shunshine.App.EntityCodeFirst.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace shunshine.App.Models.ViewModels
{
    public class BillViewModel
    {
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public PaymentMethod PaymentMethod { set; get; }

        public BillStatus BillStatus { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        public Status Status { set; get; } = Status.Active;

        public Guid? CustomerId { set; get; }

        public virtual AppUserViewModel User { set; get; }

        public ICollection<BillDetailViewModel> BillDetails { set; get; }
    }
}
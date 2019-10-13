using System;
using System.Collections.Generic;
using System.Text;

namespace shunshine.App.Models.ViewModels
{
    public class BillDetailViewModel
    {
        public int BillId { set; get; }

        public int ProductId { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public int ColorId { get; set; }

        public int SizeId { get; set; }

        public BillViewModel Bill { set; get; }

        public ProductViewModel Product { set; get; }

        public ColorViewModel Color { set; get; }

        public SizeViewModel Size { set; get; }
    }
}

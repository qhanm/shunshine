using System;
using System.Collections.Generic;
using System.Text;

namespace shunshine.App.Models.ViewModels
{
    public class AdvertistmentPageViewModel
    {
        public string Name { get; set; }

        public ICollection<AdvertistmentPositionViewModel> AdvertistmentPositions { get; set; }
    }
}

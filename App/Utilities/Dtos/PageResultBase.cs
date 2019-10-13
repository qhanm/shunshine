using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.Utilities.Dtos
{
    public abstract class PageResultBase
    {
        public int CurrnetPage { get; set; }

        public int RowCount { get; set; }

        public int PageSize {get; set;}

        public int PageCount
        {
            get
            {
                var pageCount = (double)RowCount / PageSize;
                return (int)Math.Ceiling(pageCount);
            }
            set { PageCount = value; }
        }

        public int NextPage
        {
            get
            {
                return (int)(CurrnetPage + 1);
            }
        }

        public int LastPage
        {
            get
            {
                return (int)(CurrnetPage - 1);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO.Common
{
    public abstract class SMBase
    {
        public int Draw { get; set; }

        public int PageSize { get; set; } = 10;

        public int Page { get; set; } = 1;

        public string Search { get; set; }

        public string OrderColumn { get; set; }

        public string OrderDirection { get; set; }

        public string OrderCriteria
        {
            get
            {
                return OrderColumn + " " + OrderDirection;
            }
        }
    }
}

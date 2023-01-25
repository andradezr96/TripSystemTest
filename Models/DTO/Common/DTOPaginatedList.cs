using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO.Common
{
    public class DTOPaginatedList<T> where T : class
    {
        public int ResultsLength { get; set; }

        public int RecordsFiltered { get; set; }

        public List<T> Data { get; set; }
    }
}

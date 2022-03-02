using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Helpers
{
    public class Pagination<T> where T : class 
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
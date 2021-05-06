using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Layui.Razor.Model
{
    public class Page 
    {
        public List<string> Fields { get; set; }

        public string TableName { get; set; }

        public StringBuilder Where { get; set; }

        public string Orderby { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}

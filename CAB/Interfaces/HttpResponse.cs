using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB.Interfaces
{
    internal class HttpResponse<T>
    {
        public int status { get; set; }
        public string message { get; set; }
        public T content { get; set; }
    }
}

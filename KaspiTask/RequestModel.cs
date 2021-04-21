using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspiTask
{
    public class RequestModel
    {
        public OperatorTypes Type { get; set; }
        public SendModel Data { get; set; }
    }
}

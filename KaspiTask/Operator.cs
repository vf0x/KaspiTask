using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspiTask
{
    public abstract class Operator
    {
        public abstract void Send(SendModel model);
    }
}

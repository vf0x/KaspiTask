using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspiTask
{
    public class Altel : Operator
    {
        public override void Send(SendModel model)
        {
            System.Console.WriteLine("Send Request Altel");
        }
    }
}

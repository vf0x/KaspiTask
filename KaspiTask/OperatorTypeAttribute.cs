using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspiTask
{
    public class OperatorTypeAttribute : Attribute
    {
        private Type _implementation {get;}

        public Operator CreateInstance => (Operator)Activator.CreateInstance(_implementation);

        public OperatorTypeAttribute(Type implementation)
        {
            _implementation = implementation;
        }
    }
}

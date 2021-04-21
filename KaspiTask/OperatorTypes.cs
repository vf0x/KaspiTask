using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspiTask
{
    public enum OperatorTypes
    {
        [OperatorTypeAttribute(typeof(Altel))]
        Altel,
        [OperatorTypeAttribute(typeof(Activ))]
        Activ,
        [OperatorTypeAttribute(typeof(Tele2))]
        Tele2
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspiTask
{
    public static class OperatorTypeHelper
    {
        public static Operator GetDiscountRateImplementation(this Enum operatorType)
        {
            var attribute = typeof(OperatorTypes).GetFields()
                .Where(f => f.Name == operatorType.ToString())
                .FirstOrDefault()
                ?.GetCustomAttributes(false).First() as OperatorTypeAttribute;

            if (attribute != null)
                return attribute.CreateInstance;

            throw new NotImplementedException();
        }
    }
}

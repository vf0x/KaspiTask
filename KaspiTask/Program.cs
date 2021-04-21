using System;

namespace KaspiTask
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestModel request = new RequestModel
            {
                Type = OperatorTypes.Tele2, 
                Data = new SendModel
                {
                    Number = "+77756322777",
                    Amount = 500
                }
            };

            var operat = OperatorTypeHelper.GetDiscountRateImplementation(request.Type);
            operat.Send(request.Data);
        }
    }
}

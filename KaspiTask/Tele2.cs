﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspiTask
{
    public class Tele2 : Operator
    {
        public override void Send(SendModel model)
        {
            System.Console.WriteLine("Send Request Tele2");
        }
    }
}

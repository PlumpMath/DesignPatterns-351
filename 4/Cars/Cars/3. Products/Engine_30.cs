﻿using Cars._2._AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars._3._Products
{
    class Engine_30 : Engine
    {
        public override void HasVolume()
        {
            Console.WriteLine("Engine Volume - 3.0 liters");
        }
    }
}

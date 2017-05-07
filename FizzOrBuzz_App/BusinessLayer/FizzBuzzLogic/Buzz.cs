﻿using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FizzBuzzLogic
{
    public class Buzz : IFizzOrBuzz
    {
        public bool ReturnIntegerValueFor(int value)
        {
            return value % 5 == 0;
        }

        
    }
}

using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FizzBuzzLogic
{
   public class Fizz : IFizzOrBuzz
    {
        public int ReturnIntegerValueFor(int value)
        {
            return value % 3;
        }
    }
}

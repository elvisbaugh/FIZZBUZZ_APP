using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FizzBuzzLogic
{
   public class FizzOrBuzz
    {
        public IFizzOrBuzz getFizzOrBuzz;

        public FizzOrBuzz(IFizzOrBuzz getFizzOrBuzz)
        {
           this.getFizzOrBuzz = getFizzOrBuzz;

        }

        public int ReturnFizzOrBuzz(int value)
        {
            return getFizzOrBuzz.ReturnIntegerValueFor(value);
        }

    }

}

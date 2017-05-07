using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FizzBuzzData
    {
        [Required(ErrorMessage ="an integer value is required")]
        public int ValueEntered { get; set; }
    }
}

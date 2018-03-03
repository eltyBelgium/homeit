using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class GrocerieModel
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public bool GotIt { get; set; }
    }
}

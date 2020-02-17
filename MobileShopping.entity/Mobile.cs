using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopping.entity
{
    public class Mobile
    {
       public string BrandName { get; set; }
        public string Model { get; set; }
        public int Id { get; set; }
        public string Color { get; set; }
    
        public double Price { get; set; }
    }
}

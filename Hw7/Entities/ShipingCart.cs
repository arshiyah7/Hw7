using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7.Entities
{
    public class ShipingCart
    {
        public int Id { get; set; }
        public List<Product> products { get; set; } = new List<Product>();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Model.Enities
{
    public class productModel
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public DateTime CreateAT { get; set; } = DateTime.Now;                                          



    }
}

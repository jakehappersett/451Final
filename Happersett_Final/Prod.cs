using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Happersett_Final
{
    public class Prod
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }


        public Prod()
        {

        }

        public Prod(int ProductID, string Name, string Description, double Price, string Type)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Type = Type;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace session_1
{
    internal class Product
    {
        public string Name { get; set; }
        private double price { get; set; }
        public double Price {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Price cannot be negative");
                }
                else
                {
                    price = value;
                    Console.WriteLine($"Price: {price}");
                }
               
            }
        }
        private int  stockQuantity { get; set; }
        public int StockQuantity
        {
            get { return stockQuantity; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("StockQuantity cannot be negative");
                }
                else
                {
                    stockQuantity = value;
                    Console.WriteLine($"StockQuantity: {stockQuantity}");
                }

            }
        }

        public bool IsAvailable {
            get {
                if (StockQuantity > 0)  return true;
                else  return false;      
            }  
        }

    }
}

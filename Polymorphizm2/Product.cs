using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphizm2
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public abstract void GetInfo();
    }
}

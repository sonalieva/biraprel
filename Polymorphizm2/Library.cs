using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphizm2
{
    class Library
    {
        public Product[] Products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;

        }
        public Product[] GetProductsByPrice(int minPrice, int maxPrice)
        {
            Product[] ChoosingProducts = new Product[0];
            int x= 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if ( minPrice< Products[i].Price &&  maxPrice> Products[i].Price)
                {
                    Array.Resize(ref ChoosingProducts, ChoosingProducts.Length + 1);
                    ChoosingProducts[x] = Products[i];
                    x++;
                }
            }
            return ChoosingProducts;
        }
        public Product[] GetProductByName(string smth)
        {
            Product[]  ChoosingProducts = new Product[0];
            int x = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name.Contains(smth))
                {
                    Array.Resize(ref ChoosingProducts, ChoosingProducts.Length + 1);
                    ChoosingProducts[x] = Products[i];
                    x++;
                }
            }
            return ChoosingProducts;
        }
    }
}


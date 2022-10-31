using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b4product;

namespace ConsoleApp3
{
    public class productDemo
    {
        public Product createProductTest()
        {
            Product product = new Product();
            product.Name=Console.ReadLine();
            product.Id=Convert.ToInt32(Console.ReadLine());
            product.categoryId=Convert.ToInt32(Console.ReadLine());
            return product;
        }
        public void printProduct(Product product)
        {
            Console.WriteLine(product.Name + "  " + product.Id + "  " + product.categoryId);
        }
    }
}

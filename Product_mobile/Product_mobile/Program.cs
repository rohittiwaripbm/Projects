using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_mobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Mobile m = new Mobile();

            Console.WriteLine("Enter product name");
            p.name = Console.ReadLine();  
            Console.WriteLine("enter product price");
            p.price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter brand name");
            p.brandname = Console.ReadLine();

            m = ProducttoMobile(p);

            Console.WriteLine("Name "+ m.mobilename);
            Console.WriteLine("Price "+ m.mobileprice);
            Console.WriteLine("Brand name "+ m.mobilebrandname);
                
                
                
        }

        private static Mobile ProducttoMobile(Product p)
        {
            Mobile mobile = new Mobile();
            mobile.mobilename = p.name;
            mobile.mobileprice = p.price;
            mobile.mobilebrandname = p.brandname;
            return mobile;
        }
    }
}

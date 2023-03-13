using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableCollections
{
    public class DisplayAll
    {

        public static void PrintWithoutDelete()
        {
            foreach (var i in ListClass.DisplayList())
            {
                if (i.DeleteStatus == false && i.Updated)
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Product Added By : " + i.Username);
                    Console.WriteLine();
                    Console.WriteLine("Product Id : " + i.ProductId);
                    Console.WriteLine();
                    Console.WriteLine("Product Name : " + i.ProductName);
                    Console.WriteLine();
                    Console.WriteLine("Product Price : " + i.ProductPrice);
                    Console.WriteLine();
                    Console.WriteLine("Up" +
                            "date on : " + i.ProductStartDate.ToString());
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine();
                }

            }
        }
        public static void PrintaAll()
        {
            foreach (var i in ListClass.DisplayList())
            {
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("Product Id : " + i.ProductId);
                Console.WriteLine();
                Console.WriteLine("Product Name : " + i.ProductName);
                Console.WriteLine();
                Console.WriteLine("Product Price : " + i.ProductPrice);
                Console.WriteLine();
                    Console.WriteLine("Up" +
                        "date on : " + i.ProductStartDate.ToString());
                    Console.WriteLine();
                if (i.Updated == false)
                {
                    Console.WriteLine("Last Update on " +
                        " " + i.ProductEndDate.ToString());
                }
                if (i.DeleteStatus == true)
                {
                    Console.WriteLine("Product Deleted by : " + i.DeleteProductUsername);
                    Console.WriteLine("Product Status : Not Active");
                    Console.WriteLine();
                    Console.WriteLine("Product Delete Date : " + i.ProductDeleteDate);
                }
                else
                {
                    Console.WriteLine("Product Status : Active");
                }
                Console.WriteLine("----------------------------------------------");

                Console.WriteLine();
                Console.WriteLine();

            }
        }

        public static void DisplaySingleProducts(int number)
        {
            int counter = 0;
            foreach(var i in ListClass.DisplayList()) 
            { 
               
                if(i.ProductId==number)
                {
                    counter++;

                    if (i.DeleteStatus == true)
                    {
                        Console.WriteLine(i.ProductStartDate.ToString() +" "+ i.Username+ 
                            " " + i.ProductId + " " +
                            i.ProductName + " " +
                        "" + i.ProductEndDate + " " + " Not Active " + " " + i.ProductDeleteDate
                        +"  " + i.DeleteProductUsername);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(i.ProductStartDate.ToString() +" "+ i.Username+ " " + i.ProductId + " " +
                            i.ProductName + " " +
                            "" + i.ProductEndDate + " " + "Active" + " ");
                        Console.WriteLine();
                    }
                        
                        
               
                }
            }
            if(counter ==0)
            {
                Console.WriteLine("Product Not present");
            }
        }
    }
}

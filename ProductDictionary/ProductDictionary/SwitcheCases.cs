using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDictionary
{
    public class SwitcheCases
    {


        public static void UserChoice()
        {
            bool choice = true;
            do
            {
                Console.WriteLine(" Please Select an Option\n 1. Add " +
                    "Product  \n 2. Update Product \n 3. Delete Product \n 4. " +
                    "Display Products \n 5. Exit \n 6. Search Product");
                int User_Choice = Program.NumberChecker(Console.ReadLine());
                if (User_Choice == 1)
                {
                    Program.AddItems();
                }
                else if (User_Choice == 2)
                {
                    updateProduct.UpdateProduct();

                    Console.WriteLine();
                }
                else if (User_Choice == 3)
                {
                    DeleteProduct.DeleteProductMethod();
                }
                else if (User_Choice == 4)
                {
                    if (Program.ProductDictionary.Count == 0)
                    {
                        Console.WriteLine("No product Available Please " +
                            "Enter a Product first");
                        Program.AddItems();
                    }
                    Program.Display();
                    Console.WriteLine();
                }
                else if (User_Choice == 5)
                {
                    Console.WriteLine("Thanks for Using this Application");
                    choice = false;
                }
                else if(User_Choice == 6)
                {
                    Console.WriteLine("Enter Product Id");
                    string id = Console.ReadLine();
                   bool check =  SearchProduct.SearchProduct1(id);
                    if(check)
                    {
                        Console.WriteLine(Program.ProductDictionary[id]);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No Product found");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Input");
                }

            } while (choice);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Task
{
    public class SwitcheCases
    {
        
        
        public static void UserChoice(){
            bool choice = true;
            do
            {
                Console.WriteLine(" Please Select an Option\n 1. Add " +
                    "Product  \n 2. Update Product \n 3. Delete Product \n 4. " +
                    "Display Products \n 5.Exit");
                int User_Choice = Program.NumberChecker(Console.ReadLine());
                if(User_Choice == 1)
                {
                    Program.AddProducts();
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
                    if(Program.productList.Count== 0)
                    {
                        Console.WriteLine("No product Available Please " +
                            "Enter a Product first");
                        Program.AddProducts();
                    }
                    Program.Display();
                    Console.WriteLine();
                }
                else if (User_Choice == 5)
                {
                    Console.WriteLine("Thanks for Using this Application");
                    choice= false;
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Input");
                }

            }while(choice);
            }
    }
}

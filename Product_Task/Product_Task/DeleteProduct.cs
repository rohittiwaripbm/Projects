using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Task
{
    public class DeleteProduct
    {
        public static void DeleteProductMethod()
        {
            Console.WriteLine("Enter Product Id");
            int UprodutId = Program.NumberChecker(Console.ReadLine());
            Console.WriteLine();

            bool CanDelete = false;
            int counter = 0;
            foreach (Product p in Program.productList)
            {

                if (Program.productList[counter].GetProductId() == UprodutId)
                {
                    CanDelete = true;
                    break;
                }
                counter++;

            }
            if (CanDelete)
            {
                Program.productList.RemoveAt(counter);
                Console.WriteLine("Product Deleted Successfully") ;

            }
            else
            {
                Console.WriteLine("Product Id not Present");
            }
        }
    }
}

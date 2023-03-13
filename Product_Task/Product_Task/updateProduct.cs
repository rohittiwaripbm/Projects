using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Task
{
    public class updateProduct
    {
        
        public static void UpdateProduct() {
            Console.WriteLine("Enter Product Id");
            int UprodutId = Program.NumberChecker(Console.ReadLine());
            Console.WriteLine();
           
            bool CanUpdate = false;
            int counter = 0;
            foreach (Product p in Program.productList)
            {
                
                if(Program.productList[counter].GetProductId() == UprodutId)
                {
                    CanUpdate= true;
                    break;
                }
                counter++;

            }
            if (CanUpdate)
            {
                Console.WriteLine("Enter brand Id");
                int UBrandId = Program.NumberBrandChecker(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter Product Name");
                string UPname = Program.NullStringChecker(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter Manufacturing Date");
                DateTime UManufacturingDate = Program.DateChecker(Console.ReadLine());

                Program.productList[counter].SetBrandId(UBrandId);
                Program.productList[counter].SetProductName(UPname);
                Program.productList[counter].SetManufacturingDate(UManufacturingDate);
                Console.Clear();
                Console.WriteLine("Product Updated Successfully");
                Program.Display();



            }
            else
            {
                Console.WriteLine("Product Id not Present");
            }

        }
    }
}

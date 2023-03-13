using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProductDictionary
{
    public class updateProduct
    {

        public static void UpdateProduct()
        {
            //Dictionary<string,Product> dic = new Dictionary<string, Product>();

           // dic["ss"].SetProductId(4);
            Console.WriteLine("Enter Product Id");
            int UprodutId = Program.NumberChecker(Console.ReadLine());
            Console.WriteLine();

            bool CanUpdate = false;
            int counter = 0;
            if(Program.ProductDictionary.ContainsKey(UprodutId.ToString()))
            {
                CanUpdate= true;
            }
            
            //foreach (Product p in Program.productList)
            //{

            //    if (Program.productList[counter].GetProductId() == UprodutId)
            //    {
            //        CanUpdate = true;
            //        break;
            //    }
            //    counter++;

            //}
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

                //Program.ProductDictionary[UprodutId] = Product.SetProductId(UBrandId);
                Program.ProductDictionary[UprodutId.ToString()].SetBrandId(UBrandId);
                Program.ProductDictionary[UprodutId.ToString()].SetProductName(UPname);
                Program.ProductDictionary[UprodutId.ToString()].SetManufacturingDate(UManufacturingDate);


                //Program.productList[counter].SetBrandId(UprodutId);
                //Program.productList[counter].SetProductName(UPname);
                //Program.productList[counter].SetManufacturingDate(UManufacturingDate);
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

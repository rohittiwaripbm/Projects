using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDictionary
{
    public class Product
    {

        private int BrandId;
        private string productName;
        private string ManufacturingMonth;
        private int ManufacturingYear;
        private string ProductId;
        private string ReturnExpiry;

        public void SetBrandId(int brandId)
        {
            this.BrandId = brandId;
        }
        public void SetProductName(string PName)
        {
            this.productName = PName;
        }
        public string GetProductName()
        {
            if (this.productName.Length >= 11)
            {
                return this.productName.Substring(0, 7) + "...";
            }

            return this.productName;
        }
        private DateTime ManufacturingDate;

        public void SetManufacturingDate(DateTime date)
        {
            this.ManufacturingDate = date;
            this.ManufacturingMonth = ManufacturingDate.ToString("MMMM");
            this.ManufacturingYear = ManufacturingDate.Year;

        }
        public DateTime GetManufacturingDate()
        {
            return this.ManufacturingDate;
        }



        public bool isExpired
        {
            get
            {
                if (DateTime.Today > ManufacturingDate.AddMonths(6))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public DateTime ExpiryDate
        {
            get
            {
                return ManufacturingDate.AddMonths(6);
            }
        }

        public void SetProductId(string ProductId)
        {
            this.ProductId = ProductId.ToString();
        }
        public string GetProductId()
        {
            return this.ProductId;
        }

        public void displayItems()
        {
            Console.WriteLine("Product Id : " + this.ProductId);
            Console.WriteLine("Product Name : {0}", GetProductName());
            Console.WriteLine("Manufacturing Date : {0}", GetManufacturingDate().GetDateTimeFormats());
            if (isExpired)
            {
                Console.WriteLine("Product is Expired");
            }
            else
            {
                Console.WriteLine("Product is Safe to Use");
            }
            Console.WriteLine("Product Manufactured Month : {0}", ManufacturingMonth);
            Console.WriteLine("Product Manufactured Year : {0}", ManufacturingYear);
            Console.WriteLine("Product Expiry Date : {0}", ExpiryDate.GetDateTimeFormats());
        }

        public override string ToString()
        {
            if (isExpired)
            {
                ReturnExpiry = "Expired";
            }
            else
            {
                ReturnExpiry = "Safe to Use";
            }
            
            return " Product Id : " + this.ProductId + "\n Product name :  " + productName + " " +
                "\n Manufacturing Date  : " + ManufacturingDate +
                "\n " + ReturnExpiry + "\n Manufacturing Date  : " + ManufacturingMonth +
                "\n Manufacturing year : " + ManufacturingYear + " \n Expiry Date : " +
                ExpiryDate;

        }


    }
}

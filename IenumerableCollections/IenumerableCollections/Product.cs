using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableCollections
{
    [Serializable]
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime ProductCreatedate = DateTime.Now;
        public bool Updated = true;
        private bool ProductDeleteStatus = false;
        public DateTime ProductDeleteDate;
        public DateTime ProductStartDate = DateTime.Now; 
        public DateTime? ProductEndDate = null;
        public string Username;
        public string DeleteProductUsername;
        public bool DeleteStatus
        {
            set
            {
                ProductDeleteStatus = true;
            }
            get
            {
                return ProductDeleteStatus;
            }
        }

    }
}

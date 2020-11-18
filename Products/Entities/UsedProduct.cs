using System;
using System.Text;

namespace Products.Entities {
    class UsedProduct : Product {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { 
        
        }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag() {
            
            StringBuilder strProducts = new StringBuilder();
            strProducts.Append("(Used) ");
            strProducts.Append(base.PriceTag());
            strProducts.Append("(Manufacture date: ");
            strProducts.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            strProducts.AppendLine(")");

            return strProducts.ToString();
        }

    }
}

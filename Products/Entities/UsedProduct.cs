using System;
using System.Text;
using System.Globalization;

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

            strProducts.Append(Name);
            strProducts.Append(" (Used) $ ");
            strProducts.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            strProducts.Append(" (Manufacture date: ");
            strProducts.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            strProducts.Append(")");

            return strProducts.ToString();
        }

    }
}

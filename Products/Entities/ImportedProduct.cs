using System.Text;
using System.Globalization;

namespace Products.Entities {
    class ImportedProduct : Product {

        public double CustomsFree { get; set; }

        public ImportedProduct() {

        }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price) {
            CustomsFree = customsFree;
        }

        public double TotalPrice() {

            double total = Price + CustomsFree;

            return total;
        }

        public override string PriceTag() {

            StringBuilder strProducts = new StringBuilder();

            strProducts.Append(base.PriceTag());
            strProducts.Append(" (Customs fee: $ ");
            strProducts.Append(TotalPrice());
            strProducts.AppendLine(")");


            return strProducts.ToString();
        }
    }
}

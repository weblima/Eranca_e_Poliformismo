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

            strProducts.Append(Name);
            strProducts.Append(" $ ");
            strProducts.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            strProducts.Append(" (Customs fee: $ ");
            strProducts.Append(CustomsFree.ToString("F2", CultureInfo.InvariantCulture));
            strProducts.Append(")");

            return strProducts.ToString();
        }
    }
}

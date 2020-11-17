using System.Text;
using System.Globalization;

namespace Products.Entities {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        Product() { 
        }
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() {

            StringBuilder strProducts = new StringBuilder();

            strProducts.Append(Name);
            strProducts.Append("$ ");
            strProducts.AppendLine(Price.ToString("F2", CultureInfo.InvariantCulture));


            return strProducts.ToString();
        }
    }
}

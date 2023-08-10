using System.Globalization;

namespace Principal.Entities {
    class UsedProduct : Product {
        public DateTime ManufactoreDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactoreDate) : base(name, price) {
            ManufactoreDate = manufactoreDate;
        }

         public override string PriceTag() {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufactore date: {ManufactoreDate})";
        }
    }
}
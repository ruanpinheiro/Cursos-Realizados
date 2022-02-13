using System.Globalization;

namespace Exercice_File.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public Product()
        {
        }
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return TotalPrice = Price * Quantity;
        }

        public override string ToString()
        {
            return Name + "," + TotalPrice.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System.Collections.Generic;

namespace T1904A
{
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> productList;
        private string city;
        private string country;

        public Cart()
        {
        }

        public Cart(int id, string customer, double grandTotal, List<Product> productList, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.productList = productList;
            this.city = city;
            this.country = country;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public Product this[int index]
        {
            get => productList[index];
            set => productList[index] = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice
{
    abstract class Beverage
    {
        private string name;
        private decimal price;
        private int quantity;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Beverage(string name, decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public abstract void Open();
        public void Buy(int quantity)
        {
            if (quantity <= this.quantity)
            {
                this.quantity -= quantity;
                Console.WriteLine("You bought " + quantity + " " + name + "(s).");
            }
            else
            {
                Console.WriteLine("Not enough " + name + " in stock.");
            }
        }
        public void Restock(int quantity)
        {
            this.quantity += quantity;
            Console.WriteLine("You restocked " + quantity + " " + name + "(s).");
        }
        public void PrintDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine("Quantity: " + quantity);
        }
        class Soda : Beverage
        {
            private string flavor;
            public string Flavor
            {
                get { return flavor; }
                set { flavor = value; }
            }
            public Soda(string name, decimal price, int quantity, string flavor) : base(name, price, quantity)
            { 
                this.flavor = flavor;
            }
            public override void Open()
            {
                Console.WriteLine("You opened a can of " + Name + " " + flavor + " soda.");
            }
            public void Shake()
            {
                Console.WriteLine("You shook the can of " + Name + " " + flavor + " soda.");
            }
        }
        class Juice : Beverage
        {
            private string fruit;
            public string Fruit
            {
                get { return fruit; }
                set { fruit = value; }
            }
            public Juice(string name, decimal price, int quantity, string fruit) : base(name, price, quantity)
            {
                this.fruit = fruit;
            }
            public override void Open()
            {
                Console.WriteLine("You opened a bottle of " + Name + " " + fruit + " juice.");
            }
            public void Pour()
            {
                Console.WriteLine("You poured some " + Name + " " + fruit + " juice into a glass.");
            }
        }
    }
}

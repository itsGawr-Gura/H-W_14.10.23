using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice
{
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

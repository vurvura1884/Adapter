using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        class Cocktail
        {
            public void OrderAlcoholDrink()
            {
                Console.WriteLine("Ordering an alcoholic cocktail ");
            }
        }

        public interface Drinks
        {
            void OrderDrink();
        }

        //Adapter
        class Adapter : Drinks
        {
            private readonly Cocktail drink;
            public Adapter(Cocktail alcoholFREEdrink)
            {
                this.drink = alcoholFREEdrink;
            }
            public void OrderDrink()
            {
                Console.WriteLine("Ordering a non-alcoholic cocktail ");
            }
        }

        static void Main(string[] args)
        {
            Cocktail drink = new Cocktail();
            drink.OrderAlcoholDrink();
            Console.WriteLine("\n");
            Drinks order = new Adapter(drink);
            order.OrderDrink();
        }
    }
}

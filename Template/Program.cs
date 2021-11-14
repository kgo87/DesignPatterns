using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("Making tea...");
            tea.prepareDrink();

            Console.WriteLine("\nMaking coffee...");
            coffee.prepareDrink();
        }
    }
}

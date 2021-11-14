using System;
namespace Template
{
    public class Coffee: CaffeineDrink
    {

        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void brew()
        {
            Console.WriteLine("Brewing Coffee");
        }

        public override bool clientWantsCondiment()
        {
            return GetUserInput().ToUpper().StartsWith("Y");
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

            string answer = Console.ReadLine();

            return answer ?? "no";
        }
    }

}

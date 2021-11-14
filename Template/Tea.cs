using System;
namespace Template
{
    public class Tea: CaffeineDrink
    {
        public Tea()
        {
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void brew()
        {
            Console.WriteLine("Steeping Tea");
        }

        public override bool clientWantsCondiment()
        {
            return GetUserInput().ToUpper().StartsWith("Y");
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like lemon with your tea (y/n)? ");

            string answer = Console.ReadLine();

            return answer ?? "no";
        }
    }
}

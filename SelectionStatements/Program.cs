using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            var favNumb = r.Next(1, 1000);
            
            var helpGuess = 1 + favNumb;
            Console.WriteLine($"Guess a number? {helpGuess} The number should be your number - 1");
            var userInput = int.Parse(Console.ReadLine());
            var checkIf = ElseIfState(favNumb, userInput);
            Console.WriteLine($"Your answer is:");
            Console.WriteLine($"{userInput} is {checkIf}. It should have been {favNumb}");

            Console.WriteLine("What is your favorite subject?");
            string input = Console.ReadLine();
            string callSwitchCase = SwitchCase(input).ToLower();
            Console.WriteLine($"{callSwitchCase}");

            //Infered typing, interpolation and ternary operator
            var answer = 4;
            var response = answer < 9 ? answer + " is less than nine" : answer + " greater than or equal to nine";

            Console.WriteLine(response);


        }
        public static string IfState(int favNumb, int userInput)
        {
            
            if (userInput < favNumb)
            {
                return $"Too low";
            }
            return $"Whoa";

        }
        public static string ElseIfState(int favNumb, int userInput)
        {

            if (userInput < favNumb)
            {
                return $"Too low";
            }
            else if (userInput > favNumb)
            {
                return $"Too big";
            }
            else
            {


                return $"Whoa";
            }

        }
        public static string ElseState(int favNumb, int userInput)
        {

            if (userInput < favNumb)
            {
                return $"Too low";
            }
            else
            {
                return $"Never Mind";

            }

        }
        public static string SwitchCase(String userInput)
        {
            var user = userInput;
            switch (user)
            {
                case "Science":
                    return "Science is awesome";
                   //Console.WriteLine("Science is awesome!");
                    //break;
                case "Math":
                    return "Math is awesome";
                    //Console.WriteLine("Math is great!");
                      //break;
                default:
                    return "Any subject is awesome";
                    //Console.WriteLine("Any subject is great!");
                    //break;

              }
            //return null;

        }
    }  

}

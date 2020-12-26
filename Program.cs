using System;

namespace myFirstpROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCont = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCont < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCont++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses == true)
            {
                Console.Write("You lose!");
            }
            else 
            { 
            Console.WriteLine("You win!");
            }

            /*int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine(GetDay(0));

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
            sayHi("Andrei", 36);

            int cubeNumber = cube(5);
            Console.WriteLine(cubeNumber);

            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else
            {
                Console.WriteLine("You are eit her not tall, male or tall male");
             }
                       

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadLine();

            string color, pluralNoun, celebrity;

            Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();
            Console.WriteLine("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
           Console.WriteLine("I love " + celebrity);

            int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            luckyNumbers[1] = 90;
            Console.WriteLine(luckyNumbers[0]);

            string[] friends = new string [5];
            friends[0] = "Marc";*/

            Console.ReadLine();
        }
        static void sayHi (string name, int age)
        {
            Console.WriteLine($"Hello {name}, you are {age}!");
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number!";
                    break;
            }

            return dayName;
        }
    }
}

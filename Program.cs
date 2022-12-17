namespace Test
{
    class  Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 13;
            int number3 = 15;
            int answer1 = number1 + number2+ number3;

            Console.Write($"Please calculate {number1} + {number2} + {number3}: ");
            int response = Convert.ToInt16(Console.ReadLine());

            if (response == 38)
            {
            Console.WriteLine("Correct!");

                int number4 = 13;
                int number5 = 14;
                int number6 = 15;
                int result2 = number4 + number5 * number6;

                Console.Write($"2nd question: {number4} + {number5} * {number6}: ");
                int answer2 = Convert.ToInt16(Console.ReadLine());

                if (answer2 == 223)
                {
                    Console.WriteLine("Nice");
                
                    int number7 = 5;
                    int number8 = 3;
                    int number9 = 8;
                    int result3 = number7 * number8 * number9;

                    Console.Write($"3th question: {number7} * {number9} * {number9}: ");
                    int answer3 = Convert.ToInt16(Console.ReadLine());

                    if (answer3 == 120)
                    {
                        Console.WriteLine("You have won the game!");
                    }
                    else if (answer3 != 120)
                    {
                        Console.WriteLine("You have lost");
                    }

                } else if (answer2 != 223)
                {
                    Console.WriteLine("Better luck next time");
                }
            }
            else if (response != 38)
            {
                Console.WriteLine("Your wrong!");
            }
            else
            {
                Console.WriteLine("You pressed a wrong key!");
            }

            Console.ReadKey();
        }
    }
} 
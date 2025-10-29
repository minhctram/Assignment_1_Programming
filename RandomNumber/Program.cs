namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Enter your guess number: ");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber > 1 && guessedNumber < 3)
            {
                if (guessedNumber == correctNumber)
                {
                    Console.WriteLine("Your guessed number is correct");
                }
                else
                {
                    if (guessedNumber > correctNumber)
                    {
                        Console.WriteLine("Your guessed number is greater than correct");
                    }
                    else
                    {
                        Console.WriteLine("Your guessed number is less than correct");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your guessed number is outside of the range of numbers that are valid guesses between 1 and 3");
            }
            
        }
    }
}
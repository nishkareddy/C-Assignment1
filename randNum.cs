namespace Chapter03;

    public class trial
    {
        public void GuessNum()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            Console.WriteLine("Guess the num:");
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Out of range");
            }
            else if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Too high");
            }
        }
    }

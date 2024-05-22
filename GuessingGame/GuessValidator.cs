class GuessValidator
{
    public static int GetInput()
    {
        while(true)
        {
            Console.WriteLine("Please guess a Number between 1 to 100.\nYour guess: ");
            if (!int.TryParse(Console.ReadLine(), out int guess))
            {
                Console.WriteLine("You entered not a number.");
                continue;
            }
            if (guess > GuessingGame.Max || guess < GuessingGame.Min)
            {
                Console.WriteLine("Your number was out of range.");
                continue;
            }
            return guess;
        }
    }
}
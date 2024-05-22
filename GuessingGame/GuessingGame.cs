class GuessingGame
{
    public static readonly int Min = 1;
    public static readonly int Max = 100;
    public readonly int _randomNumber = new Random().Next(Min, Max);
    private uint _remainingAttempts = 10;

    public PlayerType Start()
    {
        while (true)
        {
            int guess = GuessValidator.GetInput();
            Console.WriteLine(_randomNumber);
            if (guess != _randomNumber)
            {
                _remainingAttempts -= 1;
                if (_remainingAttempts == 0)
                {
                    Console.WriteLine("Oops.Sorry you have 0 Attempts left. You lost.");
                
                    return PlayerType.Computer;
                }
                if (guess > _randomNumber)
                {
                    Console.WriteLine($"Your guess is too high. Please try again. You have {_remainingAttempts} Attempts left.");
                }
                else
                {
                    Console.WriteLine($"Your guess is too low. Please try again. You have {_remainingAttempts} Attempts left.");
                }
            }
            else
            {
                Console.WriteLine("Game Ends. You won.");
                return PlayerType.Player;
            }
        }
    }
}
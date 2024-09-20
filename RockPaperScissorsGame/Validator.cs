namespace RockPaperScissorsGame;

public static class Validator
{
    public static void ValidateArgs(string[] args)
    {
        if (args.Length < 3 || args.Length % 2 == 0)
        {
            throw new ArgumentException("Moves numbers must be greater than 3 and only odd");
        }

        if (args.Distinct().Count() != args.Length)
        {
            throw new ArgumentException("Moves must be unique.");
        }
    }
}

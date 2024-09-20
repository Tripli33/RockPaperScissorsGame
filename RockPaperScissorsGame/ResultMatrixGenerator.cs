namespace RockPaperScissorsGame;

public static class ResultMatrixGenerator
{
    public static string[,] GenerateResultMatrix(int moves)
    {
        var p = moves / 2;
        var result = new string[moves, moves];

        for (int i = 0; i < moves; i++)
        {
            for(int j = 0; j < moves; j++)
            {
                var temp = Math.Sign((i - j + p + moves) % moves - p); 
                result[i, j] = ResultToStrFormat(temp);
            }
        }

        return result;
    }

    private static string ResultToStrFormat(int result)
    {
        return result switch
        {
            1 => "Win",
            -1 => "Lose",
            0 => "Draw",
            _ => "Invalid result"
        };
    }

}

using ConsoleTables;

namespace RockPaperScissorsGame;

public static class TableGenerator
{
    public static ConsoleTable GenerateTable(string[] args, string[,] resultMatrix)
    {
        var table = new ConsoleTable("v PC\\User > ").AddColumn(args);
        var temp = new string[args.Length + 1];

        for (int i = 0; i < args.Length; i++)
        {
            temp[0] = args[i];
            for (int j = 0; j < args.Length; j++)
            {
                temp[j + 1] = resultMatrix[i, j];
            }

            table.AddRow(temp.ToArray());
        }

        return table;
    }
}
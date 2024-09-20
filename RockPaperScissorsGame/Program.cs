using RockPaperScissorsGame;

Validator.ValidateArgs(args);

var random = new Random();
var resultMatrix = ResultMatrixGenerator.GenerateResultMatrix(args.Length);
var resultTable = TableGenerator.GenerateTable(args, resultMatrix);


while (true)
{
    var computerMove = random.Next(0, args.Length);
    var key = KeyProvider.GenerateRandomSecureKey256();
    var hmac = HmacProvider.GenerateHmacWithSha256(key, args[computerMove]);

    Console.WriteLine($"HMAC: {hmac}");

    for (int i = 0; i < args.Length; i++)
    {
        Console.WriteLine($"{i + 1} - {args[i]}");
    }

    Console.WriteLine("0 - exit");
    Console.WriteLine("? - help");
    Console.Write("Enter your move: ");

    var userInput = Console.ReadLine();

    switch (userInput) 
    {
        case "?":
            resultTable.Write();
            Thread.Sleep(1500);
            Console.Clear();
            break;
        case "0":
            Console.Clear();
            Console.WriteLine("Goodbye!");
            return;
        default:
            if (!int.TryParse(userInput, out var userMove) || userMove > args.Length)
            {
                Console.WriteLine("Invalid move");
                Thread.Sleep(1500);
                Console.Clear();
                break;
            }

            Console.WriteLine($"Your move: {args[userMove - 1]}");
            Console.WriteLine($"Computer move: {args[computerMove]}");
            Console.WriteLine(resultMatrix[userMove - 1, computerMove]);
            Console.WriteLine($"HMAC key: {key}");
            Console.WriteLine(@"U can check HMAC in https://www.devglan.com/online-tools/hmac-sha256-online");

            Thread.Sleep(5000);
            Console.Clear();
            break;       
    }
}

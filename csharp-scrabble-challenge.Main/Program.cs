using csharp_scrabble_challenge.Main;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scrabble!\n");
        Console.WriteLine("Try putting in a word:\n");

        string? input = Console.ReadLine();

        Scrabble scrabble = new Scrabble(input);
        scrabble.score();
    }
}


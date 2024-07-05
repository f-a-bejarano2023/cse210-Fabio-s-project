using System;

public class Program
{
    private Scripture _scripture;
    private Hider _hider;

    public Program(Scripture scripture, Hider hider)
    {
        _scripture = scripture;
        _hider = hider;
    }

    private void ClearConsole()
    {
        Console.Clear();
    }

    public void Run()
    {
        while (!_scripture.IsFullyHidden())
        {
            ClearConsole();
            Console.WriteLine(_scripture);
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");

            var userInput = Console.ReadLine();
            if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            _hider.HideWords(3, 6); // Hide between 3 and 6 words each time
        }

        ClearConsole();
        if (_scripture.IsFullyHidden())
        {
            Console.WriteLine("All words are hidden. Goodbye!");
        }
        else
        {
            Console.WriteLine("Goodbye!");
        }
    }

    public static void Main(string[] args)
    {
        var reference = new Reference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        var hider = new Hider(scripture);
        var program = new Program(scripture, hider);
        program.Run();
    }
}


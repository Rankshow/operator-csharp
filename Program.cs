namespace Operators;

class Program
{
    static void Main(string[] args)
    {
     bool status = false;
     bool result = status & generatedStatus();
     Console.WriteLine($"Huge result {result}");
    }
    private static bool generatedStatus()
    {
        Console.WriteLine("Thestatement is fine");
        return true;
    }
}

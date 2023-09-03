namespace Operators;

class Program
{
    static void Main(string[] args)
    {
       int result =  newValue()
       ;
    //    ! conditional statement
    //    if ( result <= 20)
    //    {
    //    Console.WriteLine("Yes, it is...");
    //    }
    //    else Console.WriteLine("Hmm! wrong answer...");    
     Console.WriteLine($"Nice {result}");     
    }
    private static int getIncrement()
    {
        int a = 21;
        --a;
        return a;
    }
    private static int newValue()
    {
        // int b = 40;
        // int c = 11;
        // b *= c;
        // return b;
        int x = 20;
        x--;
        return x;
    }
}

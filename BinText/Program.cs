namespace BinText;

class Program
{
    static void Main(string[] args)
    {
        //Test
        var testString = "Hello World";
        var result = BinLib.TextToBin(testString);
        Console.WriteLine(result);
    }
}
// See https://aka.ms/new-console-template for more information
// Create a function that reverse a string
// Example:
// Input: "Master The Coding Interview Training"
// Output: "gniniarT weivretnI gnidoC ehT retsaM"
using MasterTheCodingInterviewTraining;

internal class Teste
{
    static void Main(string[] args)
    {
        string str = "Master The Coding Interview Training";

        Console.WriteLine(str);
        Console.WriteLine(ReverseString.ReverseTheString(str));
        Console.WriteLine(ReverseString2.ReverseTheString(str));
    }
}

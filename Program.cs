// See https://aka.ms/new-console-template for more information
// Gave an arrays and a sum, verify if exists a pair that
// the sum is equals to the value gave
// Example:
// [1, 2, 3, 9] and sum = 8 returns False
// [1, 2, 4, 4] and sum = 8 returns True
using MasterTheCodingInterviewTraining;

internal class Teste
{
    static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 5];
        int sum = 8;

        //Console.WriteLine(HasPairWithSum.CheckIfHasPairWithSum(array, sum));
        Console.WriteLine(HasPairWithSum2.CheckIfHasPairWithSum(array, sum));
    }
}

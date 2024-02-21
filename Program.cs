// See https://aka.ms/new-console-template for more information
// given two sorted arrays, merge then sorted
// example:
// input: [0,3,4,31], [4,6,30]
// output: [0,3,4,4,6,30,31]
using MasterTheCodingInterviewTraining;

internal class Teste
{
    public static void Main(string[] args)
    {
        int[] arr1 = [0, 3, 4, 31, 101];
        int[] arr2 = [4, 6, 30, 35, 43, 49, 87, 95, 113, 215];
        //int[] arr2 = null;

        Console.WriteLine(string.Join(" ", MergeSortedArrays.MergeTheArrays(arr1, arr2)));
    }
}

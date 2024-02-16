// See https://aka.ms/new-console-template for more information
// Given 2 arrays, create a funtion that
// let's a user know (true/false) whether
// these two arrays contain any common items
// For example:
// const array1 = ['a', 'b', 'c', 'x']
// const array2 = ['z', 'y', 'i']
// should return false
// --------------------
// const array1 = ['a', 'b', 'c', 'x']
// const array2 = ['z', 'y', 'x']
// should return true

using MasterTheCodingInterviewTraining;

internal class Teste { 
    static void Main(string[] args)
    {
        Object[] array1 = ['a', 'b', 'c', 'x'];
        Object[] array2 = ['z', 'w', 'v'];
        
        Console.WriteLine(ContaisCommonItems.HasCommonItems(array1, array2));
    } 
}

//O(a*b)
//We need to do a better solution


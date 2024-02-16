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

List<char> items1 = new List<char>();
List<char> items2 = new List<char>();

string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    items1.Add(input[i]);
}

input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    items2.Add(input[i]);
} 

if (items1.Count > 0 && items2.Count > 0)
{
    for (int i = 0;i < items1.Count; i++)
    {
        for (int j = 0;j < items2.Count; j++)
        {
            if (items1[i] == items2[j])
            {
                Console.WriteLine("true");
                break;
            }
            else if (items1[i] != items2[j] && (i == (items1.Count-1) && j == (items2.Count-1)))
            {
                Console.WriteLine("false");
            }
        }
    }    
}
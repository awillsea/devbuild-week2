//Lets do a dictionary like this 
//  1 "0ne"
//  2 "two"
//  3 "three"
// key is int
//value is string

Dictionary<int, string> numToWord = new Dictionary<int,String>();

numToWord[1] = "One";
numToWord[10] = "Ten";
numToWord[20] = "Twenty";
numToWord[100] = "One Hundred";

// Print out all the Keys

Console.WriteLine("here are the keys: ");
foreach(int key in numToWord.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine();
Console.WriteLine("here are the values: ");
foreach(String value in numToWord.Values)
{
    Console.WriteLine(value);
}

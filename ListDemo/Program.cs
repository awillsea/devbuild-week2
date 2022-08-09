//Lets make an array comparison
string[] myArray = { "abc", "def", "ghi" };

//Lets print out one element
Console.WriteLine(myArray[0]);

//lets change one of the elements
myArray[1] = "jkl";

//lets loop through it
for(int ind = 0; ind < myArray.Length; ind++)
{
    Console.WriteLine(myArray[ind]);
}


Console.WriteLine();

//
// Now lets use a list
//

List<string> myList = new List<string>();
myList.Add("Abc");
myList.Add("Def");
myList.Add("Ghi");

// Let's Print out one element
Console.WriteLine(myList[0]);

// Lets Change one of the elements 
myList[1] = "jkl";

//Lets add an other one
myList.Add("Mno");

for(int ind = 0; ind < myList.Count; ind++)
{
    Console.WriteLine(myList[ind]);
}

// Delete one from the list
//Insert one into the list
//Look at the official documentation

Console.WriteLine("Lets remove the one at index 2");
myList.RemoveAt(2);
for (int ind = 0; ind < myList.Count; ind++)
{
    Console.WriteLine(myList[ind]);
}

Console.WriteLine("Lets remove one by name: Abc");
myList.Remove("Abc");
for (int ind = 0; ind < myList.Count; ind++)
{
    Console.WriteLine(myList[ind]);
}

Console.WriteLine("Now let's insert one in between the first two.");
myList.Insert(1, "Pqr");
foreach (string word in myList)
{
    // we cant see the index
    Console.WriteLine(word);    
}

Console.WriteLine("Lets sort the list");
myList.Sort();
foreach(string nextLetter in myList)
{
    Console.WriteLine(nextLetter);
}


// lets check if one exsist
Console.WriteLine("Type in a word and we'll see if its in the list");
string entry = Console.ReadLine();
int index = myList.IndexOf(entry);
if(index >= 0)
{
    Console.WriteLine($"Found {entry} at {index}");
}
else
{
    Console.WriteLine($"Sorry, {entry} is not in the list.");
}

Console.WriteLine("lets initialize a list of integers");
List<int> numbers = new List<int>() { 5, 3, 8, 2 };
foreach(int nextnum in numbers)
{
    Console.WriteLine($"the next number is {nextnum}");
}
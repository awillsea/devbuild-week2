//Lets start with a list for comparison

List<string> letters = new List<string>();
letters.Add("Abc");
letters.Add("Def");
letters.Add("Ghi");
letters.Add("Jkl");
letters.Add("Mno");

Console.WriteLine("Here are the letters");
foreach(string next in letters)
{
    Console.WriteLine(next);
}

Dictionary<string, string> foods = new Dictionary<string, string>();
foods["Paul"] = "spaghetti";
foods["Sarah"] = "Pizza";
foods["Quincy"] = "Tacos";
foods["Ruby"] = "Ice Cream";
foods["Terry"] = "Tacos";

//Let's Print out Rubys favorite food
Console.WriteLine(foods["Ruby"]);

//Paul changed his mind. He likes Hamburgers.
foods["Paul"] = "Hamburgers";
Console.WriteLine($"Paul now likes {foods["Paul"]}");

// DO NOT assume a fixed order! if you need ordering, use a list;

foreach (var pair in foods)
{
    Console.WriteLine("The name and the food are: ");
    Console.WriteLine(pair.Key);
    Console.WriteLine(pair.Value);
}
string entry = Console.ReadLine();
if (foods.ContainsKey(entry))
{
    Console.WriteLine($"Yes, we have a favorite food for {entry}");
    Console.WriteLine(foods[entry]);
}
else
{
    Console.WriteLine("We don't know that person.");
}

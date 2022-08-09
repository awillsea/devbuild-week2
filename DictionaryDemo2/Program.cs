//More fun with dictionaries

//A list of salaries. The key will be a persons name (string)
//And the value will be the persons salary (decimal)

Dictionary<String, Decimal> salaries = new Dictionary<string, decimal>();
salaries["Paul"] = 65000m;
salaries["Sarah"] = 100000;
salaries["Quincy"] = 80000m;
salaries["Ruby"] = 65000m;
salaries["Terry"] = 60000m;
salaries["Fidan"] = 250000m;

//foreach(var pair in salaries)
//{
//    Console.WriteLine(pair.Key);
//}


foreach(String key in salaries.Keys)
{
    Console.WriteLine(key);
}
//foreach(Decimal money in salaries.Values)
//{
//    Console.WriteLine(money);
//}

Console.WriteLine("Please enter a name: ");
String name = Console.ReadLine();

if (salaries.ContainsKey(name))
{
    Console.WriteLine(salaries[name]);
}
else
{
    Console.WriteLine("that person doesn't work here");
}


Console.Write("Please add a new employee. Enter their name");
string name2 = Console.ReadLine();
Console.Write("Please Enter a salary: ");
string entry = Console.ReadLine();
decimal salary = decimal.Parse(entry);

salaries[name2] = salary;
salaries.Add(name2, salary);

Console.WriteLine("Here is everybody");
foreach(var pair in salaries)
{
    Console.WriteLine($"{pair.Key} makes {pair.Value}");
}

Dictionary<string, List<int>> Favorites = new Dictionary<string, List<int>>();

Favorites["Paul"] = new List<int>() { 10, 100, 1000, 10000 };
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Please enter an integer");
    string entry = Console.ReadLine();
    int num;
    bool result = int.TryParse(entry, out num);
   if (result)
    {
        Console.WriteLine($"Great! Your number is {num}");
    }
    else
    {
        Console.WriteLine($"sorry, {entry} is not a int");
    }
}

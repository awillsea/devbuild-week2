Dictionary<String, Decimal> menu = new Dictionary<String, Decimal>();
List<String> shoppingCart = new List<String>();
Decimal shoppingSum = 0;
bool validName = false;
menu["Apple"] = 0.99m;
menu["Banana"] = 0.59m;
menu["Cauliflower"] = 1.59m;
menu["Dragonfruit"] = 2.50m;
menu["Olive oil"] = 3.00m;
menu["Chicken"] = 5.45m;
menu["Watermelon"] = 3.13m;
menu["Grapes"] = 1.89m;
menu["Soda"] = 0.50m;
menu["Eggs"] = 2.25m;
Console.WriteLine("Welcome to AJ's Fine Foods market");
Console.WriteLine("Item                       Price");
Console.WriteLine("================================");
foreach (var pair in menu)
{
    Console.WriteLine($"{pair.Key}, = \t \t = {pair.Value}");
 
}
Console.WriteLine("=================================");
Console.WriteLine($"The most expensive menu item is Chicken at ${menu["Chicken"]} and the least expensive menu is Soda at ${menu["Soda"]}");
//Console.WriteLine(); figure out how to get a ordered range

do
{
   
        
    while (!validName)
    {
        Console.Write("What Item would you like to order?: ");
        String name = Console.ReadLine();

        if (menu.ContainsKey(name))
        {
            shoppingCart.Add(name);
            Console.WriteLine($"{name} has been added to your cart at {menu[name]}");
            validName = true;


        }
        else
        {
            Console.WriteLine("Sorry, we don't have those. Please try again.");
        }
    }
    Console.WriteLine();
    validName = false;
}while(KeepGoing());

Console.Write("You ordered the following items: ");
//Console.WriteLine(String.Join(",", shoppingCart));


//var ordered = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

List<String> priceRange = shoppingCart.OrderBy(value => menu[value]).ToList();
foreach(var price in priceRange)
{
    Console.WriteLine($"{price},{menu[price]}");
}

foreach (var name in shoppingCart)
{
    shoppingSum = menu[name] + shoppingSum;
}
Console.WriteLine($"${shoppingSum}");
static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to order anything else? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}
// foreach(string item in cart){
// the first iteration item will be "Apple"
//Console.WriteLine(menu[item]); // thats the price
//}

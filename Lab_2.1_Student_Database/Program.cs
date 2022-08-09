string[] names = { "Maria", "James", "Talia", "Cooper", "Kay", "Scott" };
string[] favFood = { "Chicken Parmesan", "BLT Sandwich", "Burritos", "Caesar Salad", "Orange Chicken", "Rib eye Steak" };
string[] hometown = { "Seattle, Washington", "Riverside, California", "Huston, Texas", "Chandler Arizona", "SanFransico, California", "Detroit, Michigan" };
do
{

    int userNumber = 0;
    bool escapeLoop = false;
    bool escapeLoop2 = false;
    bool leaveFirstLoop = false;
    bool yesList = false;
    bool searchForStudent = false;
    Console.WriteLine("Welcome! Would you like to see a list of all the students? Y/N :");

    while (!leaveFirstLoop)
    {

        string seeList = Console.ReadLine().ToLower();
        if (seeList == "y" || seeList == "yes")
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                searchForStudent = true;
                escapeLoop = true;
                leaveFirstLoop = true;
            }
        }
        else if (seeList == "no" || seeList == "n")
        {
            searchForStudent = false;
            leaveFirstLoop = true;
        }
        else
        {
            Console.Write("Please Make sure to hit 'Yes' for a list of names or 'No' to continue with out:");
        }
    }
    while (searchForStudent)
    {
        Console.WriteLine("Type in the name you would like to know more about: ");
        string studentNameSearch = Console.ReadLine().ToLower();
        switch (studentNameSearch)
        {
            case "maria":
                userNumber = 0;
                searchForStudent = false;
                yesList = true;
                escapeLoop = true;
                break;
            case "james":
                userNumber = 1;
                searchForStudent = false;
                yesList = true;
                escapeLoop = true;
                break;
            case "talia":
                userNumber = 2;
                searchForStudent = false;
                yesList = true;
                escapeLoop = true;
                break;
            case "cooper":
                userNumber = 3;
                searchForStudent = false;
                yesList = true;
                escapeLoop = true;
                break;
            case "kay":
                userNumber = 4;
                searchForStudent = false;
                yesList = true;
                escapeLoop = true;
                break;
            case "scott":
                userNumber = 5;
                searchForStudent = false;
                yesList = true;
                escapeLoop = true;
                break;
            default:
                Console.Write("Name is not one of the students.");
                break;
        }
    }
    while (escapeLoop == false)
    {
        Console.WriteLine("Please enter a number between 1-6");
        String userInput = Console.ReadLine();
        bool correctEntry = int.TryParse(userInput, out userNumber);
        if (!correctEntry)
        {
            Console.WriteLine("Sorry Input was incorrect. Please press a Number between 1 and 6");


        }
        else if (userNumber >= 1 && userNumber <= 6)
        {
            userNumber--;
            escapeLoop = true;
        }
        else
        {
            Console.WriteLine("Ooops looks like that number is out of the specified range. Please try again with a number between 1 and 6: ");
        }

    }
    if (yesList == true)
    {
        Console.WriteLine($"You have chosen {names[userNumber]}. What would you like to know? Enter 'hometown' or 'favorite food': ");
        while (escapeLoop2 == false)
        {
            string knowMore = Console.ReadLine().ToLower();
            if (knowMore == "hometown" || knowMore == "home" || knowMore == "town")
            {
                Console.WriteLine($"{names[userNumber]} is from {hometown[userNumber]} ");
                escapeLoop2 = true;
                //option1 = false;
            }
            else if (knowMore == "favorite food" || knowMore == "favorite" || knowMore == "food" || knowMore == "fav")
            {
                Console.WriteLine($"{names[userNumber]} favorite food is {favFood[userNumber]}");
                escapeLoop2 = true;
                //option1 = false;

            }
            else
            {
                Console.WriteLine("That category does not exist. Please try again.  What would you like to know? Enter 'hometown' or 'favorite food':  ");
            }
        }
    }
    else
        while (escapeLoop2 == false)
        {
            Console.WriteLine($"Student Number{userNumber + 1} is {names[userNumber]}. What would you like to know? Enter 'hometown' or 'favorite food': ");
            string knowMore = Console.ReadLine().ToLower();
            if (knowMore == "hometown" || knowMore == "home" || knowMore == "town")
            {
                Console.WriteLine($"{names[userNumber]} is from {hometown[userNumber]} ");
                escapeLoop2 = true;
                //option1 = false;
            }
            else if (knowMore == "favorite food" || knowMore == "favorite" || knowMore == "food" || knowMore == "fav")
            {
                Console.WriteLine($"{names[userNumber]} favorite food is {favFood[userNumber]}");
                escapeLoop2 = true;
                //option1 = false;

            }
            else
            {
                Console.WriteLine("That category does not exist. Please try again.  What would you like to know? Enter 'hometown' or 'favorite food':  ");
            }
        }


} while (KeepGoing());

Console.WriteLine("Thanks for playing!");

static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
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
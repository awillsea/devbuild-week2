string[] names = { "Abdul Amin", "Barbara Baker", "Cherine Cooper", "Douglas Dickerson", "Emily Emerson" };
int[] grades = { 95, 98, 85, 80, 70 };

// Print out all the grades;

//for(int index = 0; index <=4; index++)
//{
//    Console.WriteLine($"{names[index]} has {grades[index]}");
//}

//// Print out all the grades but slightly different for loop
//// Ask the first array how long it it. it will tell us it has 5 members (or elements)
////but the bounds are 0 to 4
//// THe upper bound4, is one less than the size of the array 
//Console.WriteLine();
//Console.WriteLine($"There are {names.Length} students");
//for (int index = 0; index < names.Length; index++)
//{
//    Console.WriteLine($"{names[index]} has grades {grades[index]}");
//}

// Ask the user which one to print out

//Console.WriteLine();
//Console.WriteLine("Please enter a number from 0 to 4.");
//string entry = Console.ReadLine();
//int num = int.Parse(entry);
//Console.WriteLine($"{names[num]} has grade {grades[num]}");

// Ask the User which one to print out, buyt start with 1.
// SO if they type 1 we want to give them back index 0. so we need to subtract 1.

// Version 1

//Console.WriteLine();
//Console.WriteLine("Please enter a number from 1 to 5.");
//string entry = Console.ReadLine();

//int num = int.Parse(entry);
//num--;
//Console.WriteLine($"{names[num]} has grade {grades[num]}");


//version 2

bool okay = false;
int num = 0;
while (okay == false)// While this is a true Statement run. while can only run with a true statement 
{
    Console.WriteLine();
    Console.WriteLine("Please enter a number from 1 to 5.");
    string entry = Console.ReadLine();
    bool validNum = int.TryParse(entry, out num);

    if (validNum)
    {
        if (num >= 1 && num <= 5)
        {
            num--;
            okay = true;
        }
    }
}

 
    // This next code will run after they have entered a valid number.
Console.WriteLine($"{names[num]} has grade {grades[num]}");

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
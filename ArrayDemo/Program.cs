// An array is a variable that canld a list of things

int[] grades = {100, 80, 100 , 60, 85};

Console.WriteLine(grades[0]);// Expect 100
Console.WriteLine(grades[1]);// Expect 80
Console.WriteLine(grades[4]);// Expect 85

string[] names = { "Fred", "Jamal", "Yasmine", "Ziggy" };
Console.WriteLine(names[0]);// Expect Fred
Console.WriteLine(names[2]);// expect Yasmine 

Console.WriteLine();
int index = 3;

Console.WriteLine();
for (int ind = 0; ind <  4; ind++)
{
    Console.WriteLine(names[ind]);
   
}
for (int ind = 0; ind <= 3; ind++)// this clearly shows the start and end point, Jeff prefers using the <= or >= rather than the < or >
{
    Console.WriteLine(names[ind]);

}
// Let's Change one. Suppose we misspelled the third name. SHould be Jasmine.
// we are acutlaly changing the entire string, replacing it. Stings are immutable. We cant change an individual letter.
names[2] = "Jasmine";
Console.WriteLine();
Console.WriteLine($"We corrected the spelling of {names[2]}");
grades[0] = 99;
Console.WriteLine($"The first grade is now {grades[0]}");

int x = 0;

//while ( 10 > 9)
//{
//    Console.WriteLine($"wHILE LOOP. X IS {x}");
//    x++;
//}

bool done = false;
while (!done)
{

    Console.WriteLine($"while loop. x is {x}");
    x++;
    if (x == 1000)
    {
        done = true;
    }
}
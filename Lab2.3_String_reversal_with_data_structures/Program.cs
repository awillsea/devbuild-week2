Console.Write("Please enter a word you would like to reverse: ");
string userInput = Console.ReadLine();
Stack<char> reverseWord = new Stack<char>();
string[] brokenDown = userInput.Split();
foreach (char letter in userInput)
{
    // Console.WriteLine(letter);
    reverseWord.Push(letter);
}
Console.Write("Your Word in reverse is: ");
foreach (char letter in reverseWord)
{
    Console.Write(letter);
}



//
//======================================== the code below is for the challenge. i am still working on it, hence why it is commented out=================
//

//Console.WriteLine("please enter a sentence: ");
//Queue<string> brokenDown = new Queue<string>();
//Stack<char> reverseWord2 = new Stack<char>();
//string is_A_String = Console.ReadLine();
//bool it_Is_A_Sentence = is_A_String.Contains(' ');
//List<string> postions = new List<string>();


//if (it_Is_A_Sentence)
//{

//    string[] words = is_A_String.Split(' ');

//    //foreach (string word in words)
//    //{
//    //    //Console.WriteLine(word);
//    //    brokenDown.Enqueue(word);

//    //}
    
       // foreach (string word in words)
       //{

       // char[] delims = { ' ', ',' };
       // //char[] delims = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
       // word.Split(delims);
       // Console.WriteLine(word);// with its me in CR it will spit back its next line Me
       // if (!word.Contains(' '))
        
       // {
       //     foreach (char j in word)
       //     {
       //         reverseWord2.Push(j);
       //        // Console.WriteLine($"{reverseWord2}");
                
       //     }
       //     foreach (char letter in reverseWord2)
       //     {
       //         Console.Write(letter);
       //     }
       // }
       //}
    
    //foreach (string word in brokenDown)
    //{

    //    foreach (char letter in word)
    //    {
    //        reverseWord2.Push(letter);
    //    }
    //    Console.WriteLine(word);
    //}
}

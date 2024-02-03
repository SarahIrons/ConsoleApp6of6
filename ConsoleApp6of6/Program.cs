using System;
using System.Linq;

namespace ConsoleApp6of6
{
    class Program
    {
        static void Main(string[] args)
        {
//            Create a list of strings that has at least two identical strings in the list.

//Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            string[] cast = { "Jody", "Carlo", "Sarah", "Jody", "Pat" };
            int indexCounter = 0; //This is a variable to count the index of each time looped over an item in the list.
            var arrayChecker = Enumerable.Repeat(string.Empty, cast.Length).ToArray(); //This is a way to set up an array of empty strings that is the same length as the cast array. 
            // This use a Linq method to dynamically make the arrayChecker = { "", "", "", "", "" } or whatever length the cast  array
            foreach (var member in cast)//this is the start of the foreach loop
            {
                string indexAndMember = indexCounter + " " + member + " this item is "; //this is the name of the new string called 'index and member.' This is the same starting concatenated phrase that each looped item will generate.
             
                if (arrayChecker.Contains(member))//this means that if the new array contains the member then it is a duplicate.
                {
                    Console.WriteLine(indexAndMember + "duplicate");
                }else
                {
                    Console.WriteLine(indexAndMember + "unique");//this means that the member's name was not in the array yet so it is unique.
                }
                //the variables are updated below, at the end the conditional loops(for-each and if/else).  
                arrayChecker[indexCounter] = member;//this will update the array checker at the current index with the current cast member.
                indexCounter++;//this tracks the loop and reports the index position.

            }
        }
    }
}

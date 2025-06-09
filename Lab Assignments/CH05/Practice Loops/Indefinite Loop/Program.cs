//Declare as iterator variable - PART 1

//Test for iterator variable for boolean condition - PART 2

//If the test is TRUE, the loop will iterate
//If the test is FALSE, the loop will not iterate

//MODIFY the iterator variable - PART 3

//999 is a special value that is called a sentinal value
using System.ComponentModel.Design;

Console.WriteLine("Please enter a test score (0-100) to sum or 999 to stop:");
int userInput = Convert.ToInt32(Console.ReadLine());

//When a value gets bigger every time through a loop, is its called an accumulator
//Accumlators should be init with the value of 0
int sum= 0;

while (userInput != 999)
{
    if (userInput >= 0 && userInput <= 100)
    {
        //valid score

        sum = sum + userInput;

    }
    else
    {
        //Invalid Score
        Console.WriteLine("Valid scores are between 0 and 100");
    }
    
    //Modification of the iterator variable
    Console.WriteLine("Please enter a test score (0-100) to sum or 999 to stop:");
    userInput = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"The sum of the numbers: {sum}");
Console.WriteLine("Thanks for using my program ");

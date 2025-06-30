//Declare as iterator variable - PART 1

//Test for iterator variable for boolean condition - PART 2

//If the test is TRUE, the loop will iterate
//If the test is FALSE, the loop will not iterate

//MODIFY the iterator variable - PART 3

//999 is a special value that is called a sentinel value

Console.WriteLine("Please enter a test score or 999 to stop:");
int userInput = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int average = sum / ;

while (userInput != 999)
{
    if (userInput >= 0 && userInput <= 100)
    {
        //Valid Score
        sum = sum + userInput;
        average = sum / userInput;

    }
    else
    {
        //Invalid Score
        Console.WriteLine("Invalid score. Please enter test score (0-100)");

    }

    Console.WriteLine("Please enter a test score or 999 to stop:");
    userInput = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"Number of scores:");
Console.WriteLine($"Sum of scores is : {sum}");
Console.WriteLine($"Average test scores: {average}");
Console.WriteLine($"Lowest test score:");
Console.WriteLine($"Highest test score:");


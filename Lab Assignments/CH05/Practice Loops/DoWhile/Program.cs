//Declare as iterator variable - PART 1

//Test for iterator variable for boolean condition - PART 2

//If the test is TRUE, the loop will iterate
//If the test is FALSE, the loop will not iterate

//MODIFY the iterator variable - PART 3

int i = 0;

//A do-while loop is different from a while loop in that it is a POST test loop
//Meaning it will iterate 1 to many times.

do
{
    Console.WriteLine($"The value of i is {i}");
    Console.WriteLine($"The value of i minus 100 is {i-100}");
    Console.WriteLine($"The value of i times 2 is {i * 2}");
    i++;

} while (i < 5);
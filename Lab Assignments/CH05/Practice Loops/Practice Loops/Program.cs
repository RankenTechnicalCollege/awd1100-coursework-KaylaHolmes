//Declare as iterator variable - PART 1

//Test for iterator variable for boolean condition - PART 2

//If the test is TRUE, the loop will iterate
//If the test is FALSE, the loop will not iterate

//MODIFY the iterator variable - PART 3

int i = 0; //Conventionally, out iterator variable starts at the value of 0;

Console.WriteLine("The loop is about to begin");

while (i < 10) //known as a PRE Test loop - meaning the conditional test happens BEFORE the body of the loop
    //PRE TEST loops will iterate 0 to many times.
{
    Console.WriteLine($"The value of i is {i}");
    i++; //If you forget to modify the iterator variable, you'll wind up with an infinite loop
    //Indefinite loop - goes on for an unknown amount of time
}
Console.WriteLine("The loop is finished");
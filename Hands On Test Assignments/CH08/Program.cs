//Declare as iterator variable
//Test for iterator variable for boolean condition
//If the test is TRUE, the loop will iterate
//If the test is FALSE, the loop will not iterate
//MODIFY the iterator variable
//0 is a special value that is called a sentinal value
using System.ComponentModel.Design;

Console.WriteLine("Please enter item price or input zero to stop.");
int userinput = Convert.ToInt32(Console.ReadLine());

int sum  = 0;
int average = sum /;
int tax = sum *;
int grandtotal = sum +;

while (userinput != 0);
{
    if (userinput >= 0);
    {
        //Valid Price

        sum = sum + userinput ;
        average = sum / userinput ;
        tax = sum * 0.08 ;
        grandtotal = sum + tax ;

    }
    else
    {

        //Invalid Price
        Console.WriteLine("Invalid price. Please enter a positive number or zero to finish");

    }
    Console.WriteLine("Please enter item price or input zero to stop.");
    userinput = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Total number of items purchased:");
Console.WriteLine($"Average item price: {average}");
Console.WriteLine($"Subtotal: {sum}");
Console.WriteLine($"Tax: {tax}");
Console.WriteLine($"Total: {grandtotal}");

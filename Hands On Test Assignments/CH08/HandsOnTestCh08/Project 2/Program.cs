//Declare as iterator variable
////Test for iterator variable for boolean condition
//If the test is TRUE, the loop will iterate
//If the test is FALSE, the loop will not iterate
//MODIFY the iterator variable

//0 is a special value that is called a sentinel value

Console.WriteLine("Please enter a positive price or zero to finish.");
int userinput = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int average = sum / userinput;
int totaltax = (int)(sum * 0.08);
int grandtotal = sum + userinput;

while (userinput != 0)
{
    if (userinput >= 0)
    {

        //Valid Price
        sum = sum + userinput;
        average = sum / userinput;
        totaltax = (int)(sum * 0.08);
        grandtotal = totaltax + sum;

    }
    else
    {
        //Invalid Price
        Console.WriteLine("Invalid price. Please enter a positive number or zero to finish");

    }
    
    Console.WriteLine("Please enter a positive price or zero to finish.");
    userinput = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Items Purchased: {userinput}");
Console.WriteLine($"Average Item Price: {average}");
Console.WriteLine($"Subtotal: {sum}");
Console.WriteLine($"Tax: {totaltax}");
Console.WriteLine($"Total: {grandtotal}");
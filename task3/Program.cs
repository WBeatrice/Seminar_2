int number = 0;
Console.Write("Enter a number from 1 to 7: ");
if (int.TryParse(Console.ReadLine(), out number))
{
    if (number <= 7)
    {
        if (number == 1)
        {
            Console.WriteLine("No");
        }
        if (number == 2)
        {
            Console.WriteLine("No");
        }
        if (number == 3)
        {
            Console.WriteLine("No");
        }
        if (number == 4)
        {
            Console.WriteLine("No");
        }
        if (number == 5)
        {
            Console.WriteLine("No");
        }
        if (number == 6)
        {
            Console.WriteLine("Yes");
        }
        if (number == 7)
        {
            Console.WriteLine("Yes");
        }
    }
    else
    {
        Console.WriteLine("This is the no number in the week");
    }
}
else
{
    Console.WriteLine("Oops");
}
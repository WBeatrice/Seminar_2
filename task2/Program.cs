int number = 0;
int a = 0;

Console.Write("Enter the number: ");
if (int.TryParse(Console.ReadLine(), out number))
{
    if (number >= 100)
    {
        if (number < 1000)
        {
            number %= 10;
            Console.WriteLine($"The third digit of the number: {number}");
        }
        else
        {
            Console.WriteLine("I can't count");
        }
    }
    else
    {
        Console.WriteLine("There is no third number");
    }
}
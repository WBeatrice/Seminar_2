int number = 0;
int a = 0;
int b = 0;

Console.Write("Enter a three-digit number: ");

if (int.TryParse(Console.ReadLine(), out number))
{
    if (number >= 100)
    {
        if (number % 10 != 0)
        {
            a = number / 10;

            if (a % 10 != 0)
            {
                b = a % 10;
                Console.WriteLine($"The second digit of the number: {b}");
            }
            else
            {
                Console.WriteLine("The second digit of the number: 0");
            }
        }

    }
    else
    {
        Console.WriteLine("Wrong number!");
    }

}
else
{
    Console.WriteLine("Oops");
}
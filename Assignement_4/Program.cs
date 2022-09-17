Console.Clear();
Console.WriteLine("Enter the first number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number");
int number3 = int.Parse(Console.ReadLine());

int maxNumber = number1;

if (number2 > maxNumber)
    {
        maxNumber = number2;
    } 
if (number3 > maxNumber)
    {
        maxNumber = number3;
    }

Console.WriteLine($"Max number is {maxNumber}");


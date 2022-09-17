Console.Clear();
Console.WriteLine("Enter the first number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
    {
        Console.WriteLine($"max={number1} min={number2}");
    } 
else 
    {
        Console.WriteLine($"max={number2} min={number1}");
    }

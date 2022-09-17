Console.Clear();
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
int counter = 2;
while (counter <= number)
    {
    Console.Write($"{counter} ");
    counter = counter + 2;
    } 
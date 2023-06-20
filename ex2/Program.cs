Console.Clear();

Console.WriteLine("Enter your number: ");
int num = int.Parse(Console.ReadLine());
int result = Math.Abs(sum(num));
Console.WriteLine($"Result = {result}");

int sum (int number)
{
    int i = 0;
    while (number != 0)
    {
        i += number % 10;
        number /= 10;
    }
    return i;

}
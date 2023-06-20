Console.Clear();

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());

int c = result(a,b);
Console.WriteLine(c);

int result (int firstNumber, int secondNumber)
{
    int i = 1;
    int j = 1;
    while (i <= secondNumber)
    {
        j *= firstNumber;
        i++;
    }
    return j;
}

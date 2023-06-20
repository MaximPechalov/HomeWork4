Console.Clear();

int size = 8;
int [] array = new int[size];
arrayNums(array);
arrayPrint(array);

void arrayNums(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100);
    }
}

void arrayPrint(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
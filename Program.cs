//Задача 25
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Method(A,B));

int Method (int x, int y)
{
    int result = x;
    for(int i = 1; i<y; i++)
    {
     result = result * x;
    }
    return result;
}

//Задача 27

/*Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {N} равна {Sum(N)}");
int Sum(int number)
{
    int result = 0;
    int temp = 0;
    while(number > 0)
    {
        temp = number % 10;
        result = result + temp;
        number = number/10;
    }
    return result;
}*/


//Задача 29
/*int[] array = new int[8];
GetBinaryArray(array.Length);
Console.Write($"[{String.Join(",", Arr)}]");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i<size; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}*/

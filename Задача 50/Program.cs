// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 , 7 -> такого числа в массиве нет
// 1 , 1 -> 1

Console.Clear();
int m = 4;
int n = 5;
int[,] array = CreateRandom2DArray(m, n);
Console.WriteLine("Исходный массив : ");
Print2DArray(array);
Console.Write("Введите номер столбца: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > m && b > n)
{
    Console.Write("Такого числа нет");
}
else Console.Write(array.GetValue(a, b));

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


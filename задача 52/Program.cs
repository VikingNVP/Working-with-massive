// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
// Поиск среднее арифметического в отдельном методе. Для создания массива и вывода можно воспользоваться методами из 47 задачи.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите кол-во строк M: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите кол-ко столбцов N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! Неправильный ввод данных.");
    return;
}
int[,] array = FillArray2D(m, n);
PrintArray2D(array);
Console.WriteLine();
FindArithmeticMeanColumns(array);

int[,] FillArray2D(int m, int n)
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

void PrintArray2D(int[,] array)
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

void FindArithmeticMeanColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        float sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        Console.Write($"{sum / array.GetLength(0)} ");
    }
}
Console.WriteLine();

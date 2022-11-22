//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// Сделать отдельный метод который генерирует двумерный массив и отдельный метод который выводит его на экран.
// m и n вводит пользователь в консоль

Console.Clear();
Console.Write("Введите кол-во столбцов M: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите кол-ко строк N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! Неправильный ввод данных.");
    return;
}
double[,] array = FillArray2D(m, n);
PrintArray2D(array);

double[,] FillArray2D(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = random.NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", array[i,j]); // Преобразовал значение на выходе без лишних цифр после нуля
        }
        Console.WriteLine();
    }
}

// Задайте двумерный массив из целых чисел. Выведите суммы элементов каждого столбца в заданную с консоли степень.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] FillMatrix(int rowsCount, int columsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите n и m через Enter ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);

Console.Write("Введите степень числа ");
int x = Convert.ToInt32(Console.ReadLine());
double[] means = new double[n];
for (int j = 0; j < matrix.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i, j];
    }
    means[j] = Math.Pow(sum,x);
}
Console.WriteLine($"Суммы элементов столбцов в степени {x} ");
Console.WriteLine(string.Join(", ", means));

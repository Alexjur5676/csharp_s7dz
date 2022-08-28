// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждой строке.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждой строки: 3,5; 4,75; 4,5

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

double[] means = new double[m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        sum = sum + matrix[i, j];
    }
    means[i] =Math.Round( sum / n,3);
}
Console.WriteLine("Средние арифметические элементов строк ");
Console.WriteLine(string.Join(", ", means));

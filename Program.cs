// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
MinSum(array); // переменная мин суммы

void FillArray(int[,] matrix) // заполняем 
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix) // выводим
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSum(int[,] matrix) // поиск минимальной
{
    int count = 0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            count=i;
        }
    }
    Console.WriteLine("Cтрока № " + (count+1) + " где наименьшая сумма: " + (minsum));
}

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

Console.WriteLine("Заданный массив: ");
FillArray(array);
PrintArray(array);
Console.WriteLine("Отсортированный массив: ");
SortDescendingArray(array);
PrintArray(array);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortDescendingArray(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1; k++)
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
        }
    }
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите число строк для матрицы А: ");
int rowsA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов для матрицы А (оно же число строк для матрицы В): ");
int columnsArowsB = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[rowsA, columnsArowsB];

Console.Write("Введите число столбцов для матрицы В: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
int[,] matrixB = new int[columnsArowsB, columnsB];

Console.WriteLine("Матрица А: ");
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine("Матрица В: ");
FillArray(matrixB);
PrintArray(matrixB);

Console.WriteLine("Произведение матриц А и В: ");
int[,] matrixC = new int[rowsA, columnsB]; // строки матрицы А и столбцы матрицы В
GetMatrixProduct(matrixA, matrixB, matrixC);
PrintArray(matrixC);


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 4); // мало чисел легче проверить
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// произведение новой матрицы = умножаем строки А со столбцами В и суммируем (см формулу)

void GetMatrixProduct(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
    for (int i = 0; i < rowsA; i++)
    {

        for (int j = 0; j < columnsB; j++)
        {
            int numberC = 0;
            for (int k = 0; k < columnsArowsB; k++)
            {
                numberC += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = numberC;
        }
    }
}
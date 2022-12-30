// Задача 4*. Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// 1. Создать метод, который принимает двумерный массив и заполняет его по спирали, от 1 до row*column.
// 2. Создать метод, который выводит двумерный массив на консоль.
// 2. Пригласить пользователя ввести количество строк и количество столбцев.
// 3. Применить метод в пункте 2, аргументом которому будет результат работы метода в пункте 1.

// 1.
void FillMatrix(int[,] matr, int row, int column)
{
    int iStart = 0, iFin = 0, jStart = 0, jFin = 0;

    int k = 1, i = 0, j = 0;

    while (k <= row * column)
    {
        matr[i, j] = k;
        if (i == iStart && j < column - jFin - 1)
            ++j;
        else if (j == column - jFin - 1 && i < row - iFin - 1)
            ++i;
        else if (i == row - iFin - 1 && j > jStart)
            --j;
        else
            --i;

        if ((i == iStart + 1) && (j == jStart) && (jStart != column - jFin - 1))
        {
            ++iStart;
            ++iFin;
            ++jStart;
            ++jFin;
        }
        ++k;
    }
}

// 2.
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j].ToString().PadLeft(3, ' '));
        }
        Console.WriteLine();
    }
}

// 3.
Console.WriteLine("Введите количество строк двумерного массива ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцев двумерного массива ");
int column = int.Parse(Console.ReadLine());

int[,] matrix = new int[row, column];

// 4.
FillMatrix(matrix, row, column);
PrintMatrix(matrix);
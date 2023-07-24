using System;

public static class ArrayExample
{
    public static void Main()
    {
        int[,] array = {
            { 13, 24, 33, 45 },
            { 53, 62, 71, 80 },
            { 97, 10, 11, 12 }
        };

        Console.WriteLine("Заданный массив:");
        PrintArray(array);

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        double[] columnAverages = new double[columns];

        for (int j = 0; j < columns; j++)
        {
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = sum / rows;
        }

        Console.WriteLine("Среднее арифметическое каждого столбца:");
        PrintColumnAverages(columnAverages);
    }

    public static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void PrintColumnAverages(double[] columnAverages)
    {
        foreach (double average in columnAverages)
        {
            Console.Write(average.ToString("0.0") + "; ");
        }
        Console.WriteLine();
    }
}


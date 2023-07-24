
        int[,] array = {
            { 10, 20, 30 },
            { 40, 50, 60 },
            { 70, 80, 90 }
        };

        Console.WriteLine("Заданный массив:");
        PrintArray(array);

        while (true)
        {
            Console.WriteLine("Введите номер строки или введите 'exit' для завершения:");
            string inputRow = Console.ReadLine();

            if (inputRow.ToLower() == "exit")
                break;

            string[] rowValues = inputRow.Split(' ');
            if (rowValues.Length != 1 || !int.TryParse(rowValues[0], out int row) || row < 1 || row > array.GetLength(0))
            {
                Console.WriteLine("Некорректный ввод строки.");
                continue;
            }

            Console.WriteLine("Введите номер столбца:");
            string inputColumn = Console.ReadLine();

            string[] columnValues = inputColumn.Split(' ');
            if (columnValues.Length != 1 || !int.TryParse(columnValues[0], out int column) || column < 1 || column > array.GetLength(1))
            {
                Console.WriteLine("Некорректный ввод столбца.");
                continue;
            }

            int element = array[row - 1, column - 1];
            Console.WriteLine($"Значение элемента ({row}, {column}): {element}");
        }
    

   static void PrintArray(int[,] array)
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




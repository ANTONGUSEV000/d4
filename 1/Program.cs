Console.WriteLine("Введите количество строк m:");
        int m;
        while (!int.TryParse(Console.ReadLine(), out m))
        {
            Console.WriteLine("Некорректный ввод. Повторите ввод m:");
        }

        Console.WriteLine("Введите количество столбцов n:");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Некорректный ввод. Повторите ввод n:");
        }

        double[,] array = new double[m, n];
        Random random = new Random();

        // Заполняем массив случайными вещественными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble() * 100; // Здесь 100 - максимальное значение случайного числа.
            }
        }

        // Выводим массив на экран с явным указанием точки в качестве десятичного разделителя
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < m; i++)
        
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString("0.00") + " ");
            }
            Console.WriteLine();
Console.WriteLine("1. Угадай число");
Console.WriteLine("2. Таблица умножения");
Console.WriteLine("3. Вывод делителей числа");
Console.WriteLine("4. Закрыть программу");
int Num = Convert.ToInt32(Console.ReadLine());
{
    while (Num < 4)
    {

        switch (Num)
        {
            case 1:
                Console.WriteLine("\n1. легкий (0 - 10)\n2. нормальный (0 - 50)\n3. сложный (0 - 100)\n");
                Console.WriteLine("выбор режима, введите число ");
                int arr = 0;
                Random rand = new Random();
                while (true)
                {
                    Double vit = Convert.ToDouble(Console.ReadLine());
                    if (vit == 1)
                    {
                        arr = rand.Next(0, 10);
                        break;
                    }
                    else if (vit == 2)
                    {
                        arr = rand.Next(0, 50);
                        break;
                    }
                    else if (vit == 3)
                    {
                        arr = rand.Next(0, 100);
                        break;
                    }
                    
                }
                Console.WriteLine("можешь угадать число, каторый я загадал ?");
                while (true)
                {
                    Double input = Convert.ToDouble(Console.ReadLine());
                    if (arr > input)
                        Console.WriteLine("возьми еще больше.");
                    else if (arr < input)
                        Console.WriteLine("возьми еще меньше.");
                    else
                        Console.WriteLine("поздравляю ты угадал! ");
                }
                break;

            case 2:
                int[,] tiv = new int[10, 10];
                int[] mpt = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                for (int i = 0; i < mpt.Length; ++i)
                {
                    Console.Write(mpt[i] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 1; i < tiv.GetLength(0); ++i)
                {
                    for (int j = 1; j < tiv.GetLength(1); ++j)
                    {
                        int and = i * j;
                        if (i == j)
                        {
                            tiv[i, j] = and;
                            Console.Write(tiv[i, j] + "\t");
                        }
                        else if (i > j)
                        {
                            tiv[i, j] = and;
                            Console.Write(tiv[i, j] + "\t");
                        }
                        else if (i < j)
                        {
                            tiv[i, j] = and;
                            Console.Write(tiv[i, j] + "\t");
                        }
                    }
                    Console.WriteLine("\n\n");
                }

                break;
            case 3:
                Console.WriteLine("введите число");
                Double arm = Convert.ToDouble(Console.ReadLine());
                for (int i = 1; i <= arm; i++)
                {
                    if (arm == 0)
                        Console.WriteLine(i);
                }
                break;
        }
        Console.WriteLine("1. Угадай число");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("4. Закрыть программу");
        Num = Convert.ToInt32(Console.ReadLine());
        if (Num == 4)
        {
            Environment.Exit(0);
        }
    }
}
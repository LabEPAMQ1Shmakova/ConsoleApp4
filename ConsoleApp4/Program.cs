using System;


namespace Massive


{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass1 = new int[3, 3];
            int[,] mass2 = new int[3, 3];
            int[,] masssum = new int[3, 3];

            do
            {
                Console.WriteLine("Введите первый массив:");

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write("Элемент [{0},{1}]  =  ", i, j);
                        mass1[i, j] = int.Parse(Console.ReadLine());
                    }

                }

                Console.WriteLine("Введите второй массив:");

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write("Элемент [{0},{1}]  =  ", i, j);
                        mass2[i, j] = int.Parse(Console.ReadLine());
                    }

                }

                Console.WriteLine("Результат сложения массивов:");

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        masssum[i, j] = mass1[i, j] + mass2[i, j];
                        Console.Write("{0}\t", masssum[i, j]);
                    }
                    Console.WriteLine();
                }


                Console.WriteLine("Для продолжения работы нажмите любую клавишу");
                Console.WriteLine("Для выхода нажмите клавишу Escape");
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
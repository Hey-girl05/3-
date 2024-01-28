using System;

namespace ThreePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите программу:");
                Console.WriteLine("1. Игра 'Угадай число'");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Выйти из программы");

                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        PlayGuessNumber();
                        break;
                    case "2":
                        PrintMultiplicationTable();
                        break;
                    case "3":
                        PrintDivisors();
                        break;
                    default:
                        Console.WriteLine("Ошибка: неверный ввод");
                        break;
                }
            }
        }

        static void PlayGuessNumber()
        {
            Random random = new Random();
            int numberToGuess = random.Next(101);

            while (true)
            {
                Console.Write("Введите число от 0 до 100: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == numberToGuess)
                {
                    Console.WriteLine("Поздравляем, вы угадали число!");
                    break;
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше");
                }
            }
        }

        static void PrintMultiplicationTable()
        {
            int[,] table = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{table[i, j],3}");
                }
                Console.WriteLine();
            }
        }

        static void PrintDivisors()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Делители числа: ");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}


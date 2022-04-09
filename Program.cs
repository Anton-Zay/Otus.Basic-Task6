using System;
namespace HomeWorkOfLesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        static void start()
        {
            int n = RangeOfTable();
            string enterString = EnterString(n);
            CreateTable(n, enterString);
        }

        static int RangeOfTable() //метод создания размерности
        {
            int n = default;
            bool b = default;

            while (!b)
            {
                Console.Write("Введите размерность таблицы: ");
                b = int.TryParse(Console.ReadLine(), out n);
                if (n < 1 || n > 6)
                    b = false;
            }

            return n;
        }

        static string EnterString(int n) //метод создания вводимой пользователем строки и проверка длины строки
        {
            int strLength = default;
            string str = default;
            while (strLength < 1 || strLength > (40 - 2 * n))
            {
                Console.Write("Введите произвольный текст: ");
                str = Console.ReadLine();
                strLength = str.Length;
            }

            return str;
        }

        static void PrintHorBoarder(int n, String str) //метод создания горизонтального разделителя таблицы из сплошных +
        {
            int fullLength = default;
            while (fullLength < (2 * n + str.Length))
            {
                Console.Write("+");
                fullLength++;
            }

            Console.WriteLine();
        }

        static void CreateTable(int n, String str) //метод формирования таблицы
        {
            for (int i = 0; i <= 6; i++)
            {
                switch (i)
                {
                    case int x when x is 0 or 2 or 4 or 6:
                        {
                            PrintHorBoarder(n, str);
                            break;
                        }

                    case 1:
                        {
                            CreateFirstLine(n, str);
                            break;
                        }

                    case 3:
                        {
                            CreateSecondLine(n, str);
                            break;
                        }

                    case 5:
                        {
                            CreateThirdLine(n, str);
                            break;
                        }
                }
            }
        }

        static void CreateFirstLine(int n, String str) // метод создания первой строки таблицы
        {
            for (int i = 0; i <= (n - 1) * 2; i++)
            {
                if (i == n - 1)
                {
                    Console.Write("+");
                    int counter = 1;
                    while (counter <= n - 1)
                    {
                        Console.Write(" ");
                        counter++;
                    }

                    Console.Write(str);

                    counter += str.Length;

                    while (counter <= (n - 1) * 2 + str.Length)
                    {
                        Console.Write(" ");
                        counter++;
                    }

                    Console.WriteLine("+");
                }
                else
                {
                    Console.Write("+");
                    int counter = 1;
                    while (counter <= (n - 1) * 2 + str.Length)
                    {
                        Console.Write(" ");
                        counter++;
                    }

                    Console.WriteLine("+");
                }
            }
        }

        static void CreateSecondLine(int n, String str) //метод создания второй строки таблицы
        {
            for (int i = 0; i <= (n - 1) * 2; i++)
            {
                Console.Write("+");
                if (i % 2 == 0)
                {
                    string[] arr = new String[str.Length + 2 * (n - 1)];
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            arr[j] = "+";
                        }
                        else
                        {
                            arr[j] = " ";
                        }
                    }

                    foreach (string s in arr)
                        Console.Write(s);

                    Console.WriteLine("+");
                }
                else
                {
                    string[] arr = new String[str.Length + 2 * (n - 1)];
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            arr[j] = " ";
                        }
                        else
                        {
                            arr[j] = "+";
                        }
                    }

                    foreach (string s in arr)
                        Console.Write(s);

                    Console.WriteLine("+");
                }
            }
        }

        static void CreateThirdLine(int n, String str) //метод создания третьей строки таблицы
        {
            string[,] arr = new string[str.Length + 2 * (n - 1), str.Length + 2 * (n - 1)];
            for (int i = 0; i < str.Length + 2 * (n - 1); i++)
            {
                for (int j = 0; j < str.Length + 2 * (n - 1); j++)
                {
                    if (j == i)
                    {
                        arr[i, j] = "+";
                        arr[i, str.Length + 2 * (n - 1) - j - 1] = "+";
                        arr[str.Length + 2 * (n - 1) - i - 1, j] = "+";
                        arr[str.Length + 2 * (n - 1) - i - 1, str.Length + 2 * (n - 1) - j - 1] = "+";
                    }

                    if (string.IsNullOrEmpty(arr[i, j]))
                    {
                        arr[i, j] = " ";
                    }
                }
            }

            int rows = arr.GetUpperBound(0) + 1;
            int columns = rows;

            for (int i = 0; i < rows; i++)
            {
                Console.Write("+");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]}");
                }

                Console.WriteLine("+");
            }
        }
    }
}
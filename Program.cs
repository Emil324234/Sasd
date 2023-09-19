using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string operation;

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Возведение в степень");
        Console.WriteLine("6. Квадратный корень");
        Console.WriteLine("7. Найти 1 процент от числа");
        Console.WriteLine("8. Найти факториал числа");
        Console.WriteLine("9. Выйти из программы");

        do
        {


            operation = Console.ReadLine();

            if (operation == "9")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (!(choicefalse(operation)))
            {
                Console.WriteLine("Неверный выбор операции. Попробуйте еще раз.");
                continue;
            }

            double x, y, result;

            if (operation != "6")
            {
                Console.Write("Введите первое число: ");
                x = Convert.ToDouble(Console.ReadLine());

                if (operation != "8")
                {
                    Console.Write("Введите второе число: ");
                    y = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    y = 0;
                }
            }
            else
            {
                Console.Write("Введите число: ");
                x = Convert.ToDouble(Console.ReadLine());
                y = 0;
            }

            switch (operation)
            {
                case "1":
                    result = x + y;
                    break;
                case "2":
                    result = x - y;
                    break;
                case "3":
                    result = x * y;
                    break;
                case "4":
                    if (y == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя");
                        continue;
                    }
                    result = x / y;
                    break;
                case "5":
                    Console.Write("Введите степень: ");
                    int N = Convert.ToInt32(Console.ReadLine());
                    result = Math.Pow(x, N);
                    break;
                case "6":
                    if (x < 0)
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }
                    result = Math.Sqrt(x);
                    break;
                case "7":
                    result = x * 0.01;
                    break;
                case "8":
                    if (x < 0)
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }
                    result = 1;
                    for (int i = 1; i <= x; i++)
                    {
                        result *= i;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine($"Результат: {result}");

        } while (operation != "9");
    }

    static bool choicefalse(string choice)
    {
        return choice == "1" || choice == "2" || choice == "3" || choice == "4" ||
        choice == "5" || choice == "6" || choice == "7" || choice == "8" || choice == "9";
    }
}
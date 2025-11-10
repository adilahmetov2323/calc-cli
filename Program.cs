using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "--help")
        {
            Help();
            return;
        }

        Console.WriteLine("calc-cli");
        Console.WriteLine("пиши команды типа: calc-cli add 2 3");
        Console.WriteLine("чтобы выйти напиши exit\n");

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input == null)
                continue;

            input = input.Trim().ToLower();

            if (input == "exit")
                break;

            if (input == "--help")
            {
                Help();
                continue;
            }

            string[] a = input.Split(' ');

            if (a.Length != 4)
            {
                Console.WriteLine("неправильно. надо так: calc-cli <операция> <a> <b>");
                continue;
            }

            if (a[0] != "calc-cli")
            {
                Console.WriteLine("пиши calc-cli в начале");
                continue;
            }

            double x, y;
            bool ok1 = double.TryParse(a[2], out x);
            bool ok2 = double.TryParse(a[3], out y);

            if (!ok1 || !ok2)
            {
                Console.WriteLine("оба аргумента должны быть числами");
                continue;
            }

            string op = a[1];
            double r = 0;
            bool good = true;

            if (op == "add")
            {
                r = x + y;
            }
            else if (op == "sub")
            {
                r = x - y;
            }
            else if (op == "mul")
            {
                r = x * y;
            }
            else if (op == "div")
            {
                if (y == 0)
                {
                    Console.WriteLine("делить на ноль ненано");
                    good = false;
                }
                else
                {
                    r = x / y;
                }
            }
            else if (op == "pow")
            {
                r = Math.Pow(x, y);
            }
            else
            {
                Console.WriteLine("такой операции нет");
                good = false;
            }

            if (good)
                Console.WriteLine("результат: " + r + "\n");
        }
    }

    static void Help()
    {
        Console.WriteLine("help по calc-cli");
        Console.WriteLine("используй так: calc-cli <операция> <a> <b>");
        Console.WriteLine("операции: add, sub, mul, div, pow");
        Console.WriteLine("пример: calc-cli add 2 3");
        Console.WriteLine("dotnet --help");
        Console.WriteLine("https://learn.microsoft.com/dotnet/csharp/");
    }
}

// 2) Простое — «Верхнеуровневая программа»
if (args.Length == 0)
{
    Console.WriteLine("Введите имя пользователя как аргумент.");
    return;
}

string name = args[0];
Console.WriteLine($"Привет, {name}!");
Console.WriteLine($"Длина имени: {name.Length}");

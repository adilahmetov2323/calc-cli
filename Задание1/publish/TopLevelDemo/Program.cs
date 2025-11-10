// 2) Простое — «Верхнеуровневая программа»
if (args.Length == 0)
{
    Console.WriteLine("Введите имя пользователя как аргумент.");
    return;
}

string username = args[0];
Console.WriteLine($"Привет, {username}!");
Console.WriteLine($"Длина имени: {username.Length}");

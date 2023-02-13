// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число: ");

string n = Console.ReadLine();

int i = n.Length;

if (i<3) Console.WriteLine("Третьей цифры нет");
else {
        Console.WriteLine(n[2]); //Console.WriteLine(n.Substring(2, 1));
}

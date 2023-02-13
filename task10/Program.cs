// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Что будем делить? ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("На что будем делить? ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine(a + " кратно " + b);
}
else  {
    int res = a % b;
    Console.WriteLine(a + " не кратно " + b + ", остаток: " + res);
}
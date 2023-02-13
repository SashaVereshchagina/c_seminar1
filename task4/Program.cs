// Выяснить является ли число чётным

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine(a + " - четное число");
}
else  Console.WriteLine(a + " - нечетное число");
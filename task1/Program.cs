Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());

//int a = new Random().Next(1,1000);
//int b = new Random().Next(1,1000);

//Console.WriteLine(a);
//Console.WriteLine(b);

if (a == b * b)
{
    Console.WriteLine("Число 1 - квадрат числа 2");
}

else if (b == a * a)

    {
        Console.WriteLine("Число 2 - квадрат числа 1");
    }
    
    else Console.WriteLine("Ни одно из чисел не является квадратом другого");
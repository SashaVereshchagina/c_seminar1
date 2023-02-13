// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int n = new Random().Next(10,100);

Console.WriteLine("Число: " +n);

int a = n/10;
int b = n%10;

if (a>b) Console.WriteLine("Наибольшая цифра: " + a);
else Console.WriteLine("Наибольшая цифра: " + b);
// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

n = (n/100)*10+(n%10);

Console.WriteLine("Новое число: " + n);

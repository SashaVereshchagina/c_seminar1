// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

int i = (n%10);

Console.WriteLine("Последняя цифра: " + i);
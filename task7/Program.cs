// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

int i = ((n%100)-(n%10))/10;

Console.WriteLine("Вторая цифра: " + i);

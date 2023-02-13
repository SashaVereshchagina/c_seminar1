// По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("Это понедельник");
}
else if (a==2)
{
    Console.WriteLine("Это вторник");
}
else if (a==3)
{
    Console.WriteLine("Это среда");
}
else if (a==4)
{
    Console.WriteLine("Это четверг");
}
else if (a==5)
{
    Console.WriteLine("Это пятница");
}
else if (a==6)
{
    Console.WriteLine("Это суббота");
}
else if (a==7)
{
    Console.WriteLine("Это воскресенье");
}
else {
    Console.WriteLine("Нет такого дня недели");
}
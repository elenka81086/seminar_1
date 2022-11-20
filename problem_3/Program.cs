/* напишите программу, которая будет выдавать название
дня недели по заданному номеру*/
int NumberDay = new int();
Console.WriteLine("Введите число"); 
NumberDay = Convert.ToInt32(Console.ReadLine());
if (NumberDay == 1)
{
    Console.WriteLine("Понедельник");
}
if (NumberDay == 2)
{
    Console.WriteLine("Вторник");
}
if (NumberDay == 3)
{
    Console.WriteLine("Среда");
}
if (NumberDay == 4)
{
    Console.WriteLine("Четверг");
}
if (NumberDay == 5)
{
    Console.WriteLine("Пятница");
}
if (NumberDay == 6)
{
    Console.WriteLine("Суббота");
}
if (NumberDay == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Такого дня недели не существует!");
}
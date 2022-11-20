/* напишите программу, которая на вход принимает два числа и проверяет, 
является ли второе число квадратом первого*/
int Number1 = new int();
Console.WriteLine("Введите число:");
Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = new int();
Console.WriteLine("Введите число:");
Number2 = Convert.ToInt32(Console.ReadLine());
if (Number2 == Number1 * Number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
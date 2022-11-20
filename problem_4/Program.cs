/* напишите программу, которая на вход принимает 
число N и выдает целые число от -N до N*/
int Number = new int();
Console.WriteLine("Введите число");
Number = Convert.ToInt32(Console.ReadLine());
int A = - Number;

while (A <= Number)
{
    Console.Write(A + " ");
    A = A + 1;
}
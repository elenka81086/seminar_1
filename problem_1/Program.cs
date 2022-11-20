/* напишите программу, котрая на вход принимает число и выдает его квадрат*/
int userNumber = new int();
Console.WriteLine("Введите число");
userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber * userNumber;
Console.WriteLine(result);

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите день недели: ");
int number= Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7) Console.WriteLine("это выходной");
else Console.WriteLine("это не выходной");


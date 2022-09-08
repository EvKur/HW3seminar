// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int thirdDigit=N/10%10;

Console.WriteLine($"Вторая цифра - {thirdDigit}");


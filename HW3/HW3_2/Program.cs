// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int firstDigit=N/10000;
int fifthDigit=N%10;
int secondDigit=N/1000%10;
int fourthDigit=N/10%10;

if (firstDigit==fifthDigit&&secondDigit==fourthDigit) Console.WriteLine("Введенное число являтся палиндромом");
else Console.WriteLine("Введенное число не являтся палиндромом");

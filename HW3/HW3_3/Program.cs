// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

int start=1;
while(start<=N)
{
    Console.WriteLine(start*start*start);
    start++;
}
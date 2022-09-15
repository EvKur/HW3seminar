Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSumNumbers(number));
int GetSumNumbers(int num)
{
    int sum = 0;
    int next = 0;
    while (num >0)
    {
      next = num - num%10;
      sum= sum + (num - next);
      num=num/10; 
    }
    return sum;
}


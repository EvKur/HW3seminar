// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int size =6;
double[] array = new double[size];

for(int i=0;i<size;i++)
{
array[i] =new Random().Next(100);
Console.Write(array[i]+ "\t");}
double Max=array[0];
double Min=array[0];
for(int i=1;i<size;i++)
{if (array[i]<Min) Min=array[i];
if (array[i]>Max) Max=array[i];}
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным числом в массиве равна: {Max-Min}");
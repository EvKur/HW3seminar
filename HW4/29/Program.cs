// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int[] array=new int[8];

for (int i=0;i<array.Length;i++)
{
   
    array[i]= new Random().Next(); //or array[i]=Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"Result array: [ {String.Join(", ", array)} ]");
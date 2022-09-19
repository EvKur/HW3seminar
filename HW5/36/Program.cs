// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int size=6;
int[] array=new int[size];
int SumElementsWithOddIndex=0;

for(int i=0;i<size;i++){
    array[i]=new Random().Next(20);
    Console.WriteLine(array[i]+"\t");
    if(i%2!=0){
        SumElementsWithOddIndex+=array[i];}
}
Console.WriteLine($"Сумма элементов стоящих на нечетных индексах равна: {SumElementsWithOddIndex}");

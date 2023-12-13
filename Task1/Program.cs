// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];
Random rand = new Random();

for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 101);
}

for(int i = 0;i < array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}

int count=0;
for(int i=0; i < array.Length; i++)
{
    if(array[i] > 19 && array[i] < 91)
    {
        count++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine(count);

// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] a = new int[10];
int count = 0;
 
for (int i = 0; i < 10; i++)
{
    Console.Write($"Введите {i+1} целое число ", i);
    a[i] = Convert.ToInt32(Console.ReadLine());

    if ((a[i] % 2) == 0)
    {
        count++;
    }
}

Console.Write($"В массиве {count} чётных чисел");
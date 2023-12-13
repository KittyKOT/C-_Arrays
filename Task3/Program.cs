// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];
Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(100) + rand.NextDouble(), 2);
        Console.Write($"{array[i]} ");
    }

int FindMax(double[] array)
{
    int MaxValue = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > array[MaxValue])
            {
                MaxValue = i;
            }
    }
    return MaxValue;
}
int FindMin(double[] array)
{
    int MinValue = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[MinValue])
            {
                MinValue = i;
            }
    }
    return MinValue;
}

int iMax = FindMax(array);
int iMin = FindMin(array);

Console.Write($"\nРазница между максимальным {array[iMax]} и минимальным {array[iMin]} элементами массива: {array[iMax] - array[iMin]}");
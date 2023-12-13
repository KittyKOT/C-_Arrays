// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

Console.Write("Введите натуральное число от 1 до 100 000: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1 || N > 100000)
{
    System.Console.WriteLine("Введено некорректное число!");
    return;
}

int[] array = new int[N.ToString().Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = N % 10;
    N /= 10;
}

for (int i = 0; i < array.Length / 2; i++) // Array.Reverse(array);
{
   int temp = array[i];
   array[i] = array[array.Length - i - 1];
   array[array.Length - i - 1] = temp;
}

Console.Write("[" + string.Join(" ", array) + "]");
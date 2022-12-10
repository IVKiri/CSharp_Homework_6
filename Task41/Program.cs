// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
Console.Write("Сколько чисел будет введено? ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(M);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count+=1;
    }
}

Console.WriteLine($"Введено чисел больше 0: {count}");
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

void Total(int number)
{
    int count = 0;
    if (number == 0)
    {
        return;
    }
    else
    {
        Total(number / 10);
        count += 1;
    }
    Console.Write(count);

}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Total(num);
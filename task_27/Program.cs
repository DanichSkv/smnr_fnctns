// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits (int num)
{
    int result = 0;
    while (num != 0)
    {
      result += num % 10;
      num = num / 10;
    }
    return result;
}

Console.WriteLine("Привет! Эта программа выдаёт сумму цифр в числе! Введи число: ");
int start_num = Convert.ToInt32(Console.ReadLine());

int final_num = SumOfDigits(start_num);
Console.WriteLine($"Результат: {final_num}");
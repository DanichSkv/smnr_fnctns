// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowerOfNumber (int num_grnd, int num_up)
{
    int result = 1;
    
    for (int i = 1; i <= num_up; i++)
    {
        result *= num_grnd;
    }
    return result;
}

Console.WriteLine("Привет! Эта программа возводит натуральные числа в натуральные степени! Введи число, которое хочешь возвести в степень:");
int ground_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи степень, в которую хочешь возвести: ");
int up_num = Convert.ToInt32(Console.ReadLine());

int final_num = PowerOfNumber(ground_num, up_num);
Console.WriteLine($"Результат: {final_num}");
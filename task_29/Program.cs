// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Create_Array(int length)
{
    int[] array = new int [length];
    Console.WriteLine("Ожидание переменных (разделитель - Enter): ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

Console.WriteLine("Привет! Эта программа создаёт одномерный массив! Введи размер массива: ");
int start_num = Convert.ToInt32(Console.ReadLine());

int[] array_fin = Create_Array(start_num);
PrintArray(array_fin);
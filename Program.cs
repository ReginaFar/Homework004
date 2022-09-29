//Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void Zadacha25()
{
    Console.WriteLine("Введите число A");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    int count = 1;
    while (count <= numberB)
    {
        result = result * numberA;
        count++;
    }
    Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");
}
Zadacha25();

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Zadacha27()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int current_number = 0;
    while (number > 9)
    {
        current_number = number % 10;
        sum = sum + current_number;
        number = number / 10;
    }
    sum = sum + number;
    Console.WriteLine("Сумма цифр числа равна = "+ sum);
}
Zadacha27();

//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

int size = 8;
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Sort(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9,10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ ",");
    }
    Console.WriteLine();
}

void Sort(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[i + 1]))
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
}
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
//Zadacha25();

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
//Zadacha27();

//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Zadacha29()
{
    Random random = new Random();
    int size = 8;
    int [] numbers = new int [size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next();
    }
    Console.Write(numbers + " ");
    Console.WriteLine();
}
Zadacha29();

  //for (int i = 1; i < size; i++)
    //{
      //  if (numbers[i] > max)
       // {
         //   max = numbers[i];
          //  max_i = i;
           // int tmp = numbers[size-1];
           // numbers[size-1] = max;
           // numbers[max_i] = tmp;
        //}
    //Console.WriteLine(numbers);
    //}
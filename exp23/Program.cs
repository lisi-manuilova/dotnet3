// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27;       5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int [] numbers = new int [number];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = (i +1)*(i+1)*(i+1);
    Console.WriteLine(numbers[i]);
}
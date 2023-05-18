// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет; 12821 -> да;   23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a=number/10000;
int b=number/1000-a*10;
int c=number/10-number/100*10;
int d=number%10;

if (number> 9999 && number <100000)
{
    if (a==d&&b==c)
    {
        Console.WriteLine("Число палиндром");
    }
else 

    Console.WriteLine("Число не палиндром");
}
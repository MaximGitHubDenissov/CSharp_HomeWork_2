// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = new Random().Next(0, 100000);
Console.WriteLine(number);

// Console.WriteLine ("Введите число");
// int number = int.Parse(Console.ReadLine()!); Для проверки программы путем ввода числа.

int num1 = number % 10;
int num2 = number % 100;
int num22 = number / 100; //Переменная для проверки условий
int num3 = num2 / 10;
int num4 = number % 1000;
int num5 = num4 / 100;

if (num22 == 0)
{
    Console.WriteLine("У числа нет третьей цифры!");
}

else if (num22 >= 1 && num22 <= 9)
{
    Console.WriteLine(num1);
}
else if (num22 >= 10 && num22 <= 99)
{
    Console.WriteLine(num3);
}
else if (num22 >= 100 && num22 <= 999)
{
    Console.WriteLine(num5);
}






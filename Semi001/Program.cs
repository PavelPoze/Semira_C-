/*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/
/*
Console.Write("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne == numberTwo * numberTwo)
/*
int a = 25;

int b = 5;

if ( a == b * b)*/  /*
{
    Console.WriteLine("Yes");
}

else
{
    Console.WriteLine("No");
}
*/
// Задача про дни недели, ввод в консоль  вывод
Console.WriteLine("Введите число дня недели: ");
string? input = Console.ReadLine();
int a = Convert.ToInt32(input);
if (a == 1)
{
    Console.WriteLine("Понедельник");
}
if (a == 2)
{
   Console.WriteLine("Вторинк");
}
if (a == 3)
{
   Console.WriteLine("Среда");
}
if (a == 4)
{
   Console.WriteLine("Четверг");
}
if (a == 5)
{
   Console.WriteLine("Пятница");
}
if (a == 6)
{
   Console.WriteLine("Суббота");
}
if (a == 7)
{
   Console.WriteLine("Воскресенье");
}

//задача с вводом числа и вопросом к пользователю
Console.Write("Введите число: ");
string? input = Console.ReadLine();
int number = Convert.ToInt32(input);

int sgr = number * number;

Console.WriteLine(number + " ->" + sgr);
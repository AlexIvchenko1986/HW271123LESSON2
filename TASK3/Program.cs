//Задача 3: Напишите программу, которая принимает на вход целое число из 
//отрезка [10, 99] и показывает наибольшую цифру числа.

// 1. Ввод целого числа пользователем с клавиатуры
// 2. Ограничить количество символов
// 3. Найти наибольшую из двух цифр в числе
// 4. вывод на экран результат MAX
// 5. вывод на экран если число менее 10 или более 99

Console.WriteLine("Введите целое число от 10 до 99 ");
int number = Convert.ToInt32(Console.ReadLine());
//int result = number;
int FirstDigit = number / 10;
int SecondDigit = number % 10;
//int max = 0;
Console.WriteLine();
Console.WriteLine($" Вы ввели число {number} ");


if (FirstDigit > SecondDigit)
{
    Console.WriteLine($" Первая цифра {FirstDigit} больше второй цифры {SecondDigit} ");
}
else if (number < 10 || number <= 0)
{
    Console.WriteLine("Вы ввели число меньше 10 ");
}
else if (number > 99)
{
    Console.WriteLine("Вы ввели число больше 99 ");
}
else if (FirstDigit == SecondDigit)
{
    Console.WriteLine("Введенные числа равны ");
}
else
{
    Console.WriteLine($" Вторая цифра {SecondDigit} больше первой цифры {FirstDigit} ");
}
//int result = number;
// Console.WriteLine();
// Console.WriteLine($" Вы ввели двухзначное число {number} ");
// FirstDigit = number / 10;
// SecondDigit = number % 10;
//     Console.WriteLine();
//     Console.WriteLine(" Первая цифра Больше ");
// }
// if ((number / 10 < number % 10) && (number > 10 || number < 99) )
// {
//     Console.WriteLine(" Вторая цифра Больше ");
// }
// int max = 0;
// else if (FirstDigit > SecondDigit)
// {
//     max = FirstDigit;
//     Console.WriteLine($" Первая цифра {max} ");
// }
// else if (FirstDigit > SecondDigit)
// {
//     max = SecondDigit;
//     Console.WriteLine($" Вторая цифрв {max} ");
// }
// else if (number < 10 && number > 99)
// {
//     Console.WriteLine("Вы ввели число меньше 10 или число больше 99 ");
// }
// else if (FirstDigit == SecondDigit)
// {
//     Console.WriteLine("Введенные числа равны ");
// }
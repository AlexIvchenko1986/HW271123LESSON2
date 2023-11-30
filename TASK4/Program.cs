// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.Clear();

Console.WriteLine("Введите натуральное число от 1 до N ");
int number = Convert.ToInt32(Console.ReadLine());
string digit = string.Empty;
int temp = number;

if (number < 10)
    Console.WriteLine($" {number} => {number} ");
else
{
    for (; number > 0; number /= 10)
    //for (int index = 1; index <= number; index++) #легкое решение с запятой на конце
    {
        if(number == temp) digit = number % 10 + " "+ digit;
        else digit = number % 10 + ","+ digit; // digit += .... в конец стрроки в обратном направлении
                                           //  number % 10 + "," + digit; в начало строки

        //Console.Write(", {0}", index); #легкое решение с запятой на конце
        //Console.Write($" {index},");
    }
    Console.Write(digit);
}



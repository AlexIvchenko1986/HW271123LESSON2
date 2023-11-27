// Задача 2: Напишите программу, которая принимает на вход координаты 
//точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти 
//плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату X ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0 && X !=0 && Y !=0 )
{
    Console.WriteLine($" Координаты {X} и {Y} Находятся в плоскости I ");
}
if (X < 0 && Y > 0 && X !=0 && Y !=0 )
{
    Console.WriteLine($" Координаты {X} и {Y} Находятся в плоскости II ");
}
if (X < 0 && Y < 0 && X !=0 && Y !=0 )
{
    Console.WriteLine($" Координаты {X} и {Y} Находятся в плоскости III ");
}
if (X > 0 && Y < 0 && X !=0 && Y !=0 )
{
    Console.WriteLine($" Координаты {X} и {Y} Находятся в плоскости IV ");
}
else if ( X == 0 && Y == 0)
{
    Console.WriteLine($" Координата X = {X} и Координата Y = {Y} Введите не нулевое значение ");
}
else if ( X == 0)
{
    Console.WriteLine($" Координата X = {X} Введите не нулевое значение ");
}
else if ( Y == 0)
{
    Console.WriteLine($" Координата Y = {Y} Введите не нулевое значение ");
}
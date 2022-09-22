//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write ("Введите число A: ");
// присваиваем переменным тип double, чтобы можно было работать с дробными числами
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите число B: ");
double numberB = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите число D: ");
double numberD = Convert.ToDouble(Console.ReadLine());

if ((numberA > numberB) && (numberA > numberD))
{
    Console.Write ($"Максимальное число: {numberA}");
}
if ((numberA == numberB) && (numberA > numberD))
{
    Console.Write ($"Максимальное число: {numberA}");
}
if ((numberA == numberD) && (numberA > numberB))
{
     Console.Write ($"Максимальное число: {numberA}");
}
if ((numberB > numberA) && (numberB > numberD))
{
     Console.Write ($"Максимальное число: {numberB}");
}
if ((numberD > numberA) && (numberD > numberB))
{
     Console.Write ($"Максимальное число: {numberD}");
}
if ((numberD == numberA) && (numberD > numberB))
{
     Console.Write ($"Максимальное число: {numberD}");
}
if ((numberD == numberB) && (numberD > numberA))
{
     Console.Write ($"Максимальное число: {numberD}");
}
if ((numberA == numberB) && (numberA == numberB))
{
     Console.Write ("Максимальное число отсутствует, все числа равны");
}
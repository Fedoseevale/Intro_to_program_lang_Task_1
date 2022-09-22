//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write ("Введите число A: ");
// присваиваем переменным тип double, чтобы можно было работать с дробными числами
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите число B, отличное от А: ");
double numberB = Convert.ToDouble(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write ($"Большее число: {numberA}, меньшее число {numberB} ");
}
if (numberA < numberB)
{
    Console.Write ($"Большее число: {numberB}, меньшее число: {numberA} ");
}
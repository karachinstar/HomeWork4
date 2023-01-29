/*Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
double Exp(int numA, int numB) 
{
    double res = Math.Pow(numA, numB);
    return res;
}
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine());



Console.WriteLine($"Число {x} в степени {y} -> {Exp(x, y)}");
/*Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x;
int sum = 0;
int[] digits = new int[1 + (int)Math.Log10(x)];
for (int i = digits.Length - 1; i >= 0; i--)
{
    int digit;
    x = Math.DivRem(x, 10, out digit);
    digits[i] = digit;
}

for (int i = 0; i < digits.Length; i++)
{
    sum = sum + digits[i];
}
Console.WriteLine($"Сумма цифр числа {x1} -> {sum}");
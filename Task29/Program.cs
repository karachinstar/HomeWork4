/*Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int x = 8;
int[] num = new int[x];
for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(0, 100);
Console.Write("[");
for (int i = 0; i < num.Length; i++)
{
    if (i < num.Length - 1)
    {
        Console.Write($"{num[i]}, ");
    }
    else
    {
        Console.Write($"{num[i]}");
    }
}
Console.Write("] -> это наш массив");

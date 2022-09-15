/*Задача 27: Напишите программу, которая принимает на вход
 число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();
Console.WriteLine("\n Задача 27");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void Sum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int numRemains = num % 10;
        num = num / 10;
        sum = sum + numRemains;
    }
    Console.Write($"Сумма цифр в заданном числе равна {sum}");
}
Sum(num);

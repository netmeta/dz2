//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 23 == 0 && a % 7 == 0)
{
    Console.WriteLine($"{a} -> Да");
}
else
{
    Console.WriteLine($"{a} -> Нет");
}

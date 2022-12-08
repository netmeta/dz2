Console.Clear();
int N = new Random().Next(1, 65537);

Console.Write(N);
string stringNumber = Convert.ToString(N);

if (stringNumber.Length > 2)
{
    Console.Write($" -> {stringNumber[2]}");
}
else
{
    Console.Write(" -> Третьей цифры нет");
}

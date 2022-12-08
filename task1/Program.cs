int N = new Random().Next(100, 1000);
Console.WriteLine(N);
N = (N / 10) % 10;
Console.WriteLine($"Вторая цифра числа -> {N}");

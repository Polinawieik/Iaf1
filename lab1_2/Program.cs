try
{
    Console.Write("Введите первую переменную");
    double C = double.Parse(Console.ReadLine());
    Console.Write("Введите вторую переменную");
    double L = double.Parse(Console.ReadLine());
    double T = 2 * Math.PI * Math.Sqrt(L * C);
    double v = 1 / T;
    Console.WriteLine($"Вывод T: {T}");
    Console.WriteLine($"Вывод v: {v}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

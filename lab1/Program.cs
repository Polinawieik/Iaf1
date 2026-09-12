Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите h:");
double h = double.Parse(Console.ReadLine());
double A = (Math.Tan(Math.Pow(y,3)- Math.Pow(h,4))+ Math.Pow(h,2)) / (Math.Pow(Math.Sin(h), 3)+y);
Console.WriteLine($"A={A:F2}");


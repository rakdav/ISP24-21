//Оператор цикла for - средний уровень 28

//try
//{
//    Console.Write("Введите k:");
//    int k = int.Parse(Console.ReadLine());
//    double Z = 1;
//    for (int n = -3; n <=k; n++)
//    {
//        double first = (n + 2) * Math.Abs(n-9);
//        double F = 1;
//        for (int i = 1; i <=n; i++) F *= i+3;
//        Z *= first / F;
//    }
//    Console.WriteLine($"Z={Z:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//вычисление бесконечных сумм - 28 вариант
//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    double s = 0;
//    for (int i = 1;i <= n; i++)
//    {
//        s += Math.Pow(x, i) * Math.Cos(i*Math.PI/4);
//    }
//    Console.WriteLine($"S={s:F2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//табулирование функций 28 вариант
Console.WriteLine("------------------------------");
Console.WriteLine("|       x       |       y     |");
Console.WriteLine("------------------------------");
for(double x = 1; x <= 3; x += 0.2)
{
Console.WriteLine($"|{x,9:F2}{"",6}|{(Math.Pow(x,3)-1.75*x+0.75),10:F2}{"",3}|");
}
Console.WriteLine("------------------------------");

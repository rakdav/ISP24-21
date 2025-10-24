//базовый уровень 30 вариант
//double[] mas=new double[12];
//Random r=new Random();
//for (int i=0; i<mas.Length; i++)
//{
//    mas[i]=r.NextDouble()*100;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();
//double min = mas[0];
//int index = 0;
//for (int i = 1; i < mas.Length; i++)
//    if (mas[i] < min)
//    {
//        min = mas[i];
//        index = i;
//    }
//Console.WriteLine(min+index);
//средний уровень 30 вариант
Random r = new Random();
int n = r.Next(10, 20);
double[] mas1 = new double[n];
double[] mas2 = new double[n];

for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = r.NextDouble() * 100;
    Console.Write($"{mas1[i]:F2} ");
}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    mas2[i] = r.NextDouble() * 100;
    Console.Write($"{mas2[i]:F2} ");
}
Console.WriteLine();
double max1 = mas1[0];
int index1 = 0;
for (int i = 1; i < mas1.Length; i++)
    if (mas1[i]> max1)
    {
        max1= mas1[i];
        index1 = i;
    }
double max2 = mas2[0];
int index2 = 0;
for (int i = 1; i < mas2.Length; i++)
    if (mas2[i] > max2)
    {
        max2 = mas2[i];
        index2 = i;
    }
Console.WriteLine($"{max1:f2}");
Console.WriteLine($"{max2:f2}");
double temp = mas1[index1];
mas1[index1]=mas2[index2];
mas2[index2] = temp;
foreach(double i in mas1) Console.Write($"{i:f2} ");
Console.WriteLine();
foreach (double i in mas2) Console.Write($"{i:f2} ");
Console.WriteLine();
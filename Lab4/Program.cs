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
//Random r = new Random();
//int n = r.Next(10, 20);
//double[] mas1 = new double[n];
//double[] mas2 = new double[n];

//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = r.NextDouble() * 100;
//    Console.Write($"{mas1[i]:F2} ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i] = r.NextDouble() * 100;
//    Console.Write($"{mas2[i]:F2} ");
//}
//Console.WriteLine();
//double max1 = mas1[0];
//int index1 = 0;
//for (int i = 1; i < mas1.Length; i++)
//    if (mas1[i]> max1)
//    {
//        max1= mas1[i];
//        index1 = i;
//    }
//double max2 = mas2[0];
//int index2 = 0;
//for (int i = 1; i < mas2.Length; i++)
//    if (mas2[i] > max2)
//    {
//        max2 = mas2[i];
//        index2 = i;
//    }
//Console.WriteLine($"{max1:f2}");
//Console.WriteLine($"{max2:f2}");
//double temp = mas1[index1];
//mas1[index1]=mas2[index2];
//mas2[index2] = temp;
//foreach(double i in mas1) Console.Write($"{i:f2} ");
//Console.WriteLine();
//foreach (double i in mas2) Console.Write($"{i:f2} ");
//Console.WriteLine();

//высокий уровень 30 вариант
//int[] mas=new int[3];
//Random r = new Random();
//for (int i = 0; i < 3; i++)
//{
//    mas[i]= r.Next(100,1000);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//string[] res=new string[3];
//for (int i = 0;i < 3;i++)
//{
//    res[i] = Convert.ToString(mas[i],2);
//    Console.Write(res[i]+" ");
//}
//Console.WriteLine();

//try
//{
//    Console.Write("Напишите колличество копеек: ");
//    double x = double.Parse(Console.ReadLine());
//    if (x % 10 == 0 | x % 10 > 4)
//    {
//        Console.WriteLine($"{x} копеек");

//    }
//    else if (x == 1)
//    {
//        Console.WriteLine("1 копейка");
//    }
//    else
//    {
//        Console.WriteLine($"{x} копейки");
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);

//}

try
{
    //Console.Write("Введите количество строк:");
    //int n=int.Parse(Console.ReadLine());
    //Console.Write("Введите количество столбцов:");
    //int m = int.Parse(Console.ReadLine());
    //int[,] mas=new int[n,m];
    //Random rnd=new Random();
    //for(int i = 0;i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j <mas.GetLength(1); j++)
    //    {
    //        mas[i,j]=rnd.Next(-5,6);
    //        Console.Write(mas[i,j]+" ");
    //    }
    //    Console.WriteLine();
    //}
    //int min = mas[0, 0];
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        if (mas[i,j]<min) min= mas[i,j];
    //    }
    //}
    //Console.WriteLine($"min={min}");
    //for(int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        if (mas[i, j] % 2 == 0) mas[i, j] *= 2;
    //        else mas[i, j] *= 3;
    //        Console.Write(mas[i, j] + " ");
    //    }
    //    Console.WriteLine();
    //}
    //min = mas[0, 0];
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        if (mas[i, j] < min) min = mas[i, j];
    //    }
    //}
    //Console.WriteLine($"min={min}");

    //Console.Write("Введите количество строк и столбцов матрицы:");
    //int n=int.Parse(Console.ReadLine());
    //int[,] mas=new int[n,n];
    //Random rnd = new Random();
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        mas[i, j] = rnd.Next(-3, 4);
    //        Console.Write(mas[i, j] + " ");
    //    }
    //    Console.WriteLine();
    //}
    //double s = 0;
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        if (i == j) s += mas[i, j]; 
    //    }
    //}
    //Console.WriteLine($"Avg={s/n:F2}");
    //s = 0;
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        if (mas[i, j] < 0) mas[i, j] = Math.Abs(mas[i, j]);
    //        if (i == j) s += mas[i, j];
    //        Console.Write(mas[i, j] + " ");
    //    }
    //    Console.WriteLine();
    //}
    //Console.WriteLine($"Avg={s / n:F2}");

    //Зубчатые массивы
    //Random rnd = new Random();
    //int n = rnd.Next(5, 11);
    //int[][] mas = new int[n][];
    //for (int i = 0; i < n; i++)
    //{
    //    mas[i] = new int[rnd.Next(3, 11)];
    //}
    //for (int i = 0; i < mas.Length; i++)
    //{
    //    for (int j = 0; j < mas[i].Length; j++)
    //    {
    //        mas[i][j]=rnd.Next(0,10);
    //        Console.Write(mas[i][j]+" ");
    //    }
    //    Console.WriteLine();
    //}

    //базовый уровень 1 вариант
    //int[,] mas = new int[3, 4];
    //Random rand = new Random();
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        mas[i, j] = rand.Next(10);
    //        Console.Write(mas[i,j]+" ");
    //    }
    //    Console.WriteLine();
    //}
    //for (int i = 0;i <mas.GetLength(1)-1;i++)
    //{
    //    for(int j = i+1;j < mas.GetLength(1);j++)
    //    {
    //        if (mas[mas.GetLength(0)-1, i] > mas[mas.GetLength(0) - 1, j])
    //        {
    //            int temp = mas[mas.GetLength(0) - 1, i];
    //            mas[mas.GetLength(0) - 1, i]=mas[mas.GetLength(0) - 1, j];
    //            mas[mas.GetLength(0) - 1, j]=temp;
    //        }
    //    }
    //}
    //Console.WriteLine();
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        Console.Write(mas[i, j] + " ");
    //    }
    //    Console.WriteLine();
    //}

    //средний уровень 1 вариант
    //Random rand = new Random();
    //int[,] mas = new int[rand.Next(3, 10), rand.Next(3, 10)];
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        mas[i, j] = rand.Next(-9, 10);
    //        Console.Write(mas[i, j] + " ");
    //    }
    //    Console.WriteLine();
    //}
    //int k = 0;
    //int indexRow = -1;
    //int indexColumn = -1;
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        if (mas[i, j] < 0) k++;
    //        if (k == 2)
    //        {
    //            indexRow = i; indexColumn = j; break;
    //        }
    //    }
    //    if (k == 2) break;
    //}
    //for (int i = indexColumn + 1; i < mas.GetLength(1) - 1; i++)
    //{
    //    for (int j = i + 1; j < mas.GetLength(1); j++)
    //    {
    //        if (mas[indexRow, i] > mas[indexRow, j])
    //        {
    //            int temp = mas[indexRow, i];
    //            mas[indexRow, i] = mas[indexRow, j];
    //            mas[indexRow, j] = temp;
    //        }
    //    }
    //}
    //Console.WriteLine();
    //for (int i = 0; i < mas.GetLength(0); i++)
    //{
    //    for (int j = 0; j < mas.GetLength(1); j++)
    //    {
    //        Console.Write(mas[i, j] + " ");
    //    }
    //    Console.WriteLine();
    //}

    //высокий уровень 1 вариант
    Random rand = new Random();
    int[,] mas = new int[rand.Next(10, 21), 2];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = rand.Next(-20, 21);
            Console.Write(mas[i,j]+" ");
        }
        Console.WriteLine();
    }
    int maxX = mas[0,0], maxY=mas[0,1];
    int minX = mas[0, 0], minY = mas[0, 1];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        if(mas[i, 0] > maxX) maxX = mas[i, 0];
        if(mas[i, 0] < minX) minX = mas[i, 0];
        if(mas[i, 1] > maxY) maxY = mas[i, 1];
        if(mas[i, 1] < minY) minY = mas[i, 1];
    }
    Console.WriteLine($"Центр окружности:({(maxX+minX)/2:F1};{(maxY+minY) / 2:F1})");
    Console.WriteLine($"Радиус:{((maxX > maxY)?maxX:maxY):f2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
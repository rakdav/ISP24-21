using System.Threading.Channels;
using System.Xml.Linq;
using MyLib;

//int Sum(int a, int b)
//{
//    return a + b;
//}
//int Sum(int a, int b)=>a+b;
//void Swap(ref int a,ref int b)
//{
//    int temp=a; 
//    a=b; 
//    b=temp;
//}
//double Area(double R)
//{
//    return Math.PI*R*R;
//}
//long Factorial(int n)
//{
//    long F = 1;
//    for (int i = 1; i <=n; i++)  F*= i;
//    return F;
//}
//void getHello()
//{
//    Console.WriteLine("Hello, world!");
//}
//void getName(string name)
//{
//    Console.WriteLine($"Привет! Меня зовут {name}");
//}
//void getDate()=> Console.WriteLine($"{DateTime.Now}");
//void Summa(double a, double b)=> Console.WriteLine($"{a}+{b}={a+b}");
////Необязательные параметры
//void printPerson(string name,int age=1,string company = "Undefined")
//{
//    Console.WriteLine($"Name:{name} Age:{age} Company:{company}");
//}
//void SumOut(int x,int y,out int result)
//{
//    result = x+y;
//}

//void getRectangleData(in int w,in int h,out int area,out int perimetr)
//{
//   // w = 7;
//    area = w * h;
//    perimetr = (w+h)*2;
//}
//void Increment(ref readonly int n)
//{
//    //n++;
//    Console.WriteLine(n);
//}
//void sumNumbers(params int[] numbers)
//{
//    int sum = 0;
//    foreach(var n in numbers) sum+= n;
//    Console.WriteLine(sum);
//}
//int sumMas(int[] mas)
//{
//    mas[0] = 78;
//    int s = 0;
//    foreach (var n in mas) s+= n;
//    return s;
//}
//try
//{
//    Console.Write("Введите первую переменную:");
//int x = int.Parse(Console.ReadLine());
//Console.Write("Введите вторую переменную:");
//int y = int.Parse(Console.ReadLine());
//Console.WriteLine($"{x}+{y}={Sum(x,y)}");
//Console.Write("Введите радиус окружности:");
//double r = double.Parse(Console.ReadLine());
//Console.WriteLine($"S={Area(r):F2}");
//Console.WriteLine($"{x}!={Factorial(x)}");
// getHello();
//Console.Write("Введите имя:");
//string name=Console.ReadLine();
////getName(name);
//getDate();
//Summa(x, y);
//printPerson("Иван");
//printPerson("Вася",60);
//printPerson("Tom", 40, "Microsoft");
//printPerson("Bob", company:"Samsung",age:34);
//Console.WriteLine($"x={x} y={y}");
//Swap(ref x,ref y);
//Console.WriteLine($"x={x} y={y}");
//int res;
//SumOut(x,y,out res);
//Console.WriteLine($"{x}+{y}={res}");
//Console.Write("Введите число:");
//string n=Console.ReadLine();
//if (int.TryParse(n, out var number)) Console.WriteLine(number);
//double v = number * 2;
//int area, perimetr;
//getRectangleData(x, y,out area,out perimetr);
//Console.WriteLine(area);
//Console.WriteLine(perimetr);
//    int[] mas = { 1, 4, 5, 67 };
//    sumNumbers(mas);
//    sumNumbers(1,5,7,8,59);
//    Console.WriteLine(sumMas(mas));
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Реализация сортировки слиянием
//метод для слияния массивов
void Merge(int[] a, int l, int m, int r)
{
    int i, j, k;

int n1 = m - l + 1;
int n2 = r - m;

int[] left = new int[n1 + 1];
int[] right = new int[n2 + 1];

for (i = 0; i < n1; i++)
{
    left[i] = a[l + i];
}

for (j = 1; j <= n2; j++)
{
    right[j - 1] = a[m + j];
}

left[n1] = int.MaxValue;
right[n2] = int.MaxValue;

i = 0;
j = 0;

for (k = l; k <= r; k++)
{
    if (left[i] < right[j])
    {
        a[k] = left[i];
        i = i + 1;
    }
    else
    {
        a[k] = right[j];
        j = j + 1;
    }
}
}
//сортировка слиянием
int[] MergeSort(int[] array,int lowIndex,int hightIndex)
{
    if (lowIndex < hightIndex)
    {
        int middleIndex = (lowIndex + hightIndex) / 2;
        MergeSort(array, lowIndex, middleIndex);
        MergeSort(array, middleIndex+1, hightIndex);
        Merge(array, lowIndex, middleIndex, hightIndex);
    }
    return array;
}

int[] MergeSortAlg(int[] array)
{
    return MergeSort(array, 0, array.Length-1);
}
Random random=new Random();
int[] mas = new int[20];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(1, 100);
}
//Console.WriteLine(string.Join(", ", mas));
//Console.WriteLine();
//Console.WriteLine(string.Join(", ", MergeSortAlg(mas)));

//Базовый уровень. 1 вариант.
//Console.WriteLine($"{Func(5)+Func(12)+Func(19):F2}");
//Средний уровень. 1 вариант.
//Console.WriteLine(ToBinary(9));
//Высокий уровень. 1 вариант.
//Console.WriteLine(Fact(5));
//Console.WriteLine(Fact2(6));
//Console.WriteLine(Fact2(7));

double Func(int i)
{
    return (Math.Sqrt(i)+i) / 2;
}
string ToBinary(int n)
{
    string res = "";
    while (n != 1)
    {
        int remainder =n % 2;
        res += remainder;
        n /= 2;
    }
    res += "1";
    char[] chars = res.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

long Fact(int n)
{
    if (n == 0 || n == 1) return 1;
    else return Fact(n - 1) * n;
}
long Fact2(int n)
{
    if (n % 2 == 0)
    {
        if (n == 2) return 2;
        else return Fact2(n-2)*n;
    }
    else
    {
        if (n == 1) return 1;
        else return Fact2(n - 2) * n;
    }
}
//Библиотеки. Вариант 1. Базовый уровень. 
//int[,] myMas = new int[7, 4];
//Random rand=new Random();
//for (int i = 0;i<myMas.GetLength(0);i++)
//{
//    for (int j = 0;j<myMas.GetLength(1);j++)
//    {
//        myMas[i, j] = rand.Next(10, 100);
//        Console.Write(myMas[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine($"Сумма индексов максимального элемента матрицы:{MyLib.Matrix.SumMaxMin(myMas)}");

//Библиотеки. Вариант 1. Средний уровень. 
double[,] myMas = new double[8, 3];
for (int i = 0; i < myMas.GetLength(0); i++)
{
    for (int j = 0; j < myMas.GetLength(1); j++)
    {
        myMas[i, j] = Math.Pow((Math.Sin(i) * Math.Sin(i) + Math.Cos(j) * Math.Cos(j)),(i-5)/(j+1))+
            7.45*Math.Tan((i-5)/(j+8));
        Console.Write($"{myMas[i, j]:F2} ");
    }
    Console.WriteLine();
}
double[] res1=MyLib.Matrix.vectorSum(myMas);
for(int i = 0;i < res1.Length;i++)
{
    Console.Write($"{res1[i]:F2} ");
}
Console.WriteLine();
Console.WriteLine($"Разность:{MyLib.Matrix.diffMas(res1):F2}");

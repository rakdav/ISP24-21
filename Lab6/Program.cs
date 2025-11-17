using System.Threading.Channels;
using System.Xml.Linq;

//int Sum(int a, int b)
//{
//    return a + b;
//}
int Sum(int a, int b)=>a+b;
void Swap(ref int a,ref int b)
{
    int temp=a; 
    a=b; 
    b=temp;
}
double Area(double R)
{
    return Math.PI*R*R;
}
long Factorial(int n)
{
    long F = 1;
    for (int i = 1; i <=n; i++)  F*= i;
    return F;
}
void getHello()
{
    Console.WriteLine("Hello, world!");
}
void getName(string name)
{
    Console.WriteLine($"Привет! Меня зовут {name}");
}
void getDate()=> Console.WriteLine($"{DateTime.Now}");
void Summa(double a, double b)=> Console.WriteLine($"{a}+{b}={a+b}");
//Необязательные параметры
void printPerson(string name,int age=1,string company = "Undefined")
{
    Console.WriteLine($"Name:{name} Age:{age} Company:{company}");
}
void SumOut(int x,int y,out int result)
{
    result = x+y;
}

void getRectangleData(in int w,in int h,out int area,out int perimetr)
{
   // w = 7;
    area = w * h;
    perimetr = (w+h)*2;
}
void Increment(ref readonly int n)
{
    //n++;
    Console.WriteLine(n);
}
void sumNumbers(params int[] numbers)
{
    int sum = 0;
    foreach(var n in numbers) sum+= n;
    Console.WriteLine(sum);
}
int sumMas(int[] mas)
{
    mas[0] = 78;
    int s = 0;
    foreach (var n in mas) s+= n;
    return s;
}
try
{
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
    int[] mas = { 1, 4, 5, 67 };
    sumNumbers(mas);
    sumNumbers(1,5,7,8,59);
    Console.WriteLine(sumMas(mas));
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

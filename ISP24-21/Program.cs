

//Console.Write("Введите ваше имя:");
//string name=Console.ReadLine();
//Console.WriteLine("Ваше имя "+name);
//Console.WriteLine("Ваше имя {0}",name);
//Console.WriteLine($"Ваше имя {name}");

//Дано расстояние в сантиметрах. Найти число полных метров в нем.
//Console.Write("Введите расстояние в сантиметрах:");
//int sm=int.Parse(Console.ReadLine());
//Console.WriteLine($"{sm} см={sm/100} м {sm%100} см");

//С начала суток прошло n секунд. Определить:
//а) сколько полных часов прошло с начала суток;
//б) сколько полных минут прошло с начала очередного часа;
//в) сколько полных секунд прошло с начала очередной минуты.
//Console.Write("Введите секунды с начала суток:");
//int n=int.Parse(Console.ReadLine());
//int h = n / 3600;
//int m = n % 3600/60;
//int s = n % 3600%60;
//Console.WriteLine($"Полных часов:{h}\n" +
//    $"Полных минут прошло с начала очередного часа:{m}\n" +
//    $"Полных секунд прошло с начала очередной минуты:{s}");

//Дан прямоугольник с размерами 543 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?
//Console.WriteLine(543/130);

//Дано двузначное число. Найти:
//а) число десятков в нем;
//б) число единиц в нем;
//в) сумму его цифр;
//г) произведение его цифр.
//Console.Write("Введите двузначное число:");
//byte n=byte.Parse(Console.ReadLine());
//Console.WriteLine($"Число десятков в нем:{n/10}");
//Console.WriteLine($"Число единиц в нем:{n%10}");
//Console.WriteLine($"Сумма цифр:{(n/10)+(n%10)}");
//Console.WriteLine($"Произведение цифр:{(n / 10)*(n % 10)}");

//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    Console.WriteLine($"{x * x}+{y * y}<=4 => {x * x + y * y <= 4}");
//    Console.WriteLine(!(x*y<0)) ;
//}
//catch(Exception e)
//{
//    Console.WriteLine("Введите корректные значения!");
//}

//{
//    int x1 = 2;
//    int x2 = 5;
//    Console.WriteLine(x1 & x2);
//    Console.WriteLine(x1 | x2);
//    Console.WriteLine(~x1);
//    Console.WriteLine(x1 ^ x2);

//    int a = 9;
//    int b = 5;
//    a = a ^ b;
//    Console.WriteLine(a);
//    b = a ^ b;
//    Console.WriteLine(b);
//    a = a ^ b;
//    Console.WriteLine(a);
//    Console.WriteLine(b);
//}
using System.Diagnostics;

try
{
    //Console.Write("Введите x:");
    //double x = double.Parse(Console.ReadLine());
    //if (x >= 0) Console.WriteLine(x);
    //else Console.WriteLine(-x);
    //Console.WriteLine((x>=0)?x:-x);
    //if (x > -5 && x < 3) Console.WriteLine("Принадлежит");
    //else Console.WriteLine("Не принадлежит");
    //Console.WriteLine("Введите двухзначное число:");
    //int a=int.Parse(Console.ReadLine());
    //if (a % 10 == 3 || a / 10 == 3) Console.WriteLine("3 входит");
    //else Console.WriteLine("3 не входит");
    //Console.Write("Введите y:");
    //double y = double.Parse(Console.ReadLine());
    //Console.Write("Введите радиус:");
    //double r = double.Parse(Console.ReadLine());
    //Console.WriteLine((x*x+y*y<=r*r)?"Принадлежит":"Не принадлежит");
    //Console.Write("Введите номер дня недели:");
    //byte n=byte.Parse(Console.ReadLine());
    //if(n==7) Console.WriteLine("Воскресенье");
    //else if (n==1) Console.WriteLine("Понедельник");
    //switch (n)
    //{
    //    case 1:Console.WriteLine("Воскресенье");break;
    //    case 2: Console.WriteLine("Понедельник"); break;
    //    case 3: Console.WriteLine("Вторник"); break;
    //    case 4: Console.WriteLine("Среда"); break;
    //    case 5: Console.WriteLine("Четверг"); break;
    //    case 6: Console.WriteLine("Пятница"); break;
    //    case 7: Console.WriteLine("Суббота"); break;
    //    default: Console.WriteLine("Нет такого дня недели"); break;
    //}
    //Console.Write("Введите номер месяца:");
    //byte n = byte.Parse(Console.ReadLine());
    //switch (n)
    //{
    //    case 12:case 1:case 2:Console.WriteLine("Зима"); break;
    //    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
    //    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
    //    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
    //    default: Console.WriteLine("Нет такого месяца"); break;
    //}
    //long n = long.Parse(Console.ReadLine());
    //if(n%100>=11&&n%100<=14) Console.WriteLine(n+" рублей");
    //else switch (n)
    //    {
    //        case 1: Console.WriteLine(n+" рубль");break;
    //        case 2:case 3:case 4: Console.WriteLine(n + " рубля"); break;
    //        default: Console.WriteLine(n+" рублей");break;
    //    }

    //Циклы
    //Вычислить n! (n вводится с клавиатуры).
    //Console.Write("Введите n:");
    //int n = int.Parse(Console.ReadLine());
    ////цикл с предусловием
    ////блок инициализации
    //long F = 1;
    //int i = 1;
    //while (i <= n)
    //{
    //    F *= i;
    //  //  if (i == 4) continue; 
    //    i++;
    //}
    //Console.WriteLine($"Факториал {n}={F}");
    ////цикл с постусловием
    //F = 1;
    //i= 1;
    //do
    //{
    //    F*=i; 
    //    i++;
    //}
    //while (i <= n);
    //Console.WriteLine($"Факториал {n}={F}");
    ////цикл for
    //F = 1;
    //for (int j = 1; j <= n; j++) F *= i;
    //Console.WriteLine($"Факториал {n}={F}");

    //Дано положительное число n. Вычислить сумму чисел от 1 до n
    //    int n;
    //    do
    //    {
    //        Console.Write("Введите n:");
    //        n=int.Parse(Console.ReadLine());
    //        if(n<=0) Console.WriteLine("Введите положительное число");
    //    }
    //    while (n<=0);
    //    int s = 0;
    //    for (int i = 0; i <= n; i++) s += i;
    //    Console.WriteLine($"s={s}");

    //Console.WriteLine("Введите числа. Введение 0 конец последовательности");
    //int count = 0;
    //double s = 0;
    //do
    //{
    //    int n=int.Parse(Console.ReadLine());
    //    if (n == 0) break;
    //    count++;
    //    s+=n;
    //}
    //while (true);
    //Console.WriteLine($"Количество чисел последоватльности:{count}, " +
    //    $"сумма чисел:{s}, среднее арифметическое:{(s/count):F2}");
    //int n, m;
    //do
    //{
    //    Console.Clear();
    //    Console.Write("Введите нижний индекс:");
    //    n = int.Parse(Console.ReadLine());
    //    Console.Write("Введите верхний индекс:");
    //    m = int.Parse(Console.ReadLine());
    //    if (n >= m) Console.WriteLine("Верхний индекс не должен быть меньше нижнего");
    //    else break;
    //}
    //while (true);
    //int s = 0;
    //for (int i = n; i <= m; i++) if(i%2!=0)s += i;
    //Console.WriteLine($"S={s}");
    //s = 0;
    //for (int i = n; i <= m; i++) {
    //    if (i % 2 == 0) continue;
    //    else s += i;
    //}
    //Console.WriteLine($"S={s}");
    //double s = 0;
    //for (double i = 1; i <= 20; i++) s += 1 / i;
    //Console.WriteLine($"s={s:F2}");
    //for (int i = 1000; i < 10000; i++)
    //{
    //    int n = i;
    //    int s = 0;
    //    while (n > 0)
    //    {
    //        s += n % 10;
    //        n /= 10;
    //    }
    //    if(s==15) Console.Write(i+" ");
    //}

    //for (int i = 1; i < 10; i++)
    //{
    //    for (int j = 1; j < 10; j++)
    //    {
    //        Console.Write($"{i}*{j}={i*j} ");
    //    }
    //    Console.WriteLine();
    //}

    //Массивы
    int[] mas1 = { 1, 5, 3, 9, 8, 7 };
    int[] mas2 = new int[5];
    //заполнение вручную
    //Console.WriteLine("Ввелите элементы массива:");
    //for (int i = 0; i < mas2.Length; i++)
    //{
    //    mas2[i] = int.Parse(Console.ReadLine());
    //}
    //foreach (int i in mas2) Console.Write(i+" ");
    //Console.WriteLine();
    //заполнение с помощью генератора случайных чисел
    //Random rnd= new Random();
    int[] mas3= new int[10];
    //for (int i = 0; i < mas3.Length; i++)
    //{
    //    mas3[i] = rnd.Next(10, 100);
    //    Console.Write(mas3[i]+" ");
    //}
    Console.WriteLine();
    //Дан целочисленный массив состоящий из 10 элементов.Элементы массива принимают значения в интервале[-7; 7]. Найдите последнее вхождение в массив элемента n(n вводится с клавиатуры).Подсчитайте количество элементов массива меньших n.
    //int[] mas4=new int[10];
    //for(int i = 0;i<mas4.Length; i++)
    //{
    //    mas4[i]=rnd.Next(-7, 8);
    //    Console.Write(mas4[i]+" ");
    //}
    //Console.WriteLine();
    //int last=-1;
    //Console.Write("Введите n:");
    //int n=int.Parse(Console.ReadLine());
    //for (int i = 0; i < mas4.Length; i++)
    //{
    //    if (mas4[i]==n) last=i;
    //}
    //Console.WriteLine($"Последнее вхождение в массив элемента {n}:{last}");
    //int less = 0;
    //for (int i = 0; i < mas4.Length; i++)
    //{
    //    if (mas4[i] <n) less++;
    //}
    //Console.WriteLine($"Количество элементов меньше {n}:{less}");

    //Дан целочисленный массив состоящий из n элементов.Элементы массива принимают значения в интервале[-10; 10]. Найдите максимальный элемент массива
    //Console.Write("Введите n:");
    //int n = int.Parse(Console.ReadLine());
    //int[] mas5 = new int[n];
    //for (int i = 0; i < mas5.Length; i++)
    //{
    //    mas5[i] = rnd.Next(-10, 11);
    //    Console.Write(mas5[i] + " ");
    //}
    //Console.WriteLine();
    //int max=mas5[0];
    //for (int i = 1; i < mas5.Length; i++)
    //{
    //    if (mas5[i]>max) max=mas5[i];
    //}
    //Console.WriteLine($"max={max}");

    //Console.WriteLine($"{Array.IndexOf(mas5,5)}");
    //Console.WriteLine($"{Array.LastIndexOf(mas5, 5)}");
    //Array.Sort( mas5 );
    //foreach (var item in mas5) Console.Write(item+" ");
    //Console.WriteLine();
    //Array.Reverse( mas5 );
    //foreach (var item in mas5) Console.Write(item + " ");
    //Console.WriteLine();

    //Найти сумму элементов одномерного массива, заданного случайным образом на интервале [-13;11;]. Размерность вводится с клавиатуры. 
    //Console.Write("Введите n:");
    //int n = int.Parse(Console.ReadLine());
    //int[] mas6 = new int[n];
    //for (int i = 0; i < mas6.Length; i++)
    //{
    //    mas6[i] = rnd.Next(-13, 12);
    //    Console.Write(mas6[i] + " ");
    //}
    //Console.WriteLine();
    //int s = 0;
    //for (int i = 0; i < mas6.Length; i++) s += mas6[i];
    //Console.WriteLine($"S={s}");

    //Сформировать и вывести на экран массив, элементы которого заданы случайным образом на интервале [-19, 26] (размерность вводится с клавиатуры). Найти произведение элементов с нечетными номерами.
    //Подсчитать количество нулей
    //Console.Write("Введите n:");
    //int n = int.Parse(Console.ReadLine());
    //int[] mas7 = new int[n];
    //Random rnd = new Random();
    //for (int i = 0; i < mas7.Length; i++)
    //{
    //    mas7[i] = rnd.Next(-19, 27);
    //    Console.Write(mas7[i] + " ");
    //}
    //Console.WriteLine();
    //int p = 1;
    //for (int i = 0; i < mas7.Length; i += 2) p *= mas7[i];
    //Console.WriteLine($"p={p}");
    //int count = 0;
    //for (int i = 0; i < mas7.Length; i ++) 
    //    if( mas7[i] == 0 ) count++;
    //Console.WriteLine($"Rоличество нулей {count}");

    //сортировка методом Пузырька
    //for (int i = 0; i < mas7.Length-1; i++)
    //{
    //    for (int j = i+1; j < mas7.Length; j++)
    //    {
    //        if (mas7[i] > mas7[j])
    //        {
    //            int temp = mas7[i];
    //            mas7[i] = mas7[j];
    //            mas7[j] = temp;
    //        }
    //    }
    //}
    //foreach (int item in mas7) Console.Write(item+" ");

    //Console.WriteLine("Введите n:");
    //double n= int.Parse(Console.ReadLine());
    //Console.WriteLine("Введите x:");
    //double x= double.Parse(Console.ReadLine());
    //double s = 0;
    //for (int i = 0; i < n; i++)
    //{
    //    double f = 1;
    //    for (int j = 1; j < 2 * i; j++) f *= j;
    //    if (i % 2 == 0) s += i*(i + 1) /(2*f);
    //    else s -= i*(i + 1) / (2*f);
    //}
    //Console.WriteLine(s);

    //Cортировка вставками
    Random rnd=new Random();
    int n=rnd.Next(10000,100000);
    int[] mas4=new int[n];
    for(int i=0; i<mas4.Length; i++)
    {
        mas4[i]=rnd.Next(10,100);
      //  Console.Write(mas4[i]+" ");
    }
    Console.WriteLine();
    int[] mas5=new int[n];
    //mas5 = mas4;
    Array.Copy(mas4, mas5,mas4.Length);
    Stopwatch stpWatch=new Stopwatch();
    stpWatch.Start();
    for (int i = 0; i < mas5.Length-1; i++)
    {
        var key = mas5[i];
        var j = i;
        while ((j > 0) && (mas5[j-1]>key))
        {
            mas5[j] = mas5[j - 1];
            j--;
        }
        mas5[j] = key;
    }
    stpWatch.Stop();
  //  foreach (var item in mas4) Console.Write(item+" ");
    Console.WriteLine("StopWatch:"+stpWatch.ElapsedMilliseconds.ToString());
    Console.WriteLine();
    int[] mas6 = new int[n];
    Array.Copy(mas4, mas6, mas6.Length);
    stpWatch.Start();
    for (int i = 0; i < mas6.Length - 1; i++)
    {
        for (int j = i + 1; j < mas6.Length; j++)
        {
            if (mas6[i] > mas6[j])
            {
                int temp = mas6[i];
                mas6[i] = mas6[j];
                mas6[j] = temp;
            }
        }
    }
    stpWatch.Stop();
    Console.WriteLine("StopWatch:" + stpWatch.ElapsedMilliseconds.ToString());
    //Сортировка выбором
    int[] mas7 = new int[n];
    Array.Copy(mas4, mas7, mas7.Length);
    stpWatch.Start();
    for (int i = 0; i < mas7.Length-2; i++)
    {
        int min = i;
        for (int j = i + 1; j < mas7.Length - 1; j++)
            if (mas7[j] < mas7[min]) min = j;
        if (min != i)
        {
            int temp = mas7[min];
            mas7[min] = mas7[i];
            mas7[i] = temp;
        }
    }
    stpWatch.Stop();
    Console.WriteLine("StopWatch:" + stpWatch.ElapsedMilliseconds.ToString());

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
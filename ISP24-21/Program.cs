// See https://aka.ms/new-console-template for more information

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
    long n = long.Parse(Console.ReadLine());
    if(n%100>=11&&n%100<=14) Console.WriteLine(n+" рублей");
    else switch (n)
        {
            case 1: Console.WriteLine(n+" рубль");break;
            case 2:case 3:case 4: Console.WriteLine(n + " рубля"); break;
            default: Console.WriteLine(n+" рублей");break;
        }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
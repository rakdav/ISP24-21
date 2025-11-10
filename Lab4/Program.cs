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

//try
//{
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
//    Random rand = new Random();
//    int[,] mas = new int[rand.Next(10, 21), 2];
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            mas[i, j] = rand.Next(-20, 21);
//            Console.Write(mas[i,j]+" ");
//        }
//        Console.WriteLine();
//    }
//    int maxX = mas[0,0], maxY=mas[0,1];
//    int minX = mas[0, 0], minY = mas[0, 1];
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        if(mas[i, 0] > maxX) maxX = mas[i, 0];
//        if(mas[i, 0] < minX) minX = mas[i, 0];
//        if(mas[i, 1] > maxY) maxY = mas[i, 1];
//        if(mas[i, 1] < minY) minY = mas[i, 1];
//    }
//    Console.WriteLine($"Центр окружности:({(maxX+minX)/2:F1};{(maxY+minY) / 2:F1})");
//    Console.WriteLine($"Радиус:{((maxX > maxY)?maxX:maxY):f2}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//    string[] people = { "Tom","Sam","Bob","Kate","Tom","Alice"};
//    Console.WriteLine(people.Length);
//  // Array.Sort(people);
//   //Array.Sort(people,1,3);
//foreach (string person in people)
//    Console.Write($"{person} ");
//Console.WriteLine();
//Console.WriteLine(Array.BinarySearch(people,"Kate"));
//string[] copyPeople=new string[3];
//Array.Copy(people, copyPeople, 3);
//foreach (string person in copyPeople)
//    Console.Write($"{person} ");
//Console.WriteLine();
//string[] human = new string[6];
//people.CopyTo(human,0);
//foreach (string person in human)
//    Console.Write($"{person} ");
//Console.WriteLine();
////people[2] = "Toma";
////Поиск индекса элемента
//Console.WriteLine(Array.IndexOf(people,"Tom"));
//Console.WriteLine(Array.LastIndexOf(people, "Tom"));
//Console.WriteLine(Array.FindIndex(people,p=>p.Length>3));
//Console.WriteLine(Array.FindLastIndex(people, p => p.Length > 3));
////Поиск элемента по условию
//Console.WriteLine(Array.Find(people, p => p.Length > 3));
//Console.WriteLine(Array.FindLast(people, p => p.Length > 3));
//string[] persons = Array.FindAll(people,p=>p.Length>3);
//foreach (string person in persons)
//    Console.Write($"{person} ");
//Console.WriteLine();
////Изменение порядка элементов массива
//Array.Reverse(people);
//foreach (string person in people)
//    Console.Write($"{person} ");
//Console.WriteLine();
//Array.Clear(people);
//foreach (string person in people)
//    Console.Write($"{person} ");
//Console.WriteLine();
//Console.WriteLine(people.Length);
//char a = 'R';
//char c = '5';
//Console.WriteLine((int)c);
//int d = 234;
//Console.WriteLine((char)d);
//Console.WriteLine(char.IsDigit(c));
//Console.WriteLine(char.IsLetter(a));
//Console.WriteLine(char.IsControl('\xA'));
//Console.WriteLine(char.MinValue);
//Console.WriteLine(char.MaxValue);
//Console.WriteLine(char.ToLower('Z'));
//Console.WriteLine(char.ToUpper('z'));
//string[] mas = {"aaa","bbb","ccc"};
//string str=string.Join(", ", mas);
//Console.WriteLine(str);
using System.Text;
using System.Text.RegularExpressions;

//string text = "А роза упала на лапу Азора";
//Console.WriteLine(text);
//string[] textMas=text.Split(' ');
//foreach (string item in textMas) Console.Write(item.ToLower());
//Console.WriteLine();
//Array.Reverse(textMas);
//foreach (string item in textMas)
//{
//    char[] array=item.ToCharArray();
//    Array.Reverse(array);
//    Console.Write(new string(array).ToLower());
//}
//Console.WriteLine();
//Console.WriteLine(text.Substring(10,6));
//string txt= text.Substring(10,6);
//Console.WriteLine(text);
//Console.WriteLine(txt);
//StringBuilder sb = new StringBuilder(text);
//sb.Append(" привет");
//Console.WriteLine(sb);
//sb.Insert(10, "Hello");
//Console.WriteLine(sb);
//sb.AppendLine("dsfdsf s efdsw");
//Console.WriteLine(sb);
//sb.Replace("dsf", "ooo");
//Console.WriteLine(sb);
//string mail1 = "rakdav@inbox.ru";
//string mail2 = "ty@mail";
//string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
//    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
//Regex r = new Regex(pattern);
//Console.WriteLine(r.IsMatch(mail1));
//Console.WriteLine(r.IsMatch(mail2));

//символьный тип. Базовый уровень. 30 вариант
//char[,] mas = new char[5, 7];
//Random random = new Random();
//for (int i = 0; i < 5; i++)
//{
//	for (int j = 0; j <7 ; j++)
//	{
//        mas[i, j] = (char)random.Next(48, 80);
//        Console.Write(mas[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//int s = 0;
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        if (char.IsDigit(mas[i,j]))
//        {
//            s += int.Parse(mas[i, j].ToString());
//        }
//    }
//}
//Console.WriteLine($"s={s}");

//символьный тип. Средний уровень. 30 вариант
//Console.Write("Введите строку:");
//string text=Console.ReadLine();
//char[] words = text.ToCharArray();
//foreach (char i in words) Console.Write(i);
//Console.WriteLine();
//Console.Write("Введите слово для поиска:");
//string word=Console.ReadLine();
//Regex red = new Regex(word);
//Match match = red.Match(text);
//int count = 0;
//while (match.Success)
//{
//    count++;
//    match = match.NextMatch();
//}
//Console.WriteLine(count);

//символьный тип. высокий уровень. 30 вариант
Console.WriteLine("Введите текст:");
string text = Console.ReadLine();
string[] masWords = text.Split('.');
string result = "";
for (int i = 0; i < masWords.Length-1; i++)
{
    string temp = masWords[i].Trim();
    string first = temp[0].ToString();
    temp=temp.Remove(0, 1);
    temp = temp.Insert(0, first.ToUpper());
    temp += ". ";
    result += temp;
}
Console.Write(result.Trim());




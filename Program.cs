using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

class MainClass
{
    static void Main()
    {
        //1
//a
        bool var1 = false;
        byte var2 = 0;
        sbyte var3 = 0;
        char var4 = 'o';
        decimal var5 = 11.123M;
        double var6 = 1.232323;
        float var7 = 1.33f;
        int var8 = -24;
        uint var9 = 24;
        nint var10 = -12;
        nuint var11 = 12;
        long var12 = -1212112;
// 1

        ulong var13 = 12312321;
        short var14 = -32768;
        ushort var15 = 64122;
        string var16 = "blabla";
        object var17 = var16;
        dynamic var18 = var17;
/*
var1 = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine(var1);
var2 = Convert.ToByte(Console.ReadLine());

Console.WriteLine(var2);
var3 = Convert.ToSByte(Console.ReadLine());

Console.WriteLine(var3);
var4 = Convert.ToChar(Console.ReadLine()!);

Console.WriteLine(var4);
var5 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(var5);
var6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(var6);
var7 = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine(var7);
var8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(var8);
var9 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine(var9);
var10 = (nint)Convert.ToInt64(Console.ReadLine());
Console.WriteLine(var10);
var11 = (nuint)Convert.ToUInt64(Console.ReadLine());
Console.WriteLine(var11);
var12 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine(var12);
var13 = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine(var13);
var14 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(var14);
var15 = Convert.ToUInt16(Console.ReadLine());
Console.WriteLine(var15);
var16 = Console.ReadLine()!;
Console.WriteLine(var16);
Console.WriteLine(var1);
Console.WriteLine(var2);
*/
// b
// Неявное

        var11 = var4; // char to nuint
        var12 = var3; // sbyte to long
        var10 = var3; // sbyte to nint
        var13 = var9; // uint to ulong
        var14 = var2; // byte to short

// Явное

        var4 = (char)var11;
        var3 = (sbyte)var12;
        var3 = (sbyte)var10;
        var9 = (uint)var13;
        var4 = (char)var3;

// Convert

        string va1 = Convert.ToString(var11);
        char va2 = Convert.ToChar(var9);
        double va3 = Convert.ToDouble(var10);

// Boxing (c)

        object ovar11 = var11;
        object ovar12 = (object)var12;
        var12 = (long)ovar12;
        Console.WriteLine(String.Concat("was ", var11));
        var11 = 12312;
        var11 = (nuint)ovar11;
        Console.WriteLine(String.Concat("became ", var11));
// d
        var asd = "asdas";
        Console.WriteLine($"{asd}");
        Console.WriteLine(asd.GetType().ToString());
// Nullable (e)
        int? a = null;
        a = 23;
        Console.WriteLine(a);
// f
        var vv = "asda";
//vv = 12;

// 2) Строки
// a
// сравнение происходит лексикографически в обратном порядке
        string lit1 = "agaga";
        string lit2 = "zbajbjhb";
        Console.WriteLine("Comparing lit1 gaga and abasdas: ");
        Console.WriteLine(String.Compare(lit1, lit2));
        Console.WriteLine();
// b
        string str1 = "stroke";
        string str2 = "phantom";
        string str3 = "first second third";
        string str4 = "";

        str4 = String.Concat(str1, str2); // Сцепление
        Console.WriteLine(str4);
        Console.WriteLine();
        string g = str1.Insert(2, str2.Substring(3)); // Вставка подстроки в заданнаю позицию
        Console.WriteLine(g);
        Console.WriteLine();

        string str11 = str1.Clone() as string;
        Console.WriteLine(str11); // Копирование

        str2 = str3.Substring(3); // Выделение подстроки
        Console.WriteLine(str2);


        foreach (string str in str3.Split(' ')) Console.WriteLine(str); // Разделение строки на слова

        Console.WriteLine($"Интерполяиця {var11}");
        // c
        string pustaya = String.Empty;
        string? nullstr = null;

        if (string.IsNullOrEmpty(pustaya)) Console.WriteLine("pustaya is pustaya");
        if (string.IsNullOrEmpty(nullstr)) Console.WriteLine("nullstr is null");

// d
        StringBuilder sb = new StringBuilder("SB", 20);
        sb.Append("SOME STRING");
        sb.Remove(3, 2);
        sb.Insert(0, "start");
        sb.Append("end");
        Console.WriteLine(sb);

// Массивы
// a
        int[,] darr = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 }, { 9, 10, 11 } };
        for (int i = 0; i < darr.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < darr.GetLength(1); j++)
            {
                Console.Write(darr[i, j]);
                Console.Write(" ");
            }
        }

// b
        Console.WriteLine();
        string[] mess = { "first", "second", "third", "fourth" };
        foreach (string s in mess) Console.WriteLine(s);


        Console.WriteLine(mess.GetLength(0));
        Console.WriteLine("Enter position in 1st dimension: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter position in 2nd dimension: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        mess[x] = mess[x].Replace(mess[x][y], Convert.ToChar(Console.ReadLine()));
        foreach (string s in mess) Console.WriteLine(s);
// c
        double[][] zub = new double [3][];
        zub[0] = new double[2];
        zub[1] = new double[3];
        zub[2] = new double[4];
        for (int i = 0; i < zub.Length; i++)
        {
            for (int j = 0; j < zub[i].Length; j++)
                zub[i][j] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine();
        foreach (double[] row in zub)
        {
            foreach (double item in row)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }

// d
        var assd = new object[] { new[] { 1, 2, 3, 4 }, "sdsd", "asdas" };

// 4)
// a
        (int, string, char, string, ulong) cor = (-121, "23", 'f', "asdasda", 12);
// b
        Console.WriteLine(cor);
        Console.WriteLine(cor.Item1);
        Console.WriteLine(cor.Item3);
        Console.WriteLine(cor.Item4);
// c
        int first;
        string second;
        char third;
        string fourth;
        ulong fifht;
        first = cor.Item1;
        second = cor.Item2;
        third = cor.Item3;
        fourth = cor.Item4;
        fifht = cor.Item5;
        (var first1, var second1, var third1, var fourth1, var fifht1) = cor;
        (_, _, _, string sss, var fff) = cor;
// d 
        (int anum, string aanum1, char aanum2, string aanum3, ulong aanum4) cor1 = (-121, "23", 'f', "asdasda", 12);
        Console.WriteLine(cor == cor1);

// 5

            (int,int,int,char) sum(int[] arr, string str)
            {
                    return (arr.Max(), arr.Min(), arr.Sum(), str.First());
            }

            Console.WriteLine(sum([4,2,1,-23,222],"fadasdas"));
            
            // 6

            int f1(int n)
            {
                    checked
                    {
                            int max = int.MaxValue;
                            max += n;
                            return max;
                    }
            }
            int f2(int n)
            {
                    unchecked
                    {
                            int max = int.MaxValue;
                            max += n;
                            return max;
                    }
            }
            Console.WriteLine(f1(2)); // overflow exception
            Console.WriteLine(f2(2)); // -214743647
    }
}
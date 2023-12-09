using System;

namespace sayfa80odev
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("b sayısını gır");
            int b = Convert.ToInt32(Console.ReadLine());//b sayısını kullanıcıdan ıstemımı ıstedı odev
            int a;
            String s = "b Sayısı Asal Sayı";
            if (b == 1) { Console.WriteLine("ASAL DEĞİL!"); goto bitir; }
            for (a = 2; a <= b / 2; a++)
            {
                if (b % a == 0)
                {
                    s = "b Sayısı Asal Sayı Değil!";
                    break;
                }
            }
            Console.WriteLine(s);
        bitir: Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);

        }
    }
}
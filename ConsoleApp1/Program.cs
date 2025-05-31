namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] harfNotu = {"A","B","C","D","E","KALDIN"};
            Console.WriteLine("ognreci notunu giriniz");
            int ogrenciNotu = Convert.ToInt32(Console.ReadLine());

            if (ogrenciNotu <= 50)
            { Console.WriteLine(harfNotu[5]); }
            else if (ogrenciNotu <= 60 && ogrenciNotu >= 50)
            { Console.WriteLine(harfNotu[4]); }
            else if (ogrenciNotu <= 70 && ogrenciNotu >= 60)
            { Console.WriteLine(harfNotu[3]); }
            else if (ogrenciNotu <= 80 && ogrenciNotu >= 70)
            { Console.WriteLine(harfNotu[2]); }
            else if (ogrenciNotu <= 90 && ogrenciNotu >= 80)
            { Console.WriteLine(harfNotu[1]); }
            else if (ogrenciNotu <= 100 && ogrenciNotu >= 90)
            { Console.WriteLine(harfNotu[0]); }
            else
            { Console.WriteLine("0-100 arasında bir sayı giriniz"); }
        }
    }
}

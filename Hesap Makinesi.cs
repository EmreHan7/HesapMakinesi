using System;

namespace Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                hesapMakinesi();
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim==1)
                {
                    toplamaIslemi(degerAlma1(), degerAlma2());
                }
                if (secim==2)
                {
                    cikarmaIslemi(degerAlma1(), degerAlma2());
                }
                if (secim==3)
                {
                    carpmaIslemi(degerAlma1(), degerAlma2());
                }
                if (secim==4)
                {
                    bolmeIslemi(degerAlma1(), degerAlma2());
                }
                if (secim==5)
                {
                    modAlmaIslemi(degerAlma1(), degerAlma2());
                }
                if (secim==6)
                {
                    kareAlmaIslemi(degerAlma1());
                }




            }
        }
        static void toplamaIslemi(double sayi1, double sayi2)
        {
            double topla = sayi1 + sayi2;
            Console.WriteLine("Sayıların Toplamı ; " + topla);
        }
        static void cikarmaIslemi(double sayi1, double sayi2)
        {
            double topla = sayi1 - sayi2;
            Console.WriteLine("Çıkarma İşlemi Sonucu ; " + topla);
        }
        static void carpmaIslemi(double sayi1, double sayi2)
        {
            double topla = sayi1 * sayi2;
            Console.WriteLine("Sayıların çarpımı ; " + topla);
        }
        static void bolmeIslemi(double sayi1, double sayi2)
        {
            double topla = sayi1 / sayi2;
            Console.WriteLine("Sayıların Bölümü ; " + topla);
        }
        static void modAlmaIslemi(double sayi1, double sayi2)
        {
            double topla = sayi1%sayi2;
            Console.WriteLine("Sayıların Modu ; " + topla);
        }
        static void kareAlmaIslemi(double sayi1)
        {
            double topla = sayi1 * sayi1;
            Console.WriteLine("Sayının karesi ; " + topla);
        }
        static double degerAlma1()
        {
            Console.Write("Lütfen Bir Sayı Giriniz : ");
            double deger1 = Convert.ToDouble(Console.ReadLine());
            return deger1;
        }
        static double degerAlma2()
        {
            Console.Write("Lütfen Bir Sayı Giriniz : ");
            double deger2 = Convert.ToDouble(Console.ReadLine());
            return deger2;
        }
        static void hesapMakinesi()
        {
            Console.WriteLine("Hangi İşlemi Yapmak istersiniz ? ");
            Console.WriteLine("1- Toplama ");
            Console.WriteLine("2- Çıkarma ");
            Console.WriteLine("3- Çarpma ");
            Console.WriteLine("4- Bölme ");
            Console.WriteLine("5- Mod alma");
            Console.WriteLine("6- Karesini Alma ");
        }
    }

}

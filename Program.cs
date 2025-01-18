using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if yapısında aynı anda bakılması gereken şart birden fazla olursa or yada And yapısı kullanılır
            // Or yapısı || ile sağlanır
            // And yapısı && ile sağlanır
            // Not yapısı ! ile sağlanır
            // kullanıcının girdiği ad ve şifre doğru ise hoşgeldin yazdır
            // değilse hatalı giriş yazdır
            // while döngüsü  ile kullanıcıdan ad ve şifre iste
                        // string ad = "mustafa";
            // string sifre = "1234";
            // bool loginSuccess = false;

            // while (!loginSuccess)
            // {
            //     Console.WriteLine("Adınızı giriniz");
            //     string adGirilen = Console.ReadLine();
            //     Console.WriteLine("Şifrenizi giriniz");
            //     string sifreGirilen = Console.ReadLine();

            //     if (ad == adGirilen && sifre == sifreGirilen)
            //     {
            //         Console.WriteLine("Hoşgeldin");
            //         loginSuccess = true;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Hatalı giriş, lütfen tekrar deneyiniz");
            //     }
            // }

            // Console.ReadLine();
            


            // go to yapısı
            string ad1 = "mustafa";
            string sifre1 = "1234";
            bool loginSuccess1 = false;

            go:
            Console.WriteLine("Adınızı giriniz");
            string adGirilen1 = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz");
            string sifreGirilen1 = Console.ReadLine();

            if (ad1 == adGirilen1 && sifre1 == sifreGirilen1)
            {
                Console.WriteLine("Hoşgeldin");
                loginSuccess1 = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş, lütfen tekrar deneyiniz");
                goto go;
            }


        }
    }
}
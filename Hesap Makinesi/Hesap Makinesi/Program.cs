using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "İBRAHİM NAKAŞ";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
           
                Console.WriteLine("Toplama İşlemi İçin +");
                Console.WriteLine("Çıkarma İşlemi İçin -");
                Console.WriteLine("Çarpma İşlemi İçin *");
                Console.WriteLine("Bölme İşlemi İçin /");

                Console.Write("1.değeri girin : ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.değeri girin : ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = 0;
                Console.Write("Seçimiz...:");
                char secim = Convert.ToChar(Console.ReadLine());

                try
                {
                        if (secim == '+')
                        {
                           sonuc = sayi1 + sayi2;
                            Console.WriteLine("Toplama işleminin sonucu : " + sonuc);
                        }
                        else if (secim == '-')
                        {
                            sonuc = sayi1 - sayi2;
                            Console.WriteLine("Çıkarma işleminin sonucu : " + sonuc);
                        }
                        else if (secim == '*')
                        {
                             sonuc = sayi1 * sayi2;
                            Console.WriteLine("Çarpma işleminin sonucu : " + sonuc);
                        }
                        else if (secim == '/')
                        {
                           sonuc = sayi1 / sayi2;
                           Console.WriteLine("Bölme işleminin sonucu : " + sonuc);
                            
                        }
                        else
                        {
                            Console.WriteLine(" Farklı Bir İşaretçi Girdiniz... ");
                        }
                    

                }
                catch (DivideByZeroException )
                {
                    Console.WriteLine("Sıfır ile bölme işlemi tespit edildi");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Girdiğiniz değer maximum değerin üzerinde olduğu için işlem gerçekleştirilemedi.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Girdiğiniz veri sayı değildir. Lütfen sayı giriniz.");
                }

            Console.ReadKey();
        }
    }
}

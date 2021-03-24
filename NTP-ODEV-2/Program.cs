using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kaç öğrenci kayıt etmek istiyorsunuz? ");
            byte kayits = byte.Parse(Console.ReadLine());

            String[,] ogrenciler = new string[kayits + 1, 6];

            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ortalama";
            ogrenciler[0, 5] = "Harf Notu";

            int vize, final;
            int vize_c, final_c;
            int BV, BF;
            int toplam = 0;

            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {

                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {




                    while (i == 0 && j == 0) ;
                    {
                        Console.WriteLine("\nAd giriniz:");
                        ogrenciler[i, j] = Console.ReadLine();

                    }
                    while (i == 0 && j == 1) ;
                    {
                        Console.WriteLine("\nSoyad giriniz. ");
                        ogrenciler[i, j] = Console.ReadLine();
                    }
                    while (i == 0 && j == 2) ;
                    {
                        Console.WriteLine("\nVize notu giriniz: ");
                        vize = Convert.ToInt32(Console.ReadLine());
                        ogrenciler[i, j] = Console.ReadLine();
                        vize_c = vize * 40;
                        BV = vize_c / 100;
                    }
                    while (i == 0 && j == 3) ;
                    {
                        Console.WriteLine("\nFinal notu giriniz: ");
                        final = Convert.ToInt32(Console.ReadLine());
                        ogrenciler[i, j] = Console.ReadLine();
                        final_c = final * 60;
                        BF = final_c / 100;
                    }


                    while (i == 0 && j == 4) ;
                    {
                        toplam = BF + BV;
                        Console.WriteLine("\nOrtalama: {0}", toplam);
                    }

                    while (i == 0 && j == 5) ;
                    {

                        if (toplam <= 100 && toplam >= 80)
                        {
                            Console.WriteLine("\nHarf notunuz: AA");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        }

                        else if (toplam <= 80 && toplam >= 70)
                        {
                            Console.WriteLine("\nHarf notunuz: BA");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        }

                        else if (toplam <= 70 && toplam >= 60)

                        {
                            Console.WriteLine("\nHarf notunuz: BB");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        }

                        else if (toplam <= 60 && toplam >= 50)
                        {
                            Console.WriteLine("\nHarf notunuz: CB");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        }

                        else if (toplam <= 50 && toplam >= 45)
                        {
                            Console.WriteLine("\nHarf notunuz: CC");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        }

                        else if (toplam <= 45 && toplam >= 35)
                        {
                            Console.WriteLine("\nHarf notunuz: DC");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        }

                        else if (toplam <= 35 && toplam >= 25)
                        {
                            Console.WriteLine("\nHarf notunuz: DD");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        }

                        else if (toplam <= 25 && toplam >= 15)
                        {
                            Console.WriteLine("\nHarf notunuz: FD");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        }

                        else if (toplam <= 15 && toplam >= 00)
                        {
                            Console.WriteLine("\nHarf notunuz: FF");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;
                        }
                    }

                    for (int i = 1; i < ogrenciler.GetLength(0); i++)
                    {
                        for (int j = 0; j < ogrenciler.GetLength(1); j++)
                        {
                            Console.WriteLine(ogrenciler[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                }
            }

            Console.ReadKey();

        }
    }
}

using System;

namespace UygulamaProjesi
{
    class Program
    {
        static void Main(string[] args) //kullaniciya seceneklerimizi sunuyoruz
        {
            Console.WriteLine("Hoş geldiniz! Lütfen bir program seçiniz:");
            Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
            Console.WriteLine("2 - Hesap Makinesi");
            Console.WriteLine("3 - Ortalama Hesaplama");

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    RastgeleSayiOyunu();
                    break;
                case 2:
                    HesapMakinesi();
                    break;
                case 3:
                    OrtalamaHesaplama();
                    break;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    break;
            }
        }

        static void RastgeleSayiOyunu() 
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 101); // 1 ile 100 arasında bir sayı
            int tahmin;
            int hak = 5;

            Console.WriteLine("Bilgisayar 1 ile 100 arasında bir sayı seçti. Bu sayıyı tahmin etmeye çalışın.");

            while (hak > 0) //kullanicinin tahmin yapması icin dongu
            {
                Console.Write("Tahmininizi girin: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                hak--; // her tahminde hak bir azalir

                if (tahmin == sayi)
                {
                    Console.WriteLine("Tebrikler, doğru tahmin ettiniz!");
                    break;
                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("Daha küçük bir sayı deneyin.");
                }
                else
                {
                    Console.WriteLine("Daha büyük bir sayı deneyin.");
                }

                Console.WriteLine($"Kalan tahmin hakkınız: {hak}");

                if (hak == 0)
                {
                    Console.WriteLine($"Üzgünüm, hakkınız bitti. Doğru sayı: {sayi}");
                }
            }
        }

        static void HesapMakinesi()
        {
            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+, -, *, /): ");
            char islem = Convert.ToChar(Console.ReadLine());

            double sonuc = 0;
            bool hata = false;

            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Hata: Sıfıra bölme işlemi yapılamaz."); //sifira bolunme sorunu
                        hata = true;
                    }
                    else
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçtiniz.");
                    hata = true;
                    break;
            }

            if (!hata)
            {
                Console.WriteLine($"Sonuç: {sonuc}");
            }
        }

        static void OrtalamaHesaplama()
        {
            double[] notlar = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1}. dersi notunu giriniz (0-100): ");
                notlar[i] = Convert.ToDouble(Console.ReadLine());

                if (notlar[i] < 0 || notlar[i] > 100) //notun gecerliligi
                {
                    Console.WriteLine("Hatalı not girdiniz. Notlar 0 ile 100 arasında olmalıdır.");
                    return;
                }
            }

            double ortalama = (notlar[0] + notlar[1] + notlar[2]) / 3;

            Console.WriteLine($"Ortalamanız: {ortalama}");

            if (ortalama >= 90)
                Console.WriteLine("Harf Notu: AA");
            else if (ortalama >= 85)
                Console.WriteLine("Harf Notu: BA");
            else if (ortalama >= 80)
                Console.WriteLine("Harf Notu: BB");
            else if (ortalama >= 75)
                Console.WriteLine("Harf Notu: CB");
            else if (ortalama >= 70)
                Console.WriteLine("Harf Notu: CC");
            else if (ortalama >= 65)
                Console.WriteLine("Harf Notu: DC");
            else if (ortalama >= 60)
                Console.WriteLine("Harf Notu: DD");
            else if (ortalama >= 55)
                Console.WriteLine("Harf Notu: FD");
            else
                Console.WriteLine("Harf Notu: FF");
        }
    }
}

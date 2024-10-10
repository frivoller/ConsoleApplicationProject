using System;

class HesapMakinesi
{
    static void Main()
    {
        // kullanicidan ilk sayi alma
        Console.Write("İlk sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        // kullanicidan ikinci sayiyi alma
        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        // islem secimi
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
        Console.WriteLine("Toplama için +");
        Console.WriteLine("Çıkarma için -");
        Console.WriteLine("Çarpma için *");
        Console.WriteLine("Bölme için /");
        char islem = Convert.ToChar(Console.ReadLine());

        // secilen isleme gore islemi gerceklestirme
        if (islem == '+')
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
        }
        else if (islem == '-')
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
        }
        else if (islem == '*')
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
        }
        else if (islem == '/')
        {
            // Bolme isleminde sifira bolme kontrolu
            if (sayi2 == 0)
            {
                Console.WriteLine("Hata: Sıfıra bölme yapılamaz!");
            }
            else
            {
                double sonuc = (double)sayi1 / sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
        }
        else
        {
            Console.WriteLine("Geçersiz bir işlem seçtiniz.");
        }
    }
}

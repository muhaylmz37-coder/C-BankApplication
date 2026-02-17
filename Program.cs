using System;

class BankaHesabi
{
    public string HesapSahibi { get; set; }
    public double Bakiye { get; private set; }

    public BankaHesabi(string ad, double baslangicBakiye)
    {
        HesapSahibi = ad;
        Bakiye = baslangicBakiye;
    }

    public void ParaYatir(double miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"{miktar} TL yatırıldı.");
    }

    public void ParaCek(double miktar)
    {
        if (miktar <= Bakiye)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi.");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }

    public void BakiyeGoster()
    {
        Console.WriteLine($"Güncel Bakiye: {Bakiye} TL");
    }
}

class Program
{
    static void Main()
    {
        BankaHesabi hesap = new BankaHesabi("Muhammed", 1000);

        while (true)
        {
            Console.WriteLine("\n1- Para Yatır");
            Console.WriteLine("2- Para Çek");
            Console.WriteLine("3- Bakiye Görüntüle");
            Console.WriteLine("4- Çıkış");
            Console.Write("Seçiminiz: ");

            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.Write("Miktar: ");
                double miktar = Convert.ToDouble(Console.ReadLine());
                hesap.ParaYatir(miktar);
            }
            else if (secim == 2)
            {
                Console.Write("Miktar: ");
                double miktar = Convert.ToDouble(Console.ReadLine());
                hesap.ParaCek(miktar);
            }
            else if (secim == 3)
            {
                hesap.BakiyeGoster();
            }
            else if (secim == 4)
            {
                break;
            }
        }
    }
}

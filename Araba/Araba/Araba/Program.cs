using System;

class Araba
{
    private string marka;
    private string model;
    private string renk;
    private int yil;
    private int hiz;
    private string yakit;
    private string saseNumarasi;
    private decimal fiyat;
    private int kilometre;

    public string Marka
    {
        get { return marka; }
        set { marka = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Renk
    {
        get { return renk; }
        set { renk = value; }
    }

    public int Yil
    {
        get { return yil; }
        set { yil = value; }
    }


    public int Hiz
    {
        get { return hiz; }
        set { hiz = value; }
    }

    public string Yakit
    {
        get { return yakit; }
        set { yakit = value; }
    }

    public string SaseNumarasi
    {
        get { return saseNumarasi; }
        set { saseNumarasi = value; }
    }

    public decimal Fiyat
    {
        get { return fiyat; }
        set { fiyat = value; }
    }

    public int Kilometre
    {
        get { return kilometre; }
        set { kilometre = value; }
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine("Araba Markası: " + Marka);
        Console.WriteLine("Araba Modeli: " + Model);
        Console.WriteLine("Araba Rengi: " + Renk);
        Console.WriteLine("Üretim Yılı: " + Yil);
        Console.WriteLine("Hızı: " + Hiz + " km/saat");
        Console.WriteLine("Yakıt Türü: " + Yakit);
        Console.WriteLine("Şase Numarası: " + SaseNumarasi);
        Console.WriteLine("Fiyatı: " + Fiyat + " TL");
        Console.WriteLine("Kilometresi: " + Kilometre + " km");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Araba araba1 = new Araba();

        araba1.Marka = "Toyota";
        araba1.Model = "Corolla";
        araba1.Renk = "Siyah";
        araba1.Yil = 2022;
        araba1.Hiz = 180;
        araba1.Yakit = "Benzin";
        araba1.SaseNumarasi = "ABC123";
        araba1.Fiyat = 150000;
        araba1.Kilometre = 5000;

        araba1.BilgileriYazdir();
    }
}

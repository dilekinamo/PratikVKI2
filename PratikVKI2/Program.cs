public class Program { 
    
    struct Hasta    
    {   
        public string ad="";
        public string soyad="";
        public static double boy=1;
        public static double kilo=0;
        public static double vki = (kilo / (boy * boy)*10000);
        public string teshis = Teshis(vki);

       

        public static string Teshis(double vki)
        {
            if (vki < 30 && vki >= 25)
                return "HAFİF KİLOLU ->SARI";
            else if (vki < 25 && vki >= 18.5)
                return "NORMAL -> YEŞİL";
            else if (vki >= 30)
                return "OBEZ -> KIRMIZI";
            else if (vki < 18.5)
                return "ZAYIF -> SARI";
            else
                return "";
        }
        public void EkranaYaz()
        {
            Console.Write("Hasta: ");
            Console.WriteLine($"{ad} {soyad}; boyu: {boy/100}, kilosu: {kilo}, VKI indeksi: {vki}, Teşhis: {teshis}");
        }
    }

    public static void Main() {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1. Yeni Hasta Hesabı\n2. Hasta Hesap Listesi\n3. Çıkış");
        MenuSelection();
    }

    static void YeniHasta()
    {
        Hasta h;

        Console.Write("Hasta Adı :");
        h.ad = Console.ReadLine();
        Console.Write("Hasta Soyadı :");
        h.soyad = Console.ReadLine();
        Console.Write("Hastanin Boyu (cm): ");
        h.boy = Convert.ToDouble(Console.ReadLine());
        Console.Write("Hastanin Kilosu: ");
        h.kilo = Convert.ToDouble(Console.ReadLine());
        h.EkranaYaz();


        //Hasta: Ahmet Bircan; boyu: 1.73, kilosu: 70, VKI indeksi: 25, Teşhis: Hafif Kilol
        //Again();
    }
    static void MenuSelection()
    {
        Console.Write("Yapılacak işlemi seçin : ");
        string choose = Console.ReadLine();
        switch (choose)
        {
            case "1":
                YeniHasta();
                break;
            case "2":
                //HastalariListele();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Hatalı seçim. Tekrar Deneyin.");
                MenuSelection();//Recursive
                break;

        }
    }
}

//Hasta: Ahmet Bircan; boyu: 1.73, kilosu: 70, VKI indeksi: 25, Teşhis: Hafif Kilolu

//gelen hastaların ad, soyad, boy ve kilo bilgilerini alıp VKI ‘lerini hesaplamaları 

//VKİ 18,4 ve altı- ZAYIF -> SARI
//VKİ 18,5 - 24,9 arası NORMAL -> YEŞİL 
//VKİ 25 - 29,9 arası ise HAFİF KİLOLU ->SARI
//VKİ 30 ve fazlası OBEZ -> KIRMIZI

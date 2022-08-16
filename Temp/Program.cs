namespace Temp
{
    internal class Program
    {
        struct Hasta
        {
            public string ad;
            public string soyad;
            public double boy;
            public double kilo;
            
            public double VKIHesapla()
            {
                return (kilo / (boy * boy) * 10000);
            }

            static string Teshis(double vki)
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
                Console.WriteLine($"{ad} {soyad}; boyu: {boy}cm, kilosu: {kilo}kg, VKI indeksi: {Math.Round(VKIHesapla(),2)}, Teşhis: {Teshis(VKIHesapla())}");
            }
        }
        static List <Hasta> HastaList = new List<Hasta>();
        static void Main()
        {
            Console.Title = "VKI (vücut kitle indeksi) hesaplama";
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Yeni Hasta Hesabı\n2. Hasta Hesap Listesi\n3. Çıkış\n");
            MenuSelection();
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
                    HastalariListele();
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

        static void HastalariListele()
        {
            Console.Clear();
            foreach(var hasta in HastaList)
            {
                hasta.EkranaYaz();
                Console.WriteLine("------------------------------------------------------------------------------------");
            }
            Console.WriteLine();
            Tekrar();
        }

        public static void YeniHasta()
        {
            Hasta h;
            Console.Write("\nHasta Adı :");
            h.ad = Console.ReadLine();
            Console.Write("Hasta Soyadı :");
            h.soyad = Console.ReadLine();
            Console.Write("Hastanin Boyu (cm): ");
            h.boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hastanin Kilosu: ");
            h.kilo = Convert.ToDouble(Console.ReadLine());
            HastaList.Add(h);
            Console.WriteLine();
            h.EkranaYaz();
            Console.WriteLine();
            Tekrar();
        }

        private static void Tekrar()
        {
            Console.WriteLine("Menüye dönmek için ENTER");
            Console.ReadLine();
            Menu();
        }
    }
}
using System;

namespace koleksiyon_soruları_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] girilenler = new int[20];
            Console.WriteLine("Lütfen 20 adet sayı girin.");
            for (int i = 0; i < 20; i++)
            {
            bas:
                Console.Write("{0}.sayı = ", i + 1);
                string girdi = Console.ReadLine();
                int numara;
                bool dogru = int.TryParse(girdi, out numara);
                if (dogru && numara >= 0)
                {
                    girilenler[i] = numara;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız.Lütfen tekrar giriniz");
                    goto bas;
                }
            }
            Array.Sort(girilenler);
            Array.Reverse(girilenler);
            int toplamBuyuk = girilenler[0] + girilenler[1] + girilenler[2];
            int toplamKucuk = girilenler[19] + girilenler[18] + girilenler[17];
            int KucukOrt = toplamKucuk / 3;
            int BuyukkOrt = toplamBuyuk / 3;
            Console.WriteLine("En büyük 3 sayının toplamı   :{0}",toplamBuyuk);
            Console.WriteLine("En küçük 3 sayının toplamı   :{0}",toplamKucuk);
            Console.WriteLine("En büyük 3 sayının ortalaması:{0}",BuyukkOrt);
            Console.WriteLine("En küçük 3 sayının ortalaması:{0}",KucukOrt);
            Console.WriteLine("Ortalamaların toplamı        :{0}",(BuyukkOrt+KucukOrt));
        }
    }
}

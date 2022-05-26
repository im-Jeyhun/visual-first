using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int aligaAge = 16;
            int jeyhunAge = 21;
            int zulfuAge = 19;
            int elnurAge = 21;

            float totalAge = aligaAge + jeyhunAge + zulfuAge + elnurAge;
            float totalAge2 = totalAge / 4;
            Console.WriteLine(totalAge2);


            string jeyhunInfo = "Hajizada Jeyhun 21 Age";
            Console.WriteLine(jeyhunInfo);
            bool yas18 = true;
            Console.WriteLine(yas18);

            int iphonexQiymeti = 1500;
            int iphone12Qiymeti = 1200;
            int iphone13Qiymet = 700;
            int iphone8Qiymet = 400;

            float totalPrice = iphonexQiymeti + iphone12Qiymeti - iphone13Qiymet - iphone8Qiymet;
            Console.WriteLine(totalPrice);

            int sinifA = 4;
            int sinifB = 5;
            int sinifC = 10;
            float sinifD = 3;

            float totalHuman = sinifA * sinifB * sinifC / sinifD;

            Console.WriteLine(totalHuman);

            int elovsetAge = 80;
            int ravanAge = 12;

            float humansAges = elovsetAge % ravanAge;
            Console.WriteLine(humansAges);

        }
    }
}

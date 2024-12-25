using System;

class Program
{
    static void Main(string[] args)
    {
        //1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }

        //2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
        for (int i = 1; i < 21; i++)
        {
            Console.WriteLine(i);
        }

        //3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.Yalnızca forla:
        for (int i = 2; i < 21; i += 2)
        {
            Console.WriteLine(i);
        }

        /*
         for (int i = 1; i < 21; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        */

        //4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
        int toplam = 0;
        for (int i = 50; i < 151; i++)
        {
            toplam += i;
        }
        Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

        //5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.Yalnızca forla daha sade:

        int toplamCift2 = 0;
        int toplamTek2 = 0;
        for (int i = 1; i < 121; i += 2)
        {
            toplamCift2 += i + 1;
            toplamTek2 += i;
        }
        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {toplamCift2}");
        Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {toplamTek2}");

        /*
        5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
        int toplam2 = 0;
        for (int i = 1; i < 121; i++)
        {
            if (i % 2 == 0)
            {
                toplam2 += i;
            }

        }
        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {toplam2}");

        int toplam3 = 0;
        for (int i = 1; i < 121; i++)
        {
            if (i % 2 == 1)
            {
                toplam3 += i;
            }
        }
        Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {toplam3}");

        5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız. Daha sade hali:

        int toplamCift = 0;
        int toplamTek = 0;

        for (int i = 1; i < 121; i++)
        {
            if (i%2==0)
            {
                toplamCift += i;
            }else
            {
                toplamTek += i;
            }
        }
        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {toplamCift}");
        Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {toplamTek}");

        5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.Yalnızca forla:

        int toplam4 = 0;
        for (int i = 2; i < 121; i += 2)
        {
            toplam4 += i;
        }
        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {toplam4}");

        int toplam5 = 0;
        for (int i = 1; i < 121; i += 2)
        {
            toplam5 += i;
        }
        Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {toplam5}");
        */
    }
}
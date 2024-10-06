#region 1.AŞAMA
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
#endregion
Console.WriteLine();
#region 2.AŞAMA
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}
#endregion
Console.WriteLine();
#region 3.AŞAMA
for (int i = 1; i <= 20; i ++)
{
    if (i % 2 == 0)//çift sayıları yazdırmak için for dögüsünün içinde if ile çift sayıları aldık
    {
        Console.WriteLine(i);
    }
}
#endregion
Console.WriteLine();
#region 4.AŞAMA
int toplam = 0; //toplamları için değişken belirledik
for (int i = 50; i <= 150; i ++ )
{
    toplam += i;//toplam = toplam + i her seferinde toplamı bir sonraki i değeri ile toplar
}
#endregion
Console.WriteLine();
#region 5.AŞAMA
int tekToplam = 0; // tek sayıların ve çift sayıların toplamı için iki farklı değişken belirlenir
int ciftToplam = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)//çift sayıları yazdırmak için for dögüsünün içinde if ile çift sayıları aldık
    {
        ciftToplam += i; //toplam = toplam + i her seferinde toplamı bir sonraki i değeri ile toplar
    }
    else//tek sayıları yazdırmak için for dögüsünün içinde else ile tek sayıları aldık
    {
        tekToplam += i; //toplam = toplam + i her seferinde toplamı bir sonraki i değeri ile toplar
    }
}

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);
#endregion



Console.ReadKey();



using System;

public class Mittauksia
{
    public static void Main()
    {
        string muoto = "{0:F5}";
        Console.WriteLine(muoto, Etaisyys(-1.5, -2.5, 3, 3.5));
        Console.WriteLine(muoto, Etaisyys(0, 0, 1, 1));
        Console.WriteLine(muoto, Etaisyys(0, 0, 0, 1));
        Console.WriteLine(muoto, Etaisyys(3, 0, 0, 4));
        Console.WriteLine(muoto, Etaisyys(-1.5, 1.1, 2.7, -9.2));
    }
    // BYCODEBEGIN
    /// <summary>
    /// aliohjelma laskee kahden kaksiulotteisen pisteen etäisyyden toisistaan.
    /// </summary>
    /// <param name="x1">piste1 x-akseli</param>
    /// <param name="y1">piste1 y-akseli</param>
    /// <param name="x2">piste2 x-akseli</param>
    /// <param name="y2">piste2 y-akseli</param>
    /// <returns>palauttaa kahden pisteen etäisyyden</returns>
    public static double Etaisyys(double x1, double y1, double x2, double y2)
    {
        double kateettiX = Math.Abs(x1 - x2);
        double kateettiY = Math.Abs(y1 - y2);
        double etaisyys = Math.Sqrt(kateettiX * kateettiX + kateettiY * kateettiY);
        return etaisyys;
    }
    // BYCODEEND
}
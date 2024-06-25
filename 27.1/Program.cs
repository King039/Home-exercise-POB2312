using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Укажите количество рублей: ");
        decimal roubles = decimal.Parse(Console.ReadLine()!);

        decimal roublesToTenge = RubleConverter.ToTenge(roubles);
        Console.WriteLine($"В тенге: {roublesToTenge}");

        decimal roublesToDollars = RubleConverter.ToDollars(roubles);
        Console.WriteLine($"В долларах США: {roublesToDollars}");

        decimal roublesToEuros = RubleConverter.ToEuros(roubles);
        Console.WriteLine($"В евро: {roublesToEuros}");

        decimal roublesToZlotys = RubleConverter.ToZlotys(roubles);
        Console.WriteLine($"В злотах: {roublesToZlotys}");

        decimal roublesToYuan = RubleConverter.ToYuan(roubles);
        Console.WriteLine($"В юань: {roublesToYuan}");

        decimal roublesToRupes = RubleConverter.ToRupes(roubles);
        Console.WriteLine($"В рупий: {roublesToRupes}");
    }
}

class RubleConverter
{
    public static decimal ToTenge(decimal rubles)
    {
        return rubles * 5.23m;
    }

    public static decimal ToDollars(decimal rubles)
    {
        return rubles * 0.011369m;
    }

    public static decimal ToEuros(decimal rubles)
    {
        return rubles * 0.010609m;
    }

    public static decimal ToZlotys(decimal rubles)
    {
        return rubles * 0.046075m;
    }

    public static decimal ToYuan(decimal rubles)
    {
        return rubles * 0.083019m;
    }

    public static decimal ToRupes(decimal rubles)
    {
        return rubles * 0.950281m;
    }

}
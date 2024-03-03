

namespace LiskovSubstitutionPrinciple.Yanlıs;

public class Kare:Dikdortgen
{
    public override int Genislik
    {
        set { base.Genislik = base.Yukseklik = value; }
    }

    public override int Yukseklik
    {
        set { base.Genislik = base.Yukseklik = value; }
    }
}

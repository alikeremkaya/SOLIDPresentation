
namespace LiskovSubstitutionPrinciple.Dogru;

public class Dikdortgen:Sekil
{
    public int Genislik { get; set; }
    public int Yukseklik { get; set; }

    public override int Alan()
    {
        return Genislik * Yukseklik;
    }
}

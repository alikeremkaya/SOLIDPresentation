

namespace LiskovSubstitutionPrinciple.Dogru;

public class Kare:Sekil
{
    public int KenarUzunlugu { get; set; }

    public override int Alan()
    {
        return KenarUzunlugu * KenarUzunlugu;
    }
}

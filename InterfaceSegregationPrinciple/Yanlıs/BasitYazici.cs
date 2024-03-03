
namespace InterfaceSegregationPrinciple.Yanlıs;

public class BasitYazici:IYazici
{
    public void Yazdir() { /* Yazdırma işlemleri */ }
    public void Tara() { throw new NotImplementedException(); }
    public void FaksGonder() { throw new NotImplementedException(); }
}

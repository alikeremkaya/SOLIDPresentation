
using InterfaceSegregationPrinciple.Dogru.Interfaces;

namespace InterfaceSegregationPrinciple.Dogru;

public class HepsiBirAradaYazici:IYazici,IFaks,ITarayici
{
    public void Yazdir() { /* Yazdırma işlemleri */ }
    public void Tara() { /* Tarama işlemleri */ }
    public void FaksGonder() { /* Faks gönderme işlemleri */ }
}

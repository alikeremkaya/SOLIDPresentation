
using DependencyInversionPrinciple.Dogru.Interfaces;

namespace DependencyInversionPrinciple.Dogru;

public class EmailGonderici:IMesajGonderici
{
    public void Gonder(string mesaj)
    {
        // E-posta gönderme işlemleri
        Console.WriteLine("E-posta gönderildi: " + mesaj);
    }
}

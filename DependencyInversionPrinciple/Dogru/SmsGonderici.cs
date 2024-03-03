

using DependencyInversionPrinciple.Dogru.Interfaces;

namespace DependencyInversionPrinciple.Dogru;

public class SmsGonderici:IMesajGonderici
{
    public void Gonder(string mesaj)
    {
        // SMS gönderme işlemleri
        Console.WriteLine("SMS gönderildi: " + mesaj);
    }
}

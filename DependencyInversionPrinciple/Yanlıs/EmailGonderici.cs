

namespace DependencyInversionPrinciple.Yanlıs;

public class EmailGonderici
{
    public void Gonder(string mesaj)
    {
        // E-posta gönderme işlemleri
        Console.WriteLine("E-posta gönderildi: " + mesaj);
    }
}

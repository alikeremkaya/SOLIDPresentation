namespace DependencyInversionPrinciple.Yanlıs;

public class SmsGonderici
{
    public void Gonder(string mesaj)
    {
        // SMS gönderme işlemleri
        Console.WriteLine("SMS gönderildi: " + mesaj);
    }
}

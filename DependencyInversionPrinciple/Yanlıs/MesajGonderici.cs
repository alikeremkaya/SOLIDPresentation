
namespace DependencyInversionPrinciple.Yanlıs;

public class MesajGonderici
{
    private EmailGonderici _emailGonderici;
    private SmsGonderici _smsGonderici;

    public MesajGonderici()
    {
        _emailGonderici = new EmailGonderici();
        _smsGonderici = new SmsGonderici();
    }

    public void EmailGonder(string mesaj)
    {
        _emailGonderici.Gonder(mesaj);
    }

    public void SmsGonder(string mesaj)
    {
        _smsGonderici.Gonder(mesaj);
    }
}

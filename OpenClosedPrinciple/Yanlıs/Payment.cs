

namespace OpenClosedPrinciple.Yanlıs;

public class Payment
{
    public void Pay(string paymentType)
    {
        if (paymentType == "CreditCard")
        {
            // Kredi kartı ile ödeme işlemleri
        }
        else if (paymentType == "PayPal")
        {
            // PayPal ile ödeme işlemleri
        }
    }
}

# SOLID Sunum

Bu depo, SOLID prensiplerini anlatan bir sunum içerir. Her prensip için doğru ve yanlış örnekler verilmiştir. Aşağıda, her prensibe ve ilgili dosyalara dair kısa bir açıklama bulabilirsiniz.

## İçindekiler
1. [Single Responsibility Principle (SRP)](#single-responsibility-principle-srp)
2. [Open/Closed Principle (OCP)](#openclosed-principle-ocp)
3. [Liskov Substitution Principle (LSP)](#liskov-substitution-principle-lsp)
4. [Interface Segregation Principle (ISP)](#interface-segregation-principle-isp)
5. [Dependency Inversion Principle (DIP)](#dependency-inversion-principle-dip)

## Single Responsibility Principle (SRP)
Bir sınıfın sadece bir sorumluluğu olmalıdır. Her sınıf sadece bir iş yapmalıdır.
- Yanlış Örnek: `SingleResponsibilityPrinciple/Yanlis`
- Doğru Örnek: `SingleResponsibilityPrinciple/Dogru`

## Open/Closed Principle (OCP)
Yazılım varlıkları (sınıflar, modüller, fonksiyonlar, vb.) genişletilmeye açık ancak değiştirmeye kapalı olmalıdır.
- Yanlış Örnek: `OpenClosedPrinciple/Yanlis`
- Doğru Örnek: `OpenClosedPrinciple/Dogru`

## Liskov Substitution Principle (LSP)
Türetilmiş sınıflar, türetildikleri temel sınıfın yerine kullanılabilmelidir.
- Yanlış Örnek: `LiskovSubstitutionPrinciple/Yanlis`
- Doğru Örnek: `LiskovSubstitutionPrinciple/Dogru`

## Interface Segregation Principle (ISP)
Kullanıcıların kullanmadıkları arayüzlere bağımlı olmaya zorlanmamalıdır.
- Yanlış Örnek: `InterfaceSegregationPrinciple/Yanlis`
- Doğru Örnek: `InterfaceSegregationPrinciple/Dogru`

## Dependency Inversion Principle (DIP)
Yüksek seviye modüller, düşük seviye modüllere bağımlı olmamalıdır. Her ikisi de soyutlamalara bağımlı olmalıdır.
- Yanlış Örnek: `DependencyInversionPrinciple/Yanlis`
- Doğru Örnek: `DependencyInversionPrinciple/Dogru`

### Örnekler
#### SMS Gönderici
```csharp
using DependencyInversionPrinciple.Dogru.Interfaces;

namespace DependencyInversionPrinciple.Dogru
{
    public class SmsGonderici : IMesajGonderici
    {
        public void Gonder(string mesaj)
        {
            // SMS gönderme işlemleri
            Console.WriteLine("SMS gönderildi: " + mesaj);
        }
    }
}

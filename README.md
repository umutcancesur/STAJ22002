# STAJ22002
.NET Core ve Onion Architecture kullanılarak geliştirilen bir proje.

## Mimari

Proje, Onion Architecture prensiplerine uygun olarak şu katmanlardan oluşmaktadır:

- **API**: Uygulamanın dışa açılan uç noktalarını (Endpoints) içerir.
- **Application**: İş kuralları ve uygulama mantığını barındırır.
- **Infrastructure (Infra)**: Veri erişimi ve dış servis entegrasyonlarını sağlar.
- **Domain**: Çekirdek iş kuralları ve varlıkları (Entities) içerir.

## Özellikler

- Katmanlı mimariyle modüler ve temiz bir yapı.
- .NET Core kullanılarak modern ve sürdürülebilir geliştirme.
- Kolay test edilebilir ve genişletilebilir tasarım.

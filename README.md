# 💳 Ödeme Yöntemleri - Factory Yapısı

Yapmış olduğum bu küçük çaplı projede temel amacım, yeni bir ödeme yöntemi eklendiğinde mevcut kodlara dokunulmadan sadece ilgili yöntemle yeni sınıfını yazıp devam edilmesini sağlamak.

Projede `PaymentFactory` sınıfı sayesinde, kullanıcıdan gelen ödeme yöntemi ismi ne olursa olsun, bu isimle doğru sınıfı bulup onun bir nesnesini oluşturuyor. Bunu yaparken de C#’ta bulunan **reflection** yapısından faydalandım.

## 📌 Kısaca Proje İçeriği:

- Her ödeme yöntemi kendi sınıfında tanımlanır ama hepsi `IPayment` interface’ine bağlı kalarak çalışır.
- `PaymentFactory`, bu sınıf adlarını çalışırken tanır ve otomatik olarak nesnesini oluşturur. Tek tek `new` ile nesne oluşturmakla uğraşılmaz.
- `if-else`, `switch` gibi klasik kontrol yapılarına ihtiyaç kalmaz.
- Yeni bir ödeme türü eklemek için sadece yeni bir sınıf yazmak yeterlidir.
- SOLID prensiplerine uygundur, özellikle **Open/Closed** (Açık/Kapalı) ilkesine birebir uyar.

Proje temelinde basit de olsa, “sistemde değişiklik yapmadan genişletebilme” sorununa güzel ve pratik bir çözüm sunuyor.

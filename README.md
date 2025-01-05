# C# Fundamentals Project


Bu proje içindeki uygulama3 aşamadan oluşuyor ve kullanıcı tercihine göre çalıştırmak istediği programı seçip *Konsol Ekranında* çalıştırabiliyor.

**Projenin İçerdiği Uygulamalar**

1.  Rastgele Sayı Bulma Oyunu
2. Hesap Makinesi
3. Ortalama Hesaplama

### 1. Rastgele Sayı Bulma Oyunu

- Bilgisayar bir rastgele sayı belirlesin (örneğin 1 ile 100 arasında).
- Kullanıcıdan bu sayıyı tahmin etmesini isteyin.
- Kullanıcı her tahmininde, bilgisayarın seçtiği sayıya yakınlığını kontrol edin ve ipucu verin (daha yüksek veya daha düşük).
- Kullanıcının 5 canı olsun (5 tahmin hakkı). Her tahmin sonrası kalan canını gösterin.
- Kullanıcı doğru tahminde bulunursa oyunu bitirin ve tebrik edin.
- Eğer 5 tahmin hakkı dolarsa, doğru sayıyı gösterin ve oyunu bitirin.
---
### 2. Hesap Makinesi

- Kullanıcıya ilk sayıyı girmesini isteyin.
- Kullanıcıya ikinci sayıyı girmesini isteyin.
- Kullanıcıya yapmak istediği işlemi seçmesini isteyin:
  > Toplama için +
  > Çıkarma için -
  > Çarpma için *
  > Bölme için /
- Kullanıcının seçimine göre uygun işlemi gerçekleştirip sonucu ekrana yazdırın. Eğer bölme işlemi seçildiyse, sıfıra bölme hatası durumunu kontrol edin.

**Programı yazarken dikkat etmeniz gereken noktalar:**

> Kullanıcı girdilerini doğru bir şekilde almak için **Console.ReadLine()** ve **Convert.ToInt32()** gibi metodları kullanın.

> İşlem seçiminde **if-else** veya **switch-case** yapısını kullanarak uygun işlemi gerçekleştirin.

> Bölme işlemi yapılırken sıfıra bölme hatasını kontrol edin ve kullanıcıya uygun bir mesaj gösterin.
---
### 3. Ortalama Hesaplama

- Kullanıcıdan birinci ders notunu girmesini isteyin.

- Kullanıcıdan ikinci ders notunu girmesini isteyin.

- Kullanıcıdan üçüncü ders notunu girmesini isteyin.

- Girdiği notların ortalamasını hesaplayın ve ekrana yazdırın.

- Notların geçerli olup olmadığını kontrol edin (0-100 aralığında olmalıdır). Geçersiz bir not girildiğinde kullanıcıya hata mesajı verin ve programı sonlandırın.

- Ortalama notun harf karşılığını göstermek için aşağıdaki harf notu tablosunu kullanın:

**Programı yazarken dikkat etmeniz gereken noktalar:**

> Kullanıcı girdilerini doğru bir şekilde almak için **Console.ReadLine()** ve **Convert.ToDouble()** gibi metodları kullanın.

> Notların geçerliliğini kontrol etmek için **if** yapısını kullanın.

> Ortalama hesaplamasını doğru bir şekilde yapmak için **double** türünde bir değişken kullanın.

> Harf notu tablosunu kullanarak kullanıcının aldığı ortalamaya karşılık gelen harf notunu belirleyin ve ekrana yazdırın.
---

## Projeyi Çalıştırma

Bu projeyi çalıştırmak için **[Visual Studio](https://visualstudio.microsoft.com/)** kullanmalısınız.

Visual Studio uygulamasını açtıktan sonra aşağıdaki adımları izlemeniz gereklidir:
1.  **Clone a Repository** seçeneğine tıklayıp **[GitHub](https://github.com/abdndmn/C-FundamentalsProject.git)** URL'sini ilgili bölüme yapıştırın.
2. URL'yi klonladıktan sonra **'Progam.cs'** dosyasını açmalısınız.
3. Açılan kodu çalıştırmak için **F5** tuşuna basın.
4. Konsol ekranındaki yönergeleri takip ederek uygulamalar arasında seçim yapıp istediğiniz uygulamayı çalıştırabilirsiniz.
---




# C# Fundamentals Project


Bu proje içindeki uygulama 3 aşamadan oluşuyor ve kullanıcı tercihine göre çalıştırmak istediği programı seçip *Konsol Ekranında* çalıştırabiliyor.

**Projenin İçerdiği Uygulamalar**

1. Rastgele Sayı Bulma Oyunu
2. Hesap Makinesi
3. Ortalama Hesaplama

### 1. Rastgele Sayı Bulma Oyunu

- Bilgisayar 1 ile 100 arasında rastgele bir sayı belirler. 
- Kullanıcıdan bu sayıyı tahmin etmesi istenir.
- Kullanıcının her tahmininde, bilgisayarın seçtiği sayıya yakınlığı kontrol edilir ve ipucu verilir(daha yüksek veya daha düşük olarak).
- Kullanıcının 5 tahmin hakkı vardır.
- Kullanıcı doğru tahminde bulunursa oyun biter.
---
### 2. Hesap Makinesi

- Kullanıcıdan iki adet sayı girilmesi istenir.
- Kullanıcıdan yapmak istediği işlemi seçmesini istenir
  > Toplama için +
  > 
  > Çıkarma için -
  > 
  > Çarpma için *
  > 
  > Bölme için /

**Program yazılırken dikkat edilen noktalar:**

> Kullanıcı girdilerini doğru bir şekilde almak için **Console.ReadLine()** ve **Convert.ToInt32()** gibi metodları kullanılmıştır.

> İşlem seçiminde **if-else** yapısı kullanılmıştır.

> Bölme işlemi yapılırken sıfıra bölme hatasını kontrol edin ve kullanıcıya uygun bir mesaj gösterin.
---
### 3. Ortalama Hesaplama

- Kullanıcıdan ders notlarını girmesi istenir.

- Girdiği notların ortalamasını hesaplanır.

- Girilen notların 0-100 aralığında olması kontrol edilir.

- Ortalama notun harf karşılığını göstermek için aşağıdaki harf notu tablosu kullanılır:
  >90-100: AA
  >
  >85-89:  BA
  >
  >80-84:  BB
  >
  >75-79:  CB
  >
  >70-74:  CC
  >
  >65-69:  DC
  >
  >60-64:  DD
  >
  >55-59:  FD
  >
  >0-54:   FF

**Program yazılırken dikkat edilen noktalar::**

> Kullanıcı girdilerini doğru bir şekilde almak için **Console.ReadLine()** ve **Convert.ToDouble()** gibi metodlar kullanılır.

> Notların geçerliliğini kontrol etmek için **if** yapısı kullanılır.

> Ortalama hesaplamasını doğru bir şekilde yapmak için **double** türünde değişken kullanılır.

> Harf notu tablosunu kullanarak kullanıcının aldığı ortalamaya karşılık gelen harf notunu belirlenir ve yazdırılır.
---

## Projeyi Çalıştırma

Bu projeyi çalıştırmak için **[Visual Studio](https://visualstudio.microsoft.com/)** kullanmalısınız.

Visual Studio uygulamasını açtıktan sonra aşağıdaki adımları izlemeniz gereklidir:
1.  **Clone a Repository** seçeneğine tıklayıp **[GitHub](https://github.com/abdndmn/C-FundamentalsProject.git)** URL'sini ilgili bölüme yapıştırın.
3. URL'yi klonladıktan sonra **'Progam.cs'** dosyasını açmalısınız.
4. Açılan kodu çalıştırmak için **F5** tuşuna basın.
5. Konsol ekranındaki yönergeleri takip ederek uygulamalar arasında seçim yapıp istediğiniz uygulamayı çalıştırabilirsiniz.
---




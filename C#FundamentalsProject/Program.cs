using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace CSFundamentalsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen çalıştırmak istediğiniz uygulamanın kodunu giriniz!\n\nRastgele Sayı Bulma Oyunu-1\nHesap Makinesi-2\nNot Ortalaması Hesaplama-3");
            int appSelection = Convert.ToInt32(Console.ReadLine());//Kullanıcıdan 3 appten biriniz seçmesini istiyoruz.
            if (appSelection == 1)
            {
                Console.WriteLine("RASTGELE SAYI BULMA OYUNU\n\n");

                int GenerateRandomNumber()//1 ile 100 arasında random bir sayı üreten metot.
                {
                    int min = 1;
                    int max = 100;
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(min, max);
                    return randomNumber;
                }


                int randomNumber = GenerateRandomNumber();//Üretilen rastgele sayıyı bir değişkene atama
                int guessedNumber;
                int guessCount = 5;//oyuncunun yalnızca 5 tahmin hakkı var.

                Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı tahmin edin:");
                Console.WriteLine("5 Tahmin hakkınız var.");

                while (guessCount > 0)
                {
                    guessedNumber = Convert.ToInt32(Console.ReadLine());

                    if (guessedNumber >= 1 && guessedNumber <= 100)
                    {
                        if (guessedNumber == randomNumber)
                        {
                            Console.WriteLine("\nTebrikler, doğru sayıyı tahmin ettiniz!");
                            return;
                        }
                        if (guessCount > 1)//Son tahmin sorulduktan sonra buyuk veya kucuk tahmin istemeyecegimiz icin donguyu 1 tahmin hakkı kalana kadar döndürdük.
                        {
                            if (guessedNumber < randomNumber)
                            {
                                Console.WriteLine("\nLütfen daha büyük bir sayı tahmin ediniz!");
                            }
                            else if (guessedNumber > randomNumber)
                            {
                                Console.WriteLine("\nLütfen daha küçük bir sayı tahmin ediniz!");
                            }
                            Console.WriteLine($"(Kalan tahmin hakkınız: {guessCount - 1})");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nLütfen 1 ile 100 arasında bir sayı giriniz!");//1-100 aralıgı dısında bir tahmin gelirse oyuncu uyarılacak ve bu tahmini de haklarından düşecek.
                        Console.WriteLine($"(Kalan tahmin hakkınız: {guessCount - 1})");
                    }
                    guessCount--;

                    if (guessCount < 1)//Tahmin hakkı bittiğinde döngü duracak ve dogru sayı ekrana yazılacak
                    {
                        Console.WriteLine($"\nTahmin hakkınız kalmadı! Doğru sayı: {randomNumber}");
                    }




                }
            }
            else if (appSelection == 2)
            {
                Console.WriteLine("HESAP MAKİNESİ\n\n");

                Console.WriteLine("Lutfen ilk sayıyı giriniz:");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nLutfen 2. sayıyı giriniz:");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nLutfen yapmak istediginiz işlemi seçiniz:");
                Console.WriteLine("(Toplam için +, Çıkarma için -, Çarpma için *, Bölme için / )");

                string calc = Console.ReadLine();//Yapılmak istenen işlem için alınacak olan işlem sembolü string bir değişkene atandı.

                if (calc == "+")//String değişkenin işlem sembolüne eşitliği kontrol edilip o işlem yapılacak.
                {
                    Console.WriteLine("Toplam sonucu = " + (number1 + number2));
                }
                else if (calc == "-")
                {
                    Console.WriteLine("Çıkarma sonucu = " + (number1 - number2));
                }
                else if (calc == "*")
                {
                    Console.WriteLine("Çarpma sonucu = " + (number1 * number2));
                }
                else if (calc == "/")
                {
                    if (number2 == 0)//Sıfıra bölmenin önüne gecmek için eger number2 sıfıra eşitse hata mesajı verilecek.
                    {
                        Console.WriteLine("Bölme işleminde Sıfıra bölme yapılmaz.");
                    }
                    else
                    {
                        Console.WriteLine("Bölme sonucu = " + (number1 / number2));
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz İslem");//Girilmesi istenen 4 işlem sembolu dışında bir sembol veya string girilirse hata verecek.
                }
            }
            else if (appSelection == 3)
            {
                Console.WriteLine("NOT ORTALAMASI HESAPLAMA\n\n");


                Console.WriteLine("Lutfen ilk ders notunuzu giriniz!");// Kullanıcıdan ders notlarını alma
                double grade1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lutfen 2. ders notunuzu giriniz!");
                double grade2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lutfen 3. ders notunuzu giriniz!");
                double grade3 = Convert.ToDouble(Console.ReadLine());


                double average = (grade1 + grade2 + grade3) / 3;//Girdiği notların ortalamasını hesaplama

                if ((grade1 < 0 || grade1 > 100) && (grade2 < 0 || grade2 > 100) && (grade3 < 0 || grade3 > 100))//Gecersiz kod kontrolü
                {
                    Console.WriteLine("Geçersiz not. Program sonlandırılıyor...");
                    return;

                }

                Console.WriteLine($"\nOrtalama notunuz: {average}\n");

                Console.WriteLine("Ortalama Notun Harf Karşılığı:\n" + // Harf notu tablosunu ekrana yazdırma
                                  " 90 - 100: AA\n" +
                                  " 85 - 89:  BA\n" +
                                  " 80 - 84:  BB\n" +
                                  " 75 - 79:  CB\n" +
                                  " 70 - 74:  CC\n" +
                                  " 65 - 69:  DC\n" +
                                  " 60 - 64:  DD\n" +
                                  " 55 - 59:  FD\n" +
                                  "  0 - 54:  FF\n");

                static string LetterGrade(double average)// Harf notunu belirleme metodu
                {
                    if (average >= 90) return "AA";
                    if (average >= 85) return "BA";
                    if (average >= 80) return "BB";
                    if (average >= 75) return "CB";
                    if (average >= 70) return "CC";
                    if (average >= 65) return "DC";
                    if (average >= 60) return "DD";
                    if (average >= 55) return "FD";
                    return "FF";
                }



                string letterGrade = LetterGrade(average);//Harf notunu konsola yazdırma
                Console.WriteLine($"Ortalama puanınıza karşılık gelen harf notunuz: {letterGrade}");


            }
            else
            {
                Console.WriteLine("\nHatalı bir giriş yaptınız.Lütfen;\n Rastgele Sayı Bulma Oyunu için 1,\n Hesap Makinesi için 2,\n Not Ortalaması Hesaplaması için 3, giriniz!");
            }


        }
    }
}


# Konsol Uygulama Projesi

## Genel Bakış
Bu proje, C# dilinde yazılmış basit bir konsol uygulamasıdır. Kullanıcıya üç farklı programdan birini seçme ve bu programlarla konsol üzerinden etkileşimde bulunma imkanı sunar. Projeye dahil olan programlar şunlardır:

1. **Rastgele Sayı Bulma Oyunu**
2. **Hesap Makinesi**
3. **Ortalama Hesaplama**

## Kullanılan Teknolojiler
- **C#**: Uygulamanın geliştirilmesi için kullanılan programlama dili.
- **.NET Konsol Uygulaması**: Uygulamanın inşa edilip çalıştırıldığı platform.
- **Visual Studio**: Projenin geliştirilmesi ve test edilmesi için önerilen IDE.

## Projeyi Çalıştırma Adımları
1. **Depoyu klonlayın veya indirin**: Proje dosyalarını yerel bilgisayarınıza indirin ya da klonlayın.
2. **Visual Studio’da açın**: Projeyi Visual Studio veya C# uyumlu başka bir IDE’de açın.
3. **Projeyi çalıştırın**: IDE üzerinden derleyip çalıştırın.
4. **Talimatları takip edin**: Uygulama size üç programdan birini seçmenizi isteyecek:
   - **Rastgele Sayı Bulma Oyunu**: Bilgisayarın rastgele seçtiği sayıyı tahmin edin.
   - **Hesap Makinesi**: Temel aritmetik işlemleri yapın (toplama, çıkarma, çarpma, bölme).
   - **Ortalama Hesaplama**: Girdiğiniz ders notlarının ortalamasını ve harf notunu hesaplayın.

## Proje Yapısı
- `Main()` metodu, kullanıcıya üç programdan birini seçmesi için bir menü sunar.
- Her program kendi metodunda bulunur (`RastgeleSayiOyunu`, `HesapMakinesi`, `OrtalamaHesaplama`).
- Projede temel kontrol yapıları kullanılmıştır: döngüler (`while`), koşul ifadeleri (`if`, `else`, `switch`) ve kullanıcı girdisi doğrulama işlemleri.

## Programların Açıklamaları

### 1. Rastgele Sayı Bulma Oyunu
- Bilgisayar 1 ile 100 arasında rastgele bir sayı seçer.
- Kullanıcı bu sayıyı 5 tahmin hakkı içinde bulmaya çalışır.
- Her tahminden sonra daha büyük ya da daha küçük bir tahmin yapması gerektiğine dair ipucu verilir.
- Doğru tahmin yapılırsa tebrik mesajı, tahmin hakkı biterse doğru sayı gösterilir.

### 2. Hesap Makinesi
- Kullanıcıdan iki sayı girmesi istenir.
- Kullanıcı, toplama (`+`), çıkarma (`-`), çarpma (`*`) veya bölme (`/`) işlemlerinden birini seçer.
- Seçilen işlem gerçekleştirilir ve sonuç ekrana yazdırılır.
- Eğer bölme işlemi seçilirse, sıfıra bölme hatası kontrol edilir ve uygun bir hata mesajı gösterilir.

### 3. Ortalama Hesaplama
- Kullanıcı üç ders notu girer.
- Girilen notların geçerliliği (0-100 arasında olup olmadığı) kontrol edilir.
- Ortalama hesaplanır ve ortalamaya karşılık gelen harf notu ekranda gösterilir (örn. 90-100: AA, 85-89: BA, vb.).
- Geçersiz not girildiğinde hata mesajı görüntülenir ve program sonlandırılır.

# Console Application Project

## Overview
This project is a C# console application that allows users to choose between three different programs:

1. **Random Number Guessing Game**
2. **Calculator**
3. **Grade Average Calculator**

## How to Run the Project
1. Clone or download this repository.
2. Open the project in an IDE that supports C#, such as Visual Studio.
3. Build and run the project.
4. Follow the on-screen instructions to select a program and interact with it.

## Project Features
### 1. Random Number Guessing Game
- The program selects a random number between 1 and 100.
- The user has 5 attempts to guess the number, receiving hints whether the guess is too high or too low.
- If the user guesses correctly, they are congratulated. If all attempts are used, the correct number is shown.

### 2. Calculator
- The user inputs two numbers and selects an operation (`+`, `-`, `*`, `/`).
- The program performs the calculation and displays the result.
- Division by zero is handled with an appropriate error message.

### 3. Grade Average Calculator
- The user inputs three exam grades.
- The program calculates the average and displays the corresponding letter grade.
- The grade scale is based on a range from 0-100, and invalid grades outside this range are rejected.

## Technologies Used
- **C#**
- **.NET Core** or **.NET Framework**
- **Visual Studio** (for development)

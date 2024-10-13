# Konsol Uygulama Projesi

## Genel Bakış
Bu proje, C# dilinde yazılmış basit bir konsol uygulamasıdır. Kullanıcıya üç farklı programdan birini seçme ve bu programlarla konsol üzerinden etkileşimde bulunma imkanı sunar. Projeye dahil olan programlar şunlardır:

1. **Rastgele Sayı Bulma Oyunu**
2. **Hesap Makinesi**
3. **Ortalama Hesaplama**

Her bir program, belirli bir işlevi yerine getirir ve kullanıcıdan girdi alarak bu girdiler üzerinde işlem yapar. Proje, temel programlama kavramlarını (kullanıcı girdisi, koşul ifadeleri, döngüler ve hata kontrolü) uygulamalı olarak göstermeyi amaçlar.

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

## Ek Bilgiler
Bu proje, C# dilinde konsol uygulamaları geliştirmenin temel prensiplerini öğretmek amacıyla oluşturulmuştur. Her bir program, kullanıcının girdilerini alır ve bu girdilere göre uygun işlemleri gerçekleştirir. Aynı zamanda hata kontrolleri yaparak kullanıcının yanlış giriş yapması durumunda uygun geri bildirimler verir.

# Console Application Project

## Overview
This project is a simple console application written in C#. It allows users to choose between three different programs and interact with them via the console. The programs included in this project are:

1. **Random Number Guessing Game**
2. **Calculator**
3. **Grade Average Calculator**

Each program performs a specific task and allows the user to provide input through the console. The goal of the project is to demonstrate basic programming concepts such as user input, conditionals, loops, and error handling.

## Technologies Used
- **C#**: The programming language used to develop the application.
- **.NET Console Application**: The platform for building and running the application.
- **Visual Studio**: Recommended IDE for development and testing.

## How to Run the Project
1. **Clone the repository**: Download or clone the project repository to your local machine.
2. **Open in Visual Studio**: Open the project in Visual Studio or another C# compatible IDE.
3. **Run the project**: Compile and run the application from the IDE.
4. **Follow the instructions**: The application will prompt you to choose between three different programs:
   - **Random Number Guessing Game**: Try to guess the randomly generated number.
   - **Calculator**: Perform basic arithmetic operations (addition, subtraction, multiplication, division).
   - **Grade Average Calculator**: Enter exam grades and calculate the average with corresponding letter grades.

## Project Structure
- `Main()` method presents a menu where the user can select one of the three programs.
- Each program is encapsulated in its own method (`RastgeleSayiOyunu`, `HesapMakinesi`, `OrtalamaHesaplama`).
- The project uses basic control structures like loops (`while`), conditional statements (`if`, `else`, `switch`), and user input validation.

## Programs Overview

### 1. Random Number Guessing Game
- A random number between 1 and 100 is generated.

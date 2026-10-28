# Harf Patlatma Oyunu

Oyuncunun seçtiği kelimenin harflerini doğru sırayla bulup patlatmaya çalıştığı, C# ve Windows Forms ile geliştirilmiş küçük bir masaüstü oyunudur.

## Özellikler

- Oyuncu adı belirleme
- Hazır kelime listesinden seçim yapma
- Harfleri oyun alanında rastgele konumlarda görüntüleme
- Harfleri kelimedeki doğru sıraya göre tıklama
- Hatalı tıklamaları sayma
- Oyun sonunda hata sayısını ve puanı gösterme
- `Esc` tuşu veya **Çıkış** butonu ile oyundan çıkma

## Kullanılabilir Kelimeler

- KALEM
- KİTAP
- BİLGİ
- EKRAN
- YAZILIM

## Gereksinimler

- Windows işletim sistemi
- .NET 10 SDK veya Visual Studio 2026
- Windows Forms masaüstü geliştirme bileşenleri

## Çalıştırma

### Visual Studio ile

1. Depoyu klonlayın:

   ```bash
   git clone https://github.com/batucodestr/Harf_Patlatma_Oyunu.git
   ```

2. `HarfPatlatmaOyunu.slnx` çözümünü Visual Studio'da açın.
3. `HarfPatlatmaOyunu` projesini başlangıç projesi olarak seçin.
4. **F5** tuşuna basarak uygulamayı çalıştırın.

### .NET CLI ile

Proje dizininde aşağıdaki komutları çalıştırın:

```bash
dotnet restore
dotnet run --project HarfPatlatmaOyunu/HarfPatlatmaOyunu.csproj
```

## Nasıl Oynanır?

1. **Yeni Oyun** butonuna tıklayın.
2. Oyuncu adınızı girin.
3. Listeden bir kelime seçin.
4. Oyun alanında görünen harfleri seçtiğiniz kelimedeki sıraya göre tıklayın.
5. Yanlış her tıklama hata sayısını artırır.
6. Tüm harfleri doğru sırayla bulduğunuzda sonuç ekranında puanınızı görün.

Puan, başlangıçta 100'dür ve her hata için 10 puan azalır.

## Proje Yapısı

```text
HarfPatlatmaOyunu/
├── Form1.cs              # Ana oyun ekranı ve oyun akışı
├── Form2.cs              # Oyuncu adı ve kelime seçim ekranı
├── Form3.cs              # Oyun sonucu ve puan ekranı
├── Program.cs            # Uygulama giriş noktası
└── HarfPatlatmaOyunu.csproj
```

## Teknolojiler

- C#
- .NET 10
- Windows Forms
- Visual Studio

## Lisans

Bu proje eğitim ve kişisel geliştirme amacıyla hazırlanmıştır.

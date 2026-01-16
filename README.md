# 🌱 GreenByte – Akıllı Sera Yönetim Sistemi

GreenByte, ESP32 tabanlı donanım mimarisi ve web/desktop yazılım katmanlarıyla geliştirilmiş **uçtan uca akıllı sera otomasyon sistemidir.** Ortam verilerini gerçek zamanlı toplar, analiz eder ve sera ekipmanlarını otomatik olarak kontrol eder.

---

## 📌 Projenin Amacı

* Ortam koşullarını sürekli izlemek
* Sulama, havalandırma ve aydınlatmayı otomatik yönetmek
* Verileri kayıt altına almak ve raporlamak
* Web ve masaüstü üzerinden uzaktan kontrol sağlamak

---

## 🧠 Sistem Mimarisi

```
[ Sensors ]
   │
   ▼
[ ESP32 Firmware ]
   │  (WiFi / HTTP)
   ▼
[ PHP REST API ]
   │
   ▼
[ MySQL Database ]
   │
   ├── Web Dashboard (HTML/CSS/JS)
   └── Desktop App (.NET WinForms)
```

**Akış:**

* Sensörler → ESP32 veri toplar
* ESP32 → API’ye veri gönderir
* API → MySQL’e kaydeder
* Paneller → verileri okur, komut gönderir
* ESP32 → röleleri tetikler

---

## 🔁 Sistem Döngüsü (Firmware Logic)

1. Sensör verileri okunur
2. Eşik değerler kontrol edilir
3. Gerekli röleler tetiklenir
4. Veriler API’ye gönderilir
5. Kritik durumlar loglanır / bildirilir

---

## ✨ Özellikler

* 🌡️ Sıcaklık ve nem takibi (DHT11)
* 💧 Toprak nemine bağlı otomatik sulama
* 💡 Ortam ışığına göre LED kontrolü (LDR)
* 🌬️ MQ135 ile hava kalitesi takibi
* 🚰 Su tankı seviye kontrolü
* 🏠 Fan, LED ve pompa otomasyonu (röle)
* 🌐 Web paneli ile canlı izleme
* 💻 Masaüstü uygulaması ile yönetim
* 📊 Geçmiş veriler ve raporlama
* ⚠️ Kritik durum uyarıları

---

## 🔧 Teknoloji Yığını

### Donanım

* ESP32
* DHT11
* LDR
* MQ135
* Toprak nem sensörü
* Su seviye sensörü
* 4 kanallı röle modülü

### Yazılım

**Firmware**

* Arduino (C++)

**Backend**

* PHP (REST API)
* MySQL

**Frontend**

* HTML, CSS, JavaScript

**Desktop**

* .NET WinForms

---

## 🔌 Örnek Pin Yapısı

| Bileşen            | Pin     |
| ------------------ | ------- |
| DHT11              | GPIO 21  |
| LDR                | GPIO 34 |
| Soil Moisture      | GPIO 35 |
| MQ135              | GPIO 32 |
| Water Level Sensor | GPIO 33 |
| Relay IN1 (Pump)   | GPIO 13 |
| Relay IN2 (Fan)    | GPIO 26 |
| Relay IN3 (LED)    | GPIO 27 |

> Not: Pinler projeye göre değiştirilebilir.

---

## 🌐 Backend Yapısı (Örnek)

```
/api
  ├── sensors/
  │     ├── insert.php
  │     └── latest.php
  ├── control/
  │     ├── get.php
  │     └── update.php
  └── alerts/
        └── log.php
```

**Örnek Veri Gönderimi**

```json
{
  "temperature": 24.6,
  "humidity": 58,
  "soil": 41,
  "airQuality": 312,
  "waterLevel": 76
}
```

---

## ⚙️ Kurulum

### 1) Donanım

* Sensörleri ESP32’ye bağla
* Röle modülünü fan, LED ve pompaya bağla

### 2) Firmware

* Arduino IDE kur
* ESP32 board paketini ekle
* Firmware’i ESP32’ye yükle

### 3) Backend

* PHP API dosyalarını sunucuya yerleştir
* MySQL veritabanını oluştur
* `config.php` (veya `.env`) bağlantı ayarlarını yap

### 4) Paneller

* Web arayüzünü sunucuya koy
* Masaüstü uygulamasını build alıp çalıştır

---

## 🧪 Test Senaryoları (Örnek)

* Sensör verisi gelmezse hata loglanıyor mu?
* Toprak kuruyken pompa aktif oluyor mu?
* Sıcaklık artınca fan tetikleniyor mu?
* API bağlantısı kesilince sistem fallback yapıyor mu?
* Kritik seviyede uyarı üretiliyor mu?

---

## 📈 Geliştirme Yol Haritası

* Mobil uygulama
* Grafik tabanlı veri analizi
* AI destekli sulama tahmin sistemi
* MQTT mimarisine geçiş
* Çoklu sera desteği

---

## 🌱 Lisans

Bu proje eğitim ve geliştirme amaçlıdır.

---

# 🌱 GreenByte – Smart Greenhouse Management System

GreenByte is an **end-to-end smart greenhouse automation system** built on ESP32 hardware and multi-layer software architecture. It collects environmental data in real time, analyzes conditions, and automatically controls greenhouse equipment.

---

## 📌 Project Purpose

* Continuous environmental monitoring
* Automated irrigation, ventilation and lighting
* Data logging and reporting
* Remote access via web and desktop

---

## 🧠 System Architecture

```
[ Sensors ]
   │
   ▼
[ ESP32 Firmware ]
   │  (WiFi / HTTP)
   ▼
[ PHP REST API ]
   │
   ▼
[ MySQL Database ]
   │
   ├── Web Dashboard (HTML/CSS/JS)
   └── Desktop App (.NET WinForms)
```

---

## 🔁 Firmware Cycle

1. Read sensors
2. Check threshold values
3. Trigger relays
4. Send data to API
5. Log critical states

---

## ✨ Features

* Real-time temperature & humidity monitoring (DHT11)
* Smart irrigation system (soil moisture)
* Automatic light control (LDR)
* Air quality / CO₂ monitoring (MQ135)
* Water level tracking
* Fan, LED and pump automation (relay)
* Web dashboard for live monitoring
* Desktop management application
* Historical data and reporting
* Alerts and notifications

---

## 🔧 Tech Stack

**Hardware**

* ESP32, DHT11, LDR, MQ135
* Soil moisture sensor, water level sensor
* 4-channel relay

**Firmware**

* Arduino (C++)

**Backend**

* PHP REST API
* MySQL

**Frontend**

* HTML/CSS/JavaScript

**Desktop**

* .NET WinForms

---

## ⚙️ Installation

1. Connect sensors and relays to ESP32
2. Upload firmware via Arduino IDE
3. Deploy PHP API and create MySQL database
4. Launch the web dashboard and desktop app

---

## 📈 Roadmap

* Mobile app
* Advanced data analytics
* AI-assisted automation
* MQTT communication
* Multi-greenhouse support
  n

---

GreenByte converts traditional greenhouses into **measurable, automated, and remotely controlled ecosystems.**

# 🛡️ WoCyber - Gelişmiş Siber Güvenlik Platformu

## 📖 Proje Açıklaması

WoCyber, modern güvenlik özellikleri ile donatılmış, tek sayfa (SPA) siber güvenlik blog platformudur. Bu proje vanilla JavaScript kullanarak gelişmiş güvenlik uygulamalarını demonstre eder.

## ✨ Özellikler

### 🔐 Güvenlik Özellikleri
- **Rate Limiting**: Brute force saldırılarına karşı koruma
- **Password Hashing**: Güvenli şifre saklama (btoa simülasyonu)
- **E-posta Doğrulaması**: Kayıt sonrası e-posta doğrulama sistemi
- **2FA (Two-Factor Authentication)**: TOTP tabanlı iki faktörlü kimlik doğrulama
- **Session Management**: Güvenli oturum yönetimi
- **XSS Koruması**: Kullanıcı girdilerinde HTML sanitization
- **CSRF Simülasyonu**: Cross-Site Request Forgery koruması
- **Content Security Policy**: Güvenlik başlıkları implementasyonu

### 🎨 Kullanıcı Deneyimi
- **Responsive Tasarım**: Tüm cihazlarda mükemmel görünüm
- **Animasyonlar**: Smooth modal geçişleri ve flip animasyonları
- **Accessibility**: WCAG uyumlu erişilebilirlik özellikleri
- **Prefers-Reduced-Motion**: Hareket hassasiyeti olan kullanıcılar için destek
- **Focus Management**: Klavye navigasyonu ve odak yönetimi
- **Dark Theme**: Modern karanlık tema tasarımı

### 💬 İnteraktif Özellikler
- **Yorum Sistemi**: Gerçek zamanlı yorum yapma ve yanıtlama
- **Reaksiyon Sistemi**: Beğeni ve kalp atma özellikleri  
- **Nested Comments**: İç içe yorum yapısı
- **Real-time Updates**: Anlık güncellemeler

### 👑 Admin Panel Özellikleri
- **Kullanıcı Yönetimi**: Kullanıcı adı değiştirme, yasaklama, admin yapma
- **Yorum Moderasyonu**: Yorum düzenleme ve silme
- **Güvenlik Logları**: Detaylı sistem aktivite takibi
- **Dashboard**: Gerçek zamanlı istatistikler
- **Site Ayarları**: Platform yapılandırma seçenekleri
- **Tam Kontrol**: Admin her şeyi yönetebilir

### 🔧 Teknik Özellikler
- **Vanilla JavaScript**: Framework bağımsızlığı
- **LocalStorage**: Client-side veri persistance
- **CSS Custom Properties**: Tema sistemi
- **ES6+ Features**: Modern JavaScript özellikleri
- **Web APIs**: Crypto API, Notifications API kullanımı

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler
- Modern web tarayıcısı (Chrome 80+, Firefox 75+, Safari 13+)
- HTTPS bağlantısı (bazı güvenlik özellikleri için)

### Kurulum Adımları

1. **Dosyayı İndirin**
   ```bash
   # Projeyi klonlayın veya dosyayı indirin
   git clone <repository-url>
   cd wocyber-platform
   ```

2. **Web Sunucusu Başlatın**
   ```bash
   # Python kullanarak
   python -m http.server 8000
   
   # Node.js kullanarak
   npx serve .
   
   # PHP kullanarak
   php -S localhost:8000
   ```

3. **Tarayıcıda Açın**
   ```
   http://localhost:8000/cyber-security-enhanced.html
   ```

## 🧪 Demo Kullanımı

### Kayıt ve Giriş
1. **Kayıt Ol** butonuna tıklayın
2. Formu doldurun (güçlü şifre kullanın)  
3. E-posta doğrulama simülasyonunu tamamlayın
4. Giriş yapın

### 👑 Admin Panel Erişimi
**Varsayılan Admin Hesabı:**
- **Kullanıcı Adı**: `admin`
- **Şifre**: `admin123`

1. Admin hesabı ile giriş yapın
2. Üst menüde "👑 Admin Panel" butonuna tıklayın
3. Tüm platform özelliklerini yönetin:
   - **Dashboard**: Sistem istatistikleri
   - **Kullanıcılar**: Kullanıcı yönetimi (isim değiştirme, yasaklama, admin yapma)
   - **Yorumlar**: Yorum moderasyonu
   - **Güvenlik**: Güvenlik logları
   - **Ayarlar**: Site yapılandırması

> ⚠️ **Önemli**: İlk girişten sonra admin şifresini mutlaka değiştirin!

### 2FA Kurulumu
1. Giriş yaptıktan sonra **Ayarlar** menüsüne gidin
2. **2FA Etkinleştir** seçeneğini seçin
3. QR kodu Google Authenticator ile tarayın
4. Doğrulama kodunu girin

### Yorum Yapma
1. Makale altındaki yorum alanını kullanın
2. Diğer yorumları beğenin veya kalp atın
3. Yorumlara yanıt verin

## 🔒 Güvenlik Implementasyonu

### Rate Limiting
```javascript
// 5 dakikada maksimum 5 deneme
security.checkRateLimit('login', username, 5, 300000)
```

### Password Hashing
```javascript
// Basit hash (production'da bcrypt/argon2 kullanın)
hashPassword(password) {
    return btoa(password + 'wocyber_salt_2024');
}
```

### XSS Koruması
```javascript
sanitize(content) {
    return content
        .replace(/&/g, '&amp;')
        .replace(/</g, '&lt;')
        .replace(/>/g, '&gt;');
}
```

### 2FA Implementasyonu
```javascript
// TOTP token doğrulama
TwoFactorAuth.verifyToken(token, secret)
```

## 📱 Responsive Tasarım

Platform tüm cihaz boyutlarında optimize edilmiştir:

- **Desktop**: Full featured experience
- **Tablet**: Uyarlanmış layout
- **Mobile**: Touch-friendly interface
- **Minimal modals**: Küçük ekranlarda tam ekran

## ♿ Erişilebilirlik

- **ARIA Labels**: Screen reader desteği
- **Keyboard Navigation**: Tam klavye desteği
- **Focus Management**: Modal içinde odak yönetimi
- **Color Contrast**: WCAG AA uyumlu kontrast
- **Reduced Motion**: Animasyon azaltma desteği

## 🎨 Tema Sistemi

CSS Custom Properties kullanarak kolay tema değişimi:

```css
:root {
    --primary-bg: linear-gradient(135deg, #0f172a 0%, #1e293b 50%, #334155 100%);
    --accent-primary: #3b82f6;
    --text-primary: #f1f5f9;
}
```

## 🧩 Modüler Yapı

### Servis Sınıfları
- `SecurityManager`: Güvenlik işlemleri
- `EmailService`: E-posta doğrulama
- `TwoFactorAuth`: 2FA işlemleri
- `CommentSystem`: Yorum sistemi

### Veri Modeli
```javascript
// Kullanıcı modeli
{
    id: string,
    fullName: string,
    username: string,
    email: string,
    password: string (hashed),
    twoFactorEnabled: boolean,
    twoFactorSecret: string?,
    createdAt: string
}

// Yorum modeli
{
    id: string,
    userId: string,
    userName: string,
    content: string,
    parentId: string?,
    createdAt: string,
    likes: number,
    hearts: number
}
```

## 🚨 Güvenlik Önlemleri

### Client-Side Limitasyonlar
Bu demo client-side güvenlik implementasyonları içerir. Production ortamında:

1. **Server-side validation** mutlaka olmalı
2. **Real database** kullanılmalı (LocalStorage değil)
3. **Proper authentication** (JWT, OAuth)
4. **Real email service** (SendGrid, Mailgun)
5. **Rate limiting** middleware ile
6. **HTTPS** zorunlu
7. **Regular security audits**

### Önerilen Production Stack
- **Backend**: Node.js/Express, Python/Django, .NET Core
- **Database**: PostgreSQL, MongoDB
- **Authentication**: JWT, OAuth 2.0
- **Email**: SendGrid, AWS SES
- **Security**: Helmet.js, CORS, Rate limiting

## 🔧 Geliştirme

### Yeni Özellik Ekleme
1. Modüler yapıyı koruyun
2. Security-first yaklaşım
3. Accessibility testleri yapın
4. Cross-browser test edin

### Test Etme
```bash
# Manual testing checklist
- Modal açma/kapama
- Form validasyonu
- Rate limiting
- Responsive design
- Accessibility (screen reader)
- Performance (Lighthouse)
```

## 📞 Destek

### Bilinen Limitasyonlar
- LocalStorage temelli (demo amaçlı)
- Single-page application
- Client-side güvenlik (demo)

### Katkıda Bulunma
1. Fork yapın
2. Feature branch oluşturun
3. Security açısından review edin
4. Pull request gönderin

## 📜 Lisans

Bu proje eğitim amaçlı geliştirilmiştir. MIT lisansı altında dağıtılmaktadır.

---

**⚠️ DİKKAT**: Bu proje demo amaçlıdır. Production kullanımı için uygun güvenlik önlemlerini almayı unutmayın!

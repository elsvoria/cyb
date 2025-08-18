# 🧪 WoCyber Platform Test Senaryoları

## ✅ Manuel Test Checklist

### 🔐 Authentication Tests

#### Kayıt Sistemi
- [ ] Geçerli bilgilerle kayıt olma
- [ ] Boş alan validasyonu
- [ ] Şifre eşleşme kontrolü
- [ ] Duplicate kullanıcı adı kontrolü
- [ ] Duplicate email kontrolü
- [ ] E-posta format validasyonu
- [ ] Rate limiting (5 deneme/5dk)
- [ ] Password strength validation

#### Giriş Sistemi
- [ ] Geçerli bilgilerle giriş
- [ ] Hatalı şifre ile giriş
- [ ] Olmayan kullanıcı ile giriş
- [ ] Rate limiting (5 deneme/5dk)
- [ ] Account lockout (3 hatalı deneme)
- [ ] E-posta doğrulanmamış hesap
- [ ] 2FA enabled hesap

#### E-posta Doğrulama
- [ ] Verification email simülasyonu
- [ ] Token doğrulama
- [ ] Expired token
- [ ] Invalid token
- [ ] Email verification status check

#### 2FA (Two-Factor Authentication)
- [ ] Secret generation
- [ ] QR code display
- [ ] TOTP token verification
- [ ] Invalid token handling
- [ ] 2FA disable functionality

### 🎨 UI/UX Tests

#### Modal Sistem
- [ ] Login modal açma/kapama
- [ ] Register modal açma/kapama
- [ ] X butonu ile kapama
- [ ] ESC tuşu ile kapama
- [ ] Backdrop click ile kapama
- [ ] Modal switch animasyonu
- [ ] Focus management
- [ ] Focus trap

#### Responsive Design
- [ ] Desktop görünüm (1920x1080)
- [ ] Tablet görünüm (768x1024)
- [ ] Mobile görünüm (375x667)
- [ ] Modal responsive behavior
- [ ] Touch interactions

#### Accessibility
- [ ] Keyboard navigation
- [ ] Screen reader compatibility
- [ ] ARIA labels
- [ ] Color contrast (WCAG AA)
- [ ] Focus indicators
- [ ] Reduced motion respect

### 💬 Comment System Tests

#### Yorum Gönderme
- [ ] Authenticated user yorum yapma
- [ ] Guest user yorum yapamama
- [ ] Boş yorum validation
- [ ] XSS content sanitization
- [ ] Rate limiting
- [ ] Email verified check

#### Reaksiyon Sistemi
- [ ] Like butonu toggle
- [ ] Heart butonu toggle
- [ ] Count updates
- [ ] Multiple users interaction
- [ ] Guest user restriction

#### Reply System
- [ ] Yorum yanıtlama
- [ ] Nested comment display
- [ ] Reply count display
- [ ] Reply author display

### 🔒 Security Tests

#### Rate Limiting
- [ ] Login rate limit (5/5min)
- [ ] Register rate limit (5/5min)
- [ ] Comment rate limit (10/5min)
- [ ] Rate limit reset

#### Data Protection
- [ ] Password hashing
- [ ] XSS prevention
- [ ] Input sanitization
- [ ] LocalStorage encryption (basic)

#### Session Management
- [ ] Login persistence
- [ ] Logout functionality
- [ ] Session timeout
- [ ] Multiple tab sync

### 🎭 Animation Tests

#### Modal Animations
- [ ] Fade in/out
- [ ] Scale animation
- [ ] Flip animation (register->login)
- [ ] Smooth transitions
- [ ] Prefers-reduced-motion

#### Performance
- [ ] Smooth 60fps animations
- [ ] No janky transitions
- [ ] Proper GPU acceleration

### 📱 Cross-Browser Tests

#### Desktop Browsers
- [ ] Chrome 120+
- [ ] Firefox 120+
- [ ] Safari 17+
- [ ] Edge 120+

#### Mobile Browsers
- [ ] Chrome Mobile
- [ ] Safari Mobile
- [ ] Samsung Internet
- [ ] Firefox Mobile

### 🚨 Error Handling Tests

#### Network Errors
- [ ] Offline behavior
- [ ] Service unavailable
- [ ] Timeout handling

#### User Errors
- [ ] Invalid form submission
- [ ] Expired sessions
- [ ] Corrupted localStorage

#### System Errors
- [ ] JavaScript disabled
- [ ] LocalStorage unavailable
- [ ] Crypto API unavailable

## 🧪 Automated Test Examples

### JavaScript Unit Tests

```javascript
// Security Manager Tests
describe('SecurityManager', () => {
    it('should hash passwords correctly', () => {
        const security = new SecurityManager();
        const hash = security.hashPassword('testpass123');
        expect(hash).toBe(btoa('testpass123wocyber_salt_2024'));
    });

    it('should verify passwords correctly', () => {
        const security = new SecurityManager();
        const hash = security.hashPassword('testpass123');
        expect(security.verifyPassword('testpass123', hash)).toBe(true);
        expect(security.verifyPassword('wrongpass', hash)).toBe(false);
    });

    it('should enforce rate limiting', () => {
        const security = new SecurityManager();
        // Test rate limiting logic
        for(let i = 0; i < 6; i++) {
            const result = security.checkRateLimit('test', 'user1', 5, 300000);
            if(i < 5) expect(result).toBe(true);
            else expect(result).toBe(false);
        }
    });
});

// Comment System Tests
describe('CommentSystem', () => {
    it('should sanitize XSS content', () => {
        const commentSystem = new CommentSystem();
        const malicious = '<script>alert("xss")</script>';
        const sanitized = commentSystem.sanitize(malicious);
        expect(sanitized).toBe('&lt;script&gt;alert(&quot;xss&quot;)&lt;/script&gt;');
    });

    it('should add comments correctly', () => {
        // Mock currentUser
        window.currentUser = { id: '1', fullName: 'Test User', email: 'test@test.com' };
        
        const commentSystem = new CommentSystem();
        const comment = commentSystem.addComment('Test comment');
        
        expect(comment.content).toBe('Test comment');
        expect(comment.userId).toBe('1');
        expect(comment.userName).toBe('Test User');
    });
});
```

### Performance Tests

```javascript
// Performance benchmarks
describe('Performance', () => {
    it('should load modal in under 100ms', () => {
        const start = performance.now();
        showModal('loginModal');
        const end = performance.now();
        expect(end - start).toBeLessThan(100);
    });

    it('should render comments efficiently', () => {
        // Create 100 mock comments
        const comments = Array.from({length: 100}, (_, i) => ({
            id: i.toString(),
            content: `Comment ${i}`,
            userName: `User ${i}`,
            createdAt: new Date().toISOString()
        }));

        const start = performance.now();
        loadComments(comments);
        const end = performance.now();
        
        expect(end - start).toBeLessThan(500); // Should render in under 500ms
    });
});
```

## 🎯 Test Execution

### Manual Testing Steps

1. **Setup Environment**
   ```bash
   # Start local server
   python -m http.server 8000
   # Open http://localhost:8000/cyber-security-enhanced.html
   ```

2. **Basic Flow Test**
   - Register new user
   - Verify email (demo)
   - Login with credentials
   - Make a comment
   - React to comments
   - Logout

3. **Security Flow Test**
   - Try multiple login attempts
   - Test XSS in comments
   - Test SQL injection attempts
   - Verify rate limiting

4. **UI Flow Test**
   - Test all modals
   - Test responsive design
   - Test animations
   - Test accessibility

### Automated Testing

```bash
# If using Jest
npm test

# If using browser automation
# Use Playwright/Puppeteer for E2E tests
```

### Performance Testing

```bash
# Lighthouse audit
lighthouse http://localhost:8000/cyber-security-enhanced.html

# Expected scores:
# Performance: 90+
# Accessibility: 95+
# Best Practices: 90+
# SEO: 85+
```

## 📊 Test Results Template

### Test Execution Report

**Date**: _____  
**Tester**: _____  
**Browser**: _____  
**Version**: _____  

#### Test Results Summary
- **Total Tests**: ___
- **Passed**: ___
- **Failed**: ___
- **Skipped**: ___

#### Critical Issues Found
1. _____
2. _____
3. _____

#### Performance Metrics
- **Page Load**: ___ms
- **Modal Open**: ___ms
- **Comment Render**: ___ms
- **Memory Usage**: ___MB

#### Browser Compatibility
- Chrome: ✅/❌
- Firefox: ✅/❌
- Safari: ✅/❌
- Edge: ✅/❌

#### Mobile Testing
- iOS Safari: ✅/❌
- Android Chrome: ✅/❌
- Samsung Internet: ✅/❌

---

**📝 Not**: Bu test senaryoları production kullanımı öncesi mutlaka çalıştırılmalıdır!

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı admin_tablosu
--

CREATE TABLE admin_tablosu (
  id SERIAL PRIMARY KEY,
  kullanici_adi VARCHAR(255) NOT NULL,
  sifre VARCHAR(255) NOT NULL,
  ad VARCHAR(255),
  soyad VARCHAR(255),
  eposta VARCHAR(50),
  lastlogin VARCHAR(1000),
  ip_adresi VARCHAR(1000),
  foto VARCHAR(255)
);

INSERT INTO admin_tablosu (id, kullanici_adi, sifre, ad, soyad, eposta, lastlogin, ip_adresi, foto) VALUES
(1, 'admin', 'demo', 'Admin', 'Demo', 'yaslan@gmail.com', '2025-01-01 16:00:30', '24.133.101.149', 'images/admin/images.jpg');

-- --------------------------------------------------------
CREATE TABLE Ogretmenler (
    Id SERIAL PRIMARY KEY,
    Ad VARCHAR(100) NOT NULL,
    Soyad VARCHAR(100) NOT NULL,
    Brans VARCHAR(100) NOT NULL,
    IsBaslangicTarihi DATE NOT NULL
);

INSERT INTO Ogretmenler (Ad, Soyad, Brans, IsBaslangicTarihi) VALUES
('Ali', 'Yılmaz', 'Matematik', '2025-06-01'),
('Ayşe', 'Demir', 'Türkçe', '2025-06-02'),
('Mehmet', 'Kara', 'Fizik', '2025-06-03'),
('Fatma', 'Şahin', 'Tarih', '2025-06-04'),
('Ahmet', 'Doğan', 'Coğrafya', '2025-06-05'),
('Zeynep', 'Aksoy', 'Felsefe', '2025-06-06'),
('Hakan', 'Koç', 'Kimya', '2025-06-07'),
('Elif', 'Aydın', 'Biyoloji', '2025-06-08');
-- --------------------------------------------------------

CREATE TABLE dersler (
  id SERIAL PRIMARY KEY,
  dersad VARCHAR(255) NOT NULL,
  aciklama VARCHAR(255)
);

INSERT INTO dersler (id, dersad, aciklama) VALUES
(1, 'Matematik', 'Sayılar, işlemler, fonksiyonlar...'),
(2, 'Türkçe', 'Dil bilgisi, paragraf, anlam...'),
(3, 'Tarih', 'Tarihsel olaylar, kronoloji...'),
(4, 'Coğrafya', 'Yer şekilleri, iklim, harita...'),
(5, 'Biyoloji', 'Canlılar, hücre, ekosistem...'),
(6, 'Felsefe', 'Düşünce akımları, filozoflar...'),
(7, 'Kimya', 'Maddeler, tepkimeler, atom...'),
(8, 'KPSS', 'Kamu Personeli Seçme Sınavı'),
(9, 'Fizik', 'Kuvvet, hareket, enerji...');

-- --------------------------------------------------------

CREATE TABLE etut (
  sira SERIAL PRIMARY KEY,
  ogrenciid INT,
  tarih DATE,
  konular VARCHAR(255),
  katilim INT,
  dersadi VARCHAR(255),
  dersvideo VARCHAR(500)
);
-- Yakup için örnek etüt kaydı (id: 1)
INSERT INTO etut (ogrenciid, tarih, konular, katilim, dersadi, dersvideo)
VALUES (1, '2025-06-10', 'Fonksiyonlar ve Grafikler', 1, 'Matematik', 'https://www.youtube.com/watch?v=yakupMatematik');

-- Ayşe için örnek etüt kaydı (id: 2)
INSERT INTO etut (ogrenciid, tarih, konular, katilim, dersadi, dersvideo)
VALUES (2, '2025-06-11', 'Elektriksel Devreler', 1, 'Fizik', 'https://www.youtube.com/watch?v=ayseFizik');
-- Öğrenci 1 için Türkçe, Tarih, Coğrafya, Felsefe, Biyoloji derslerinden 3'er etüt
-- Öğrenci 1 için
INSERT INTO etut (ogrenciid, tarih, konular, katilim, dersadi, dersvideo) VALUES
-- Türkçe
(1, '2025-06-25', 'Dil Bilgisi', 1, 'Türkçe', 'https://youtube.com/watch?v=turkce1'),
(1, '2025-06-26', 'Paragraf Çözümü', 1, 'Türkçe', 'https://youtube.com/watch?v=turkce2'),
(1, '2025-07-01', 'Anlatım Bozuklukları', 1, 'Türkçe', 'https://youtube.com/watch?v=turkce3'),

-- Tarih
(1, '2025-07-02', 'İnkılap Tarihi', 1, 'Tarih', 'https://youtube.com/watch?v=tarih1'),
(1, '2025-07-03', 'Osmanlı Kültürü', 1, 'Tarih', 'https://youtube.com/watch?v=tarih2'),
(1, '2025-07-04', 'Cumhuriyet Dönemi', 1, 'Tarih', 'https://youtube.com/watch?v=tarih3'),

-- Coğrafya
(1, '2025-07-05', 'İklim Tipleri', 1, 'Coğrafya', 'https://youtube.com/watch?v=cografya1'),
(1, '2025-07-05', 'Harita Bilgisi', 1, 'Coğrafya', 'https://youtube.com/watch?v=cografya2'),
(1, '2025-07-06', 'Türkiye’de Nüfus', 1, 'Coğrafya', 'https://youtube.com/watch?v=cografya3'),

-- Felsefe
(1, '2025-07-06', 'Bilgi Felsefesi', 1, 'Felsefe', 'https://youtube.com/watch?v=felsefe1'),
(1, '2025-07-07', 'Varlık Felsefesi', 1, 'Felsefe', 'https://youtube.com/watch?v=felsefe2'),
(1, '2025-07-08', 'Ahlak Felsefesi', 1, 'Felsefe', 'https://youtube.com/watch?v=felsefe3'),

-- Biyoloji
(1, '2025-07-08', 'Hücre Yapısı', 1, 'Biyoloji', 'https://youtube.com/watch?v=biyoloji1'),
(1, '2025-07-09', 'DNA ve Genetik', 1, 'Biyoloji', 'https://youtube.com/watch?v=biyoloji2'),
(1, '2025-07-10', 'Canlıların Sınıflandırılması', 1, 'Biyoloji', 'https://youtube.com/watch?v=biyoloji3');


-- Öğrenci 2 için
INSERT INTO etut (ogrenciid, tarih, konular, katilim, dersadi, dersvideo) VALUES
-- Türkçe
(2, '2025-06-25', 'Dil Bilgisi', 1, 'Türkçe', 'https://youtube.com/watch?v=turkce1'),
(2, '2025-06-26', 'Paragraf Çözümü', 1, 'Türkçe', 'https://youtube.com/watch?v=turkce2'),
(2, '2025-07-01', 'Anlatım Bozuklukları', 1, 'Türkçe', 'https://youtube.com/watch?v=turkce3'),

-- Tarih
(2, '2025-07-02', 'İnkılap Tarihi', 1, 'Tarih', 'https://youtube.com/watch?v=tarih1'),
(2, '2025-07-03', 'Osmanlı Kültürü', 1, 'Tarih', 'https://youtube.com/watch?v=tarih2'),
(2, '2025-07-04', 'Cumhuriyet Dönemi', 1, 'Tarih', 'https://youtube.com/watch?v=tarih3'),

-- Coğrafya
(2, '2025-07-05', 'İklim Tipleri', 1, 'Coğrafya', 'https://youtube.com/watch?v=cografya1'),
(2, '2025-07-05', 'Harita Bilgisi', 1, 'Coğrafya', 'https://youtube.com/watch?v=cografya2'),
(2, '2025-07-06', 'Türkiye’de Nüfus', 1, 'Coğrafya', 'https://youtube.com/watch?v=cografya3'),

-- Felsefe
(2, '2025-07-06', 'Bilgi Felsefesi', 1, 'Felsefe', 'https://youtube.com/watch?v=felsefe1'),
(2, '2025-07-07', 'Varlık Felsefesi', 1, 'Felsefe', 'https://youtube.com/watch?v=felsefe2'),
(2, '2025-07-08', 'Ahlak Felsefesi', 1, 'Felsefe', 'https://youtube.com/watch?v=felsefe3'),

-- Biyoloji
(2, '2025-07-08', 'Hücre Yapısı', 1, 'Biyoloji', 'https://youtube.com/watch?v=biyoloji1'),
(2, '2025-07-09', 'DNA ve Genetik', 1, 'Biyoloji', 'https://youtube.com/watch?v=biyoloji2'),
(2, '2025-07-10', 'Canlıların Sınıflandırılması', 1, 'Biyoloji', 'https://youtube.com/watch?v=biyoloji3');


-- --------------------------------------------------------

CREATE TABLE kullanici_tablosu (
  id SERIAL PRIMARY KEY,
  kullanici_adi VARCHAR(255) NOT NULL,
  sifre VARCHAR(255) NOT NULL,
  ad VARCHAR(255),
  soyad VARCHAR(255),
  eposta VARCHAR(50),
  universite VARCHAR(255),
  unibolum VARCHAR(255),
  unitur VARCHAR(50),
  unitkont VARCHAR(50),
  unitaban VARCHAR(50),
  unitavan VARCHAR(50),
  unitanitimvideo VARCHAR(150),
  fotoprofil VARCHAR(255),
  lastlogin VARCHAR(1000),
  ip VARCHAR(1000)
);

INSERT INTO kullanici_tablosu (kullanici_adi, sifre, ad, soyad, eposta, universite, unibolum, unitur, unitkont, unitaban, unitavan, unitanitimvideo, fotoprofil, lastlogin, ip) VALUES
('yakup123', 'demo', 'Yakup', 'ASLAN', 'yakup@example.com', 'İstanbul Teknik Üniversitesi', 'Bilgisayar Mühendisliği', 'Lisans', '80', '420', '490', 'https://youtu.be/video1', 'yakup.jpg', '2025-06-21 12:34:56', '192.168.1.1'),
('ayse456', '1234', 'Ayşe', 'Kaya', 'ayse@example.com', 'Boğaziçi Üniversitesi', 'Elektrik-Elektronik Müh.', 'Lisans', '90', '450', '500', 'https://youtu.be/video2', 'ayse.png', '2025-06-21 14:22:10', '192.168.1.2'),
('mehmet789', 'password', 'Mehmet', 'Yılmaz', 'mehmet@example.com', 'Ankara Üniversitesi', 'Makine Mühendisliği', 'Lisans', '85', '430', '480', 'https://youtu.be/video3', 'mehmet.jpg', '2025-06-22 10:11:23', '192.168.1.3'),
('seda101', 'qwerty', 'Seda', 'Şimşek', 'seda@example.com', 'Sabancı Üniversitesi', 'İnşaat Müh.', 'Lisans', '92', '470', '520', 'https://youtu.be/video4', 'seda.jpg', '2025-06-22 11:15:43', '192.168.1.4'),
('omer202', 'abcd1234', 'Ömer', 'Demir', 'omer@example.com', 'Koç Üniversitesi', 'Endüstri Mühendisliği', 'Lisans', '88', '460', '510', 'https://youtu.be/video5', 'omer.jpg', '2025-06-22 12:20:34', '192.168.1.5'),
('deniz303', '1234abcd', 'Deniz', 'Kurt', 'deniz@example.com', 'Boğaziçi Üniversitesi', 'Kimya Mühendisliği', 'Lisans', '91', '440', '510', 'https://youtu.be/video6', 'deniz.jpg', '2025-06-22 13:25:15', '192.168.1.6'),
('burak404', 'admin123', 'Burak', 'Aydın', 'burak@example.com', 'İstanbul Teknik Üniversitesi', 'Elektrik Mühendisliği', 'Lisans', '80', '420', '480', 'https://youtu.be/video7', 'burak.jpg', '2025-06-22 14:30:45', '192.168.1.7'),
('zeynep505', 'password1', 'Zeynep', 'Güven', 'zeynep@example.com', 'Ege Üniversitesi', 'Bilgisayar Mühendisliği', 'Lisans', '85', '430', '490', 'https://youtu.be/video8', 'zeynep.jpg', '2025-06-22 15:35:56', '192.168.1.8'),
('baran606', '123456', 'Baran', 'Çelik', 'baran@example.com', 'Yıldız Teknik Üniversitesi', 'Mekatronik Mühendisliği', 'Lisans', '88', '460', '500', 'https://youtu.be/video9', 'baran.jpg', '2025-06-22 16:40:23', '192.168.1.9'),
('elif707', 'securepassword', 'Elif', 'Arslan', 'elif@example.com', 'Orta Doğu Teknik Üniversitesi', 'Çevre Mühendisliği', 'Lisans', '91', '450', '510', 'https://youtu.be/video10', 'elif.jpg', '2025-06-22 17:45:30', '192.168.1.10'),
('selim808', '1111abcd', 'Selim', 'Yıldız', 'selim@example.com', 'Boğaziçi Üniversitesi', 'İnşaat Mühendisliği', 'Lisans', '90', '460', '520', 'https://youtu.be/video11', 'selim.jpg', '2025-06-23 09:50:12', '192.168.1.11'),
('aylin909', 'qwerty123', 'Aylin', 'Öztürk', 'aylin@example.com', 'İstanbul Üniversitesi', 'Makine Mühendisliği', 'Lisans', '87', '440', '490', 'https://youtu.be/video12', 'aylin.jpg', '2025-06-23 10:55:20', '192.168.1.12'),
('hakan1010', 'hakan123', 'Hakan', 'Eren', 'hakan@example.com', 'Hacettepe Üniversitesi', 'Elektrik-Elektronik Müh.', 'Lisans', '82', '430', '470', 'https://youtu.be/video13', 'hakan.jpg', '2025-06-23 11:15:10', '192.168.1.13'),
('gokhan1111', 'gokhan1234', 'Gökhan', 'Kaya', 'gokhan@example.com', 'İstanbul Teknik Üniversitesi', 'Endüstri Mühendisliği', 'Lisans', '89', '450', '500', 'https://youtu.be/video14', 'gokhan.jpg', '2025-06-23 12:10:05', '192.168.1.14'),
('sibel1212', 'password123', 'Sibel', 'Özdemir', 'sibel@example.com', 'Koç Üniversitesi', 'Biyomühendislik', 'Lisans', '94', '480', '530', 'https://youtu.be/video15', 'sibel.jpg', '2025-06-23 13:20:22', '192.168.1.15'),
('mehmet1313', 'mehmetpass', 'Mehmet', 'Kaya', 'mehmet@example.com', 'Hacettepe Üniversitesi', 'Kimya Mühendisliği', 'Lisans', '93', '470', '520', 'https://youtu.be/video16', 'mehmet.jpg', '2025-06-23 14:25:10', '192.168.1.16'),
('cem1414', 'qwerty321', 'Cem', 'Arslan', 'cem@example.com', 'Yeditepe Üniversitesi', 'Gıda Mühendisliği', 'Lisans', '86', '420', '480', 'https://youtu.be/video17', 'cem.jpg', '2025-06-23 15:30:40', '192.168.1.17'),
('dilek1515', 'dilekpass', 'Dilek', 'Demir', 'dilek@example.com', 'Marmara Üniversitesi', 'Peyzaj Mimarlığı', 'Lisans', '80', '410', '480', 'https://youtu.be/video18', 'dilek.jpg', '2025-06-23 16:35:35', '192.168.1.18'),
('baris1616', 'baris1234', 'Barış', 'Koç', 'baris@example.com', 'İstanbul Üniversitesi', 'Fizik Mühendisliği', 'Lisans', '87', '440', '490', 'https://youtu.be/video19', 'baris.jpg', '2025-06-23 17:40:20', '192.168.1.19'),
('serkan1717', 'serkanpass', 'Serkan', 'Büyük', 'serkan@example.com', 'Gazi Üniversitesi', 'Makine Mühendisliği', 'Lisans', '91', '460', '510', 'https://youtu.be/video20', 'serkan.jpg', '2025-06-23 18:45:10', '192.168.1.20');


-- --------------------------------------------------------

CREATE TABLE ogrencideneme (
  sira SERIAL PRIMARY KEY,
  ogrencid INT,
  turkced VARCHAR(255),
  turkcey VARCHAR(255),
  matd VARCHAR(255),
  maty VARCHAR(255),
  sosd VARCHAR(255),
  sosy VARCHAR(255),
  fend VARCHAR(255),
  feny VARCHAR(255),
  tarih DATE,
  tyt_puan VARCHAR(255)
);
-- Öğrenci 1 için 3 deneme
INSERT INTO ogrencideneme (ogrenciid, turkced, turkcey, matd, maty, sosd, sosy, fend, feny, tarih, tyt_puan)
VALUES
(1, '18', '2', '15', '5', '17', '3', '16', '4', '2025-06-01', '355'),
(1, '20', '0', '16', '4', '18', '2', '17', '3', '2025-06-08', '370'),
(1, '22', '1', '17', '3', '19', '1', '18', '2', '2025-06-15', '385');

-- Öğrenci 2 için 3 deneme
INSERT INTO ogrencideneme (ogrenciid, turkced, turkcey, matd, maty, sosd, sosy, fend, feny, tarih, tyt_puan)
VALUES
(2, '12', '8', '10', '10', '13', '7', '14', '6', '2025-06-01', '290'),
(2, '14', '6', '12', '8', '15', '5', '13', '7', '2025-06-08', '310'),
(2, '15', '5', '13', '7', '16', '4', '15', '5', '2025-06-15', '325');
-- --------------------------------------------------------

CREATE TABLE ogrencitest (
  sira SERIAL PRIMARY KEY,
  ogrencid INT,
  dersadi VARCHAR(255),
  cozulensoru INT,
  dogrusayisi INT,
  yanlisayisi INT,
  netsayisi REAL,
  tarih DATE
);
-- Öğrenci ID 1 için 10 test sonucu
INSERT INTO test_sonuclari (ogrenciid, ders, dsayisi, ysayisi, net, testid) VALUES
(1, 'Matematik', 30, 5, 25, 101),
(1, 'Türkçe', 28, 2, 26, 102),
(1, 'Fizik', 20, 5, 15, 103),
(1, 'Kimya', 18, 2, 16, 104),
(1, 'Biyoloji', 24, 4, 20, 105),
(1, 'Tarih', 15, 3, 12, 106),
(1, 'Coğrafya', 22, 1, 21, 107),
(1, 'Coğrafya', 19, 1, 18, 108),
(1, 'Matematik', 10, 0, 10, 109),
(1, 'Matematik', 25, 5, 20, 110);

-- Öğrenci ID 2 için 10 test sonucu
INSERT INTO test_sonuclari (ogrenciid, ders, dsayisi, ysayisi, net, testid) VALUES
(2, 'Matematik', 25, 3, 22, 201),
(2, 'Türkçe', 27, 1, 26, 202),
(2, 'Fizik', 18, 6, 12, 203),
(2, 'Kimya', 21, 3, 18, 204),
(2, 'Biyoloji', 26, 4, 22, 205),
(2, 'Tarih', 14, 2, 12, 206),
(2, 'Coğrafya', 20, 5, 15, 207),
(2, 'Coğrafya', 16, 0, 16, 208),
(2, 'Matematik', 10, 2, 8, 209),
(2, 'Matematik', 23, 4, 19, 210);


-- --------------------------------------------------------

CREATE TABLE sorular (
  id SERIAL PRIMARY KEY,
  dersadi VARCHAR(255) NOT NULL,
  soru TEXT NOT NULL,
  secenek1 TEXT NOT NULL,
  secenek2 TEXT NOT NULL,
  secenek3 TEXT NOT NULL,
  secenek4 TEXT NOT NULL,
  secenek5 TEXT NOT NULL,
  dogrucevap VARCHAR(1) NOT NULL,
  testid INT
);

-- --------------------------------------------------------

CREATE TABLE testizin (
  id SERIAL PRIMARY KEY,
  testid INT,
  ogrencid INT,
  katilim VARCHAR(255)
);

-- --------------------------------------------------------

CREATE TABLE testler (
  id SERIAL PRIMARY KEY,
  dersadi VARCHAR(255) NOT NULL,
  testadi VARCHAR(255) NOT NULL,
  sorusayisi INT NOT NULL,
  eklenmetarihi DATE NOT NULL
);

INSERT INTO testler (testadi, sorusayisi, dersadi, eklenmetarihi) VALUES

('Paragrafta Anlam', 20, 'Türkçe', '2025-06-21'),
('Sözcükte Anlam', 25, 'Türkçe', '2025-05-20'),
('Dil Bilgisi ve Yazım Kuralları', 30, 'Türkçe', '2025-04-30'),

-- Matematik
('Temel Matematik Problemleri', 20, 'Matematik', '2025-06-20'),
('Çarpanlara Ayırma ve Özdeşlikler', 25, 'Matematik', '2025-05-18'),
('Fonksiyonlar ve Grafikler', 30, 'Matematik', '2025-04-25'),

-- Tarih
('İnkılap Tarihi ve Atatürkçülük', 15, 'Tarih', '2025-06-18'),
('Osmanlı Devleti Kültür ve Medeniyeti', 20, 'Tarih', '2025-05-15'),
('Çağdaş Türk ve Dünya Tarihi', 25, 'Tarih', '2025-04-29'),

-- Felsefe (2 kayıt)
('Bilgi Felsefesi', 10, 'Felsefe', '2025-06-19'),
('Ahlak Felsefesi', 12, 'Felsefe', '2025-05-10');

-- --------------------------------------------------------

CREATE TABLE test_sonuclari (
  id SERIAL PRIMARY KEY,
  ogrencid INT NOT NULL,
  ders VARCHAR(255) NOT NULL,
  dsayisi INT NOT NULL,
  ysayisi INT NOT NULL,
  net INT NOT NULL,
  testid INT
);

-- --------------------------------------------------------

CREATE TABLE ticket (
  id SERIAL PRIMARY KEY,
  ogrencid INT,
  mesaj TEXT,
  cevap TEXT,
  konu VARCHAR(255)
);

-- Öğrenci 1 için 5 kayıt
INSERT INTO ticket (ogrenciid, mesaj, cevap, konu) VALUES
(1, 'Sisteme giriş yapamıyorum.', 'Şifrenizi sıfırlayarak tekrar deneyin.', 'Giriş Sorunu'),
(1, 'Etüt saatim çakışıyor.', 'Saat değişikliği için öğretmeninizle iletişime geçin.', 'Etüt Programı'),
(1, 'PDF dosyası açılmıyor.', 'PDF okuyucunuzun güncel olduğundan emin olun.', 'Materyal Sorunu'),
(1, 'Test sonucu görünmüyor.', 'Lütfen sayfayı yenileyip tekrar deneyin.', 'Test Sorunu'),
(1, 'Canlı ders bağlantısı yok.', 'Bağlantı 10 dakika önce eklenecektir.', 'Canlı Ders');

-- Öğrenci 2 için 5 kayıt
INSERT INTO ticket (ogrenciid, mesaj, cevap, konu) VALUES
(2, 'Yanlış etüt eklenmiş.', 'Etüt sorumlusu ile görüşünüz.', 'Etüt Düzenleme'),
(2, 'Sistem çok yavaş.', 'Yoğunluk nedeniyle geçici olabilir, tekrar deneyin.', 'Performans Sorunu'),
(2, 'Sınav tarihi yanlış.', 'Yeni tarih danışman öğretmeninize iletildi.', 'Sınav Planlaması'),
(2, 'Sorular eksik görünüyor.', 'Teknik ekip kontrol ediyor.', 'Test Sorunu'),
(2, 'Profil bilgilerimi değiştiremiyorum.', 'Bu işlem için admin onayı gereklidir.', 'Profil Güncelleme');

-- --------------------------------------------------------
CREATE TABLE canli_dersler (
    id SERIAL PRIMARY KEY,
    ogrenciid INT NOT NULL,
    ders_adi VARCHAR(255) NOT NULL,
    konu VARCHAR(255) NOT NULL,
    ogretmen VARCHAR(255) NOT NULL,
    ders_tarihi TIMESTAMP NOT NULL
);
INSERT INTO canli_dersler (ogrenciid, ders_adi, konu, ogretmen, ders_tarihi) VALUES
(1, 'Matematik', 'Denklemler', 'Ali Yılmaz', '2025-06-10'),
(1, 'Türkçe', 'Paragraf Yorumu', 'Ayşe Demir', '2025-06-15'),
(1, 'Fizik', 'Kuvvet ve Hareket', 'Mehmet Kara', '2025-06-22'),
(1, 'Tarih', 'İnkılaplar', 'Fatma Şahin', '2025-07-03'),
(1, 'Coğrafya', 'İklim Tipleri', 'Ahmet Doğan', '2025-07-07'),
(1, 'Felsefe', 'Bilgi Felsefesi', 'Zeynep Aksoy', '2025-06-01'),
(1, 'Kimya', 'Asit-Baz', 'Hakan Koç', '2025-08-05'),
(1, 'Biyoloji', 'Hücre Bölünmesi', 'Elif Aydın', '2025-08-10'),
(1, 'Matematik', 'Fonksiyonlar', 'Ali Yılmaz', '2025-08-15'),
(1, 'Türkçe', 'Sözcükte Anlam', 'Ayşe Demir', '2025-07-21'),
(1, 'Tarih', 'Osmanlı Kültürü', 'Fatma Şahin', '2025-08-02'),
(1, 'Fizik', 'İş, Güç, Enerji', 'Mehmet Kara', '2025-06-29'),
(1, 'Kimya', 'Karışımlar', 'Hakan Koç', '2025-07-27'),
(1, 'Coğrafya', 'Yer Şekilleri', 'Ahmet Doğan', '2025-07-25'),
(1, 'Biyoloji', 'Canlıların Sınıflandırılması', 'Elif Aydın', '2025-08-08');
INSERT INTO canli_dersler (ogrenciid, ders_adi, konu, ogretmen, ders_tarihi) VALUES
(2, 'Matematik', 'Problemler', 'Ali Yılmaz', '2025-06-12'),
(2, 'Türkçe', 'Cümlede Anlam', 'Ayşe Demir', '2025-06-14'),
(2, 'Fizik', 'Elektrik Akımı', 'Mehmet Kara', '2025-06-20'),
(2, 'Tarih', 'Çağdaş Türk Tarihi', 'Fatma Şahin', '2025-07-05'),
(2, 'Coğrafya', 'Nüfus Politikaları', 'Ahmet Doğan', '2025-07-10'),
(2, 'Felsefe', 'Ahlak Felsefesi', 'Zeynep Aksoy', '2025-06-02'),
(2, 'Kimya', 'Kimyasal Tepkimeler', 'Hakan Koç', '2025-08-06'),
(2, 'Biyoloji', 'Dolaşım Sistemi', 'Elif Aydın', '2025-08-09'),
(2, 'Matematik', 'Permütasyon', 'Ali Yılmaz', '2025-08-14'),
(2, 'Türkçe', 'Yazım Kuralları', 'Ayşe Demir', '2025-07-22'),
(2, 'Tarih', 'Kurtuluş Savaşı', 'Fatma Şahin', '2025-08-01'),
(2, 'Fizik', 'Manyetizma', 'Mehmet Kara', '2025-06-28'),
(2, 'Kimya', 'Organik Bileşikler', 'Hakan Koç', '2025-07-29'),
(2, 'Coğrafya', 'Türkiye’de Tarım', 'Ahmet Doğan', '2025-07-24'),
(2, 'Biyoloji', 'Sinir Sistemi', 'Elif Aydın', '2025-08-07');

# ReadDataFromESP32
Kocaeli Üniversitesi Bitirme Projesi olan "BLE ile İç Mekan Konum Tespiti" isimli tezimizin bir modülü olan, ESP32' den gelen RSSI değerlerinin okunması ve bu değerlerin Firebase bulut platformuna gönderilmesini sağlamak için hazırlanan arayüzdür. Bu arayüzde; ESP32' den gelen RSSI değerleri okunur, Firebase' e gönderilir. Daha sonrasında Java programlama dilini kullanarak geliştirilecek olan arayüzde, Firebase' e gönderilmiş olan bu veriler çekilerek tahmini konumu gösteren bir simülasyon yapılması planlanmıştır.

Projenin arayüzü aşağıdaki gibidir:

<img src="https://i.hizliresim.com/jvzrato.jpg"></img>

Projenin çalışma prensibi şu şekildedir:

- Proje çalıştırılmadan önce ESP32 cihazının bilgisayar bağlı olmalıdır.
- Port' tan cihazın bağlı olduğu port seçilmelidir.
- Beacon menüsünden hangi Beacon' a ait RSSI çekilmek isteniyorsa o Beacon seçilmelidir.
- "Start" butonuna basılarak seçilen cihazın RSSI değerleri çekilebilir.
- "Create Average RSSI Value" butonuna basılarak, cihazdan gelen ortalama RSSI değeri hesaplanır.
- "Send Firebase" butonuna basılarak gelen değerler Firebase' e gönderilir.
- Sırayla 3 Beacon cihazı için bu işlemler tekrarlanır.

Hami' nin Java programlama dili ile oluşturduğu arayüz aşağıdaki gibidir:

<img src="https://i.hizliresim.com/64n7f00.png></img>

<img src="https://i.hizliresim.com/r2u8irb.png"></img>

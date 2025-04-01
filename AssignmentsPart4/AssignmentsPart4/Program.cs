using AssignmentsPart4;

List<Car> cars = new List<Car>
{
     new Car("Toyota", "Corolla", 6.5, 5000),
     new Car("BMW", "X5", 9.0, 5000),
     new Car("Mercedes", "C200", 8.2, 5000)
};
foreach (var car in cars)
{
    Console.WriteLine($"Marka: {car.Brand}, Model: {car.Model}, 100 km'de Yaktığı Yakıt: {car.FuelConsumption} litre, Toplam Yakıt Tüketimi: {car.CalculateFuelConsumption()} litre");
}
/* Görsel Programlama Nedir?
Görsel programlama, programlama süreçlerini metin tabanlı kod yazımı yerine grafiksel veya görsel öğeler kullanarak gerçekleştiren bir programlama yaklaşımıdır. Bu yöntem, programcıların bloklar, düğümler veya akış şemaları gibi görsel bileşenler aracılığıyla kod yazmalarına olanak tanır. Görsel programlama dilleri (VPL - Visual Programming Language), kullanıcıların kod bloklarını sürükleyip bırakmasını, mantıksal akışları görsel olarak temsil etmesini ve doğrudan bir arayüz üzerinden işlemler gerçekleştirmesini sağlar.

Öne çıkan görsel programlama dillerine örnek olarak şunlar verilebilir:

Scratch: Eğitim amaçlı kullanılan, özellikle çocuklar için tasarlanmış blok tabanlı bir programlama dili.

Blockly: Google tarafından geliştirilen ve görsel blokları metin tabanlı dillere dönüştüren bir platform.

LabVIEW: Mühendislik ve bilimsel uygulamalarda kullanılan grafiksel programlama ortamı.

Unreal Engine Blueprints: Oyun geliştirme sürecinde kod yazmadan oyun mekanikleri oluşturmak için kullanılan bir sistem.

--- Metin Tabanlı Programlamadan Farkları
Özellik	              Görsel Programlama	                                                    Metin Tabanlı Programlama
Kod Yazımı	          Görsel bloklar veya grafiksel nesnelerle yapılır.	                        Doğrudan metin ve sözdizimi kullanılarak yazılır.
Öğrenme Eğrisi	      Daha kolay, özellikle yeni başlayanlar için uygundur.	                    Daha dik bir öğrenme eğrisi vardır, sintaks kurallarına dikkat edilmelidir.
Okunabilirlik	      Akış ve mantık görsel olarak anlaşılır.	                                Kod satırları halinde takip edilmesi gerekir.
Hata Ayıklama	      Daha sezgiseldir, çünkü mantık hataları görsel olarak fark edilebilir.	Hata mesajlarını okuyarak ve kodu analiz ederek düzeltilmelidir.
Esneklik	          Karmaşık projelerde sınırlamalar olabilir.	                            Daha fazla özelleştirme ve optimizasyon imkanı sunar.
Kullanım Alanları	  Eğitim, oyun geliştirme, mühendislik simülasyonları.	                    Web geliştirme, yapay zeka, veri analizi, sistem programlama gibi geniş bir alan.

Sonuç
Görsel programlama, özellikle programlamaya yeni başlayanlar için öğrenmesi kolay ve sezgisel bir yöntem sunarken, metin tabanlı programlama ise daha esnek ve geniş kapsamlı çözümler geliştirmek için gereklidir. Görsel programlama, eğitim amaçlı ve belirli alanlarda (örneğin, oyun geliştirme veya mühendislik uygulamaları) oldukça avantajlı olabilir. Ancak, büyük ölçekli projelerde genellikle metin tabanlı diller tercih edilir.
*/
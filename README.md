# Clean Architecture Course
Clean Architecture mimarilerinden Onion Architecture kullanılarak Web API geliştirilmiştir.

**Design Patternler** 

* Repository Pattern
* Unit Of Work
* Mediator 
* CQRS

## Onion Architecture 
 Onion Architecture, yazılım süreçlerine daha gelişmiş bir katmansal mimari sunarak, 
 klasik çok katmanlıdaki bazı problemleri aşabilmemizi ve ayrıca olabilecek değişiklik 
 durumlarında daha az çaba sarf edilerek hızlı bir çözüm sunmamızı ve tüm bunları yaparken 
 uygulama katmanları arasında Gevşek Bağlılık(Loose Coupling) oluşturmamızı sağlamaktadır.

## WEB API 
Uygulamamıza gelen kullanıcının isteklerini karşıladığımız ve bunlara gerekli 
cevabı döndüğümüz arayüzdür. WebAPI sunum katmanının içerisinde yer alır.
WebAPI'yi istenilen başka her hangi bir uygulamaya da servis edebiliriz.

## Repository Pattern
 Veritabanına veri ekleme, güncelleme ve okuma gibi CRUD (Create Read Update Delete)
 işlemlerimiz için oluşturmuş olduğumuz kodların tekrar kullanılabilirliğini sağlamaktır.

## Unit Of Work
Veritabanı ile yapılacak olan tüm işlemleri, tek bir kanal aracılığı ile gerçekleştirme ve 
hafızada tutma işlemlerini sunmaktadır. Bu sayede işlemlerin toplu halde gerçekleştirilmesi 
ve hata durumunda geri alınabilmesi sağlamaktadır.

## Mediator 
Mediator modeli, tek bir aracı(mediator) nesnesi içerisinde çeşitli nesneler arasındaki 
karmaşık ilişkiler ağını yönetmenize olanak tanır.

## CQRS 
CQRS mimarisi için CQS(Komut Sorgulama Ayırma) ilkesi üzerine 
kurulmuş olduğunu söyleyebiliriz. CQS’in ana fikri veriyi okuyan operasyonlarımız ile 
veriyi güncelleyen operasyonlarmızın interfacelerini ayırmaktır. CQRS’te ise buna business
modellerimizin ayrılmasıda eklenmektedir. 

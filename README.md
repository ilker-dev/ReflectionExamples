# Reflection Örnekleri ve Sunumu


 # Reflection Nedir ? 
 
Reflection runtime'da assembly içerisindeki classlar methodlar propertylerden bilgi alınmasını sağlayan bir .net sınıfıdır.Bu özellik .net'in oldukça güçlü bir özelliğidir tabiki diğer dillerde reflective yapılarla meta data üzerindeki verilere erişebilmektedir.
Reflection sınıfı bu işi yapabilmek için "System.Reflection" sınıfını kullanır .Net tabanındaki bütün nesnelerin birer tipi vardır ve Reflection sınıfı herhangi bir nesnenin methodununa property'sine yada attribute'une erişmek istediği zaman runtime'da "System.Type" sınıfını kullanır "Type" sınıfı abstract bir sınıftır ve MemberInfo sınıfından türemiştir bir çok methoda ve property'e sahiptir.Bu sınıf herhangi bir sınıfın özelliklerini okuyabilir , methodlarını , constructors methodlarını okuyabilir ve  bazılarını manipüle edebilir.

 # Reflection Sınıfının Yetenekleri
      1. Introspection (Gözlemleme)
      2. Manipulation (Değiştirme)
      3. Instantiation (Örnekleme)
      4. Invocation (Çağırma)
      5. Type Loading(Tip Yükleme)
      
 # Bir Type Instance'ı yakalamak
   Başta bahsettiğimiz gibi reflection sınıfı çalışma zamanında yeteneklerini kullanabilmek için nesnelerin tiplerini kullanır bir nesnenin tip    bilgisine ulaşmak için bir kaç method bulunmaktadır.
   1.Object GetType()
   2.Assembly GetTypes()
   3.typeof(SINIF)
   
  
   
   
  

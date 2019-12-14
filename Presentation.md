# Reflection Örnekleri ve Sunumu


 # Reflection Nedir ? 
 
Reflection runtime'da assembly içerisindeki classlar methodlar propertylerden bilgi alınmasını sağlayan bir .net sınıfıdır.Bu özellik .net'in oldukça güçlü bir özelliğidir tabiki diğer diller de reflective yapılarla meta data üzerindeki verilere erişebilmektedir.
Reflection sınıfı bu işi yapabilmek için "System.Reflection" sınıfını kullanır .Net tabanındaki bütün nesnelerin birer tipi vardır ve Reflection sınıfı herhangi bir nesnenin methodununa property'sine yada attribute'une erişmek istediği zaman runtime'da "System.Type" sınıfını kullanır "Type" sınıfı abstract bir sınıftır ve MemberInfo sınıfından türemiştir bir çok methoda ve property'e sahiptir.Bu sınıf herhangi bir sınıfın özelliklerini okuyabilir , methodlarını , constructors methodlarını okuyabilir ve  bazılarını manipüle edebilir.
 # Assembly'i Anlamak
 
 Assembly .net framework üzerinde compile edilmiş tüm dll ve exe dosyalarına denir bu dosyalar projelerle ilgili metadata bilgilerini içinde saklarlar.Bir application'un assemblydeki yansımasını görmek için şu adımları izleye biliriz.
 
 Start  => Search => dev or developer command prompt => ildasm  Pronounce => "Eye Ell Dazzem"
 
 # Reflection Sınıfının Yetenekleri
      1. Introspection (Gözlemleme)
      2. Manipulation (Değiştirme)
      3. Instantiation (Örnekleme)
      4. Invocation (Çağırma)
      5. Type Loading(Tip Yükleme)
      
 # Bir Type Instance'ı yakalamak
        1.Object GetType()
        2.Assembly GetTypes()
        3.typeof(SINIF)         
 
Başta bahsettiğimiz gibi reflection sınıfı çalışma zamanında yeteneklerini kullanabilmek için nesnelerin tiplerini kullanır bir nesnenin tip  bilgisine ulaşmak için bir kaç method bulunmaktadır. 
     
# Çok kullanılan Tür Özellikleri
    1.Name
    2.NameSpace
    3.FullName
    4.BaseType
    5.Attributes
    6.Implements
    7.IsClass
    8.IsInterface
    9.IsEnum
    9.IsPrimitive
    10.IsArray
    11.IsPublic
    12.IsAbstract
    13.IsGenericType
    
Bu propertyler type sınıfı altındaki en çok kullanılan propertylerdir bu propertyler kullanılarak program akışında kararlar alınabilinir.
Örnek vermek gerekirse bir sınıf altındaki methodu invoke etmek istediğimiz zaman hangi instance üzerindeki methodu invoke etmek istediğimizi belirtmek durumundayızdır çünkü program bu instance'ı belirtmez isek assembly üzerindeki hangi nesne örneğini kullanacağını bilemez.Fakat bildiğimi gibi abstract sınıflar için bir nesne örneği türetilmez bu yüzden "IsAbstract" ifadesini kontrol ederek instance kullanmadan method invoke edebiliriz.
    
 # Çok kullanılan Tür methodları
    1.GetFields()
    2.GetProperties()
    3.GetMethods()
    4.GetConstructors()
Not: yukardaki Fields Properties Methods methodları bütün nesne üzerindeki ilgili özellikleri getirir bunları tekil olarak da       kullanabilmekteyiz.Örn:Type.GetProperty(PROPERTY_NAME) gibi.
  
       
# Instantiation(Örnekleme) Teknikleri
    1.ConstructorInfo Invoke()
    2.Activator CreateInstance() 
    
Reflection kütüphanesi kullanılarak herhangi bir sınıfın instance'ı üretilebilir instance aslında assembly üzerindeki nesnenin bir örneğini üretmek demektir ve bu iki farklı yöntemle yapılabilir aralarında herhangi bir fark bulunmamaktadır. Bu işlemlerin terimsel adı <b>"Late Binding"</b> olarak geçmektedir. yaptığı iş aslnda direkt olarak şudur;
<b> Customer customer = new Customer()</b>
fakat burda dikkat edilmesi gereken olay eğer biz instance oluşturacağımız sınıfın tipini kodlama zamanında biliyorsak mutlaka <b>"Early Binding" </b> olarak kullanmamız gerekmektedir.

# Invocation(Çağırma) Teknikleri
    1.Use an Interface
    2.Method Invoke
    3.Define a Delegate
    4.Create a Typed Func
    5.Create an Expression Tree
    6.Use a dynamic Type
    
Reflection kütüphanesi kullanılarak nesne üzerindeki methodları cağırabileceğimizi söylemiştik.bunları yapabilmek için birden fazla teknik bulunmakta bunlardan bir kaçına burada değineceğim.

   
# Reflection Üzerine ...

Reflection işleminde nesnenin yüklenip işlenmesi için büyük miktarda metadata type gerektirir. Buda büyük bir bellek ek yükü ve daha yavaş execution işlemine sebep olabilir.Özellik Property manipulation işlemi yaklaşık 2.5x-3x yavaştır ve Method Invocation işlemi ise 3.5x-4x yavaştır. Ayrıca, reflection belli bir seviyede karıştırıcı olabilir ve bu nedenle birlikte kodlamayı zorlaştıran ve koda ekleyebileceği bir karmaşıklık unsuru vardır.Buna üstadın sözüyle devam edelim.

 <b>SCOTT HANSELMAN</b> : Using reflection you often make more problems than you solve. 
 (Reflection kullanmak sıklıkla çözdüğünden fazla problem yaratır.)


   
   
  

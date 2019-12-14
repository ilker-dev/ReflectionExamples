# Reflection Örnekleri ve Sunumu


 # Reflection Nedir ? 
 
Reflection runtime'da assembly içerisindeki classlar methodlar propertylerden bilgi alınmasını sağlayan bir .net sınıfıdır.Bu özellik .net'in oldukça güçlü bir özelliğidir tabiki diğer diller de reflective yapılarla meta data üzerindeki verilere erişebilmektedir.
Reflection sınıfı bu işi yapabilmek için "System.Reflection" sınıfını kullanır .Net tabanındaki bütün nesnelerin birer tipi vardır ve Reflection sınıfı herhangi bir nesnenin methodununa property'sine yada attribute'une erişmek istediği zaman runtime'da "System.Type" sınıfını kullanır "Type" sınıfı abstract bir sınıftır ve MemberInfo sınıfından türemiştir bir çok methoda ve property'e sahiptir.Bu sınıf herhangi bir sınıfın özelliklerini okuyabilir , methodlarını , constructors methodlarını okuyabilir ve  bazılarını manipüle edebilir.

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
 
 Başta bahsettiğimiz gibi reflection sınıfı çalışma zamanında yeteneklerini kullanabilmek için nesnelerin tiplerini kullanır bir nesnenin tip   bilgisine ulaşmak için bir kaç method bulunmaktadır. 
     
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

   
  
   
   
  

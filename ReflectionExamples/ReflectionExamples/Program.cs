using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(AssemblyExample).IsAbstract);

            //   Types();

            //PropertyInfoGetMethod(new AssemblyExample());

            //PropertyInfoSetMethod(new AssemblyExample());


            #region [ Reflection Helper]

            //var example = new AssemblyExample();

            //example.TestProperty = new Test() { TestNumber = 1 };

            //Console.WriteLine(GetPropValue(example, "TestProperty.TestNumber"));

            #endregion



            //GetConstructors(typeof(AssemblyExample));

            //GetMethods(typeof(AssemblyExample));

            //GetFieldsAndProperties(typeof(AssemblyExample));


            //InvokeMethod(typeof(AssemblyExample), "Method1");

            DynamicInvoke(typeof(AssemblyExample));


            Console.ReadLine();

        }


        #region [ TYPE ]
        public static void Types()
        {
            //bir obejct üzerinden type almak için
            Type assemblyExampleClass = new AssemblyExample().GetType();

            //Current Assembly  içindeki typeları almak için:
            Type exampleType = Assembly.GetExecutingAssembly().GetTypes().Single(type => type.Name == "AssemblyExample");

            //Typeof kullanarak bir type ornegi oluşturmak
            Type exampleClass = typeof(AssemblyExample);

        }
        #endregion

        #region [  Manipulation ]

        public static void PropertyInfoGetMethod(object assemblyExample)
        {
            Type exampleType = assemblyExample.GetType();
            PropertyInfo property = exampleType.GetProperty("Name");
            string name = (string)property.GetValue(assemblyExample);
            Console.WriteLine(name);
        }

        public static void PropertyInfoSetMethod(object assemblyExample)
        {
            //early binding ile herhangi bir set işlemi yapamıyoruz cunku private set bir method tanımladık
            //o yüzden bu satır compile timeda bize direkt olarak bir hata fırlatacaktır
            //AssemblyExample example = new AssemblyExample();
            //example.ID = Guid.NewGuid();
            Type exampleType = assemblyExample.GetType();
            PropertyInfo property = exampleType.GetProperty("ID");
            Console.WriteLine(property.GetValue(assemblyExample));
            property.SetValue(assemblyExample, Guid.NewGuid());
            Console.WriteLine(property.GetValue(assemblyExample));
        }

        //reflection helper bu şekilde çalışıyor 
        public static Object GetPropValue(Object obj, String propName)
        {
            string[] nameParts = propName.Split('.');
            if (nameParts.Length == 1)
            {
                return obj.GetType().GetProperty(propName).GetValue(obj, null);
            }

            foreach (String part in nameParts)
            {
                if (obj == null) { return null; }

                Type type = obj.GetType();
                PropertyInfo info = type.GetProperty(part);
                if (info == null) { return null; }

                obj = info.GetValue(obj, null);
            }
            return obj;
        }

        #endregion

        #region [ Introspection  ]

        public static void GetConstructors(Type classType)
        {
            var constructors = classType.GetConstructors();

            //Spesifik olrak bu constructoru cagırabılırız.

            ConstructorInfo constructor = classType.GetConstructor(new[] { typeof(String), typeof(int) });
            constructor.Invoke(new object[] { "PARAMETER", 3 });
        }

        public static void GetMethods(Type classType)
        {
            //Nonepublic olan methodları çektik
            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
               .Where(m => !m.IsSpecialName)
              .OrderBy(m => m.Name)
              .ToArray();

            foreach (MethodInfo item in publicMethods)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void GetFieldsAndProperties(Type classType)
        {
            //public olan methodları çektik
            FieldInfo[] publicFields = classType.GetFields(
                   BindingFlags.Instance |
                   BindingFlags.Public);

            PropertyInfo[] publicProperties = classType.GetProperties(
                   BindingFlags.Instance |
                   BindingFlags.Public);

            foreach (FieldInfo item in publicFields)
            {
                Console.WriteLine("Field : " + item.Name);
            }

            foreach (PropertyInfo item in publicProperties)
            {
                Console.WriteLine("Property : " + item.Name);
            }
        }






        #endregion

        #region [ Invocation ]

        public static void InvokeMethod(Type classType, string methodName)
        {
            var instance = Activator.CreateInstance(classType);
            MethodInfo method = classType.GetMethod(methodName);

            method.Invoke(instance, null);

        }
        public static void DynamicInvoke(Type classType)
        {
            Type dynamicType = Assembly
                 .GetExecutingAssembly()
                 .GetType("ReflectionExamples.AssemblyExample");

            dynamic exampleClass = Activator.CreateInstance(dynamicType);
            exampleClass.Method3("test");

        }


        #endregion


    }
}

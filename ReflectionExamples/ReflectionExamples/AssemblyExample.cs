using System;

namespace ReflectionExamples
{
    public class AssemblyExample
    {
        public AssemblyExample()
        {
            ID = Guid.NewGuid();

            Console.WriteLine("Constructor 1 çalıştı");
        }

        public AssemblyExample(string test)
        {
            ID = Guid.NewGuid();

            Console.WriteLine($"Constructor 2 çalıştı paremetreler:{test}");
        }

        public AssemblyExample(string test, int a)
        {
            ID = Guid.NewGuid();

            Console.WriteLine($"Constructor 3 çalıştı paremetreler:{test}  ,  {a}");
        }
        public Guid ID { get; private set; }

        public void Method1() { Console.WriteLine("Method 1 Çalıştı"); }

        private void MethodPrivate() { }

        public bool Method2() { return false; }

        public void Method3(string parametreString) { Console.WriteLine("Method 3 Çalıştı Parametre :" + parametreString); }

        private string _name = "ilker";

        public string Name { get { return _name; } set { _name = value; } }

        public Test TestProperty { get; set; }
    }

    public class Test
    {
        public int TestNumber { get; set; }
    }
}

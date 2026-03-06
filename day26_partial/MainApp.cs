namespace day26_partial
{
    internal class MainApp
    {
        // 1. Partial Class - 3개로 분리한 경우
        partial class Class1
        {
            public void Run() { }
        }

        partial class Class1
        {
            public void Get() { }
        }

        partial class Class1
        {
            public void Put() { }
        }

        // 2. Partial Struct
        partial struct Struct1
        {
            public int ID;
        }

        partial struct Struct1
        {
            public string Name;

            public Struct1(int id, string name)
            {
                this.ID = id;
                this.Name = name;
            }
        }

        // 3. Partial Interface
        partial interface IDoable
        {
            string Name { get; set; }
        }

        partial interface IDoable
        {
            void Do();
        }

        // IDoable 인터페이스를 구현
        public class DoClass : IDoable
        {
            public string Name { get; set; }

            public void Do()
            {
            }
        }

        // Partial Method (C# 3.0)
        public partial class Class2
        {
            public void Run()
            {
                DoThis();
            }

            // 조건1: private only
            // 조건2: void return only
            partial void DoThis();
        }

        public partial class Class2
        {
            partial void DoThis()
            {
                Console.WriteLine(DateTime.Now);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

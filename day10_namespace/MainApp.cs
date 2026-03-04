using method_test_namespace;

namespace day10_namespace
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            method_test_namespace.Test_Class test = new method_test_namespace.Test_Class(); // 원래라면은 이렇게 정의를 해줘야 하지만 using을 통해 압축 가능하다.
            test.TestMethod();
            Test_Class test2 = new Test_Class(); // using을 통해서 이렇게 간단하게 정의 가능하다.
            test2.TestMethod();

        }
    }
}

namespace method_test_namespace
{
    class Test_Class
    {
        public void TestMethod()
        {
            Console.WriteLine("This is a test method.");
        }

    }
}
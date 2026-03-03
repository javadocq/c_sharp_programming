using System;

namespace day2_variable_and_const
{
    class CSvar
    {
        // 클래스 레벨에서 사용 가능한 전역 변수
        int globalVar; // 클래스 레벨에서 선언된 변수는 자동으로 초기화됩니다. int의 경우 기본값은 0입니다.
        const int MAX = 1024; // const 변수는 선언과 동시에 초기화해야 하며, 이후에는 값을 변경할 수 없습니다.

        readonly int readOnlyVar = 100; // readonly 변수는 선언과 동시에 초기화하거나, 생성자에서 초기화할 수 있습니다.
        public CSvar()
        {
            readOnlyVar = MAX; // readonly 변수는 생성자에서 초기화할 수 있습니다.
        }

        public void Method()
        {
            // 로컬 변수
            int localVar; // 로컬 변수는 반드시 초기화해야 합니다. 초기화하지 않으면 컴파일 오류가 발생합니다.

            localVar = 100;

            Console.WriteLine("Global variable: {0}", globalVar); // 0 (default value for int)
            Console.WriteLine("Local variable: {0}", localVar); // 100
        }
    }
    internal class MainApp
    {
        static void Main(string[] args)
        {
            // Bool
            bool isAlive = true;

            // Numeric
            short sh = -32768;
            int i = 2147483647;
            long l = 1234L;
            float f = 123.45f;
            double d1 = 123.45;
            double d2 = 123.45d;
            decimal d = 123.45m;

            // Char/String
            char c = 'A';
            string s = "Hello world";

            // DateTime
            DateTime dt = new DateTime(2024, 6, 1);

            // Max/Min values
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            int? k = null; // 원래 int는 null을 가질 수 없지만 C# 14.0에서는 nullable reference types가 도입되어 ?을 붙이면 null을 허용하는 방식으로 사용할 수 있습니다.
            string sq = null; // string도 nullable reference type이므로 null을 허용합니다.

            Console.WriteLine("{0} {1} {2}", maxInt, minInt, dt);

            CSvar csvar = new CSvar();
            csvar.Method();
        }
    }
}

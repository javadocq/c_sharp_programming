using System;

namespace day2_variable_and_const
{
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
        }
    }
}

namespace day13_method_parameter
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            double data = 3.14;
            GetData(ref data); // ref를 이용한 값 유지
            Console.WriteLine(data);

            double data2;
            GetData2(out data2); // out을 이용한 값 유지
            Console.WriteLine(data2);

            string name = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            PrintData(value: value, name: name); // named 파라미터

            int count = Calc(1.0, 2.0, 3.0); // params를 이용한 가변인자
            Console.WriteLine(count);
            int count2 = Calc(1.0, 2.0); // params를 이용한 가변인자
            Console.WriteLine(count2);
        }

        static void GetData(ref double data)
        {
            data++;
        }

        static void GetData2(out double data)
        {
            data = 3;
        }

        static void PrintData(string name, double value)
        {
            Console.WriteLine(name);
            Console.WriteLine(value);
        }

        static int Calc(params double[] data)
        {
            return data.Length;
        }
    }
}

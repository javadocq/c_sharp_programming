namespace day24_lmabda
{
    delegate int Calculator(int a, int b);
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Calculator calc = (a, b) => a + b; // 람다식

            int result = calc(10, 20);

            Console.WriteLine(result);
        }
    }
}

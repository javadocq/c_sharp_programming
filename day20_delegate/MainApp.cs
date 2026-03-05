namespace day20_delegate
{
    
    internal class MainApp
    {
        // delegate 정의
        delegate int MyDelegate(string s);

        void Test()
        {
            // 객체 선언
            MyDelegate m = new MyDelegate(StringToInt);

            Run(m);
        }

        // 델리게이트 대상이 되는 메서드
        int StringToInt(string s)
        {
            return int.Parse(s);
        }

        // 델리게이트를 전달받는 메서드
        void Run(MyDelegate m)
        {
            // 델리게이트로부터 메서드 호출
            int i = m("123");

            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            new MainApp().Test();
        }
    }

    
}

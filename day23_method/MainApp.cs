namespace day23_method
{
    internal class MainApp
    {
        delegate void MyDelegate(int a);

    static void Main(string[] args)
        {
            // 무명 메서드를 delegate 타입 변수에 할당
            MyDelegate d = delegate (int p)
                {
                    Console.Write(p);
                };
            d(100);


    }
}
}

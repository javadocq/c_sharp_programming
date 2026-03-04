namespace day11_struct
{
    public struct Int32 { }; // Value Type
    public class Int64 { }; // Reference Type

    internal class MainApp
    {
        struct MyPoint {
            public int x;
            public int y;
            private int z; // C#에서는 구조체에도 private 필드를 가질 수 있다.

            public MyPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString() // C++과 override 위치가 다르다.
            {
                return string.Format("({0}, {1})", x, y);
            }
        }
        static void Main(string[] args)
        {
            MyPoint p = new MyPoint(10, 20);
            Console.WriteLine(p.ToString());
        }
    }
}

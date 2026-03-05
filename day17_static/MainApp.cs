namespace day17_static
{
    // 스태틱 클래스
    static class StaticClass
    {
        static int StaticValue = 10;
        // public int InstanceValue = 20; // 스태틱 클래스는 인스턴스 멤버를 가질 수 없음
        public static string Convert(int i)
        {
            return i.ToString();
        }
        public static int Convert(string s)
        {
            return int.Parse(s);
        }
    }
    class MyClass
    {
        // 스태틱 필드
        public int StaticField = 42;

        // 스태틱 속성
        public static int StaticProperty { get; set; } = 100;

        // 스태틱 메서드
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }

        // 인스턴스 메서드
        public void InstanceMethod()
        {
            Console.WriteLine("This is an instance method.");
        }
    }
    internal class MainApp
    {
        static void Main(string[] args)
        {
            MyClass.StaticMethod(); // 스태틱 메서드는 클래스 이름으로 호출 가능
            MyClass myInstance = new MyClass(); // 인스턴스 생성
            myInstance.InstanceMethod(); // 인스턴스 메서드는 인스턴스를 통해 호출

            MyClass.StaticProperty = 200; // 스태틱 속성 설정
            myInstance.StaticField = 84; // 인스턴스 필드 설정
        }
    }
}

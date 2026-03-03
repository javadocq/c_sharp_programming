namespace day5_enum
{
    internal class MainApp
    {
        [Flags] // enum에 Flags 특성을 적용하면 비트 필드로 사용할 수 있다. 이 경우 각 값은 2의 제곱수로 지정하는 것이 일반적이다.
        enum Color // enum은 클래스 안이나 네임스페이스 안에만 선언 할 수 있고 메소드나 속성 안에는 선언 불가능
        {
            Red, // 0 기본적으로 0부터 시작하며 따로 값을 지정하지 않으면 순차적으로 1씩 증가한다.
            Yellow, // 1 
            Green = 2,
            Blue = 4
        }
        static void Main(string[] args)
        {
            Color myColor;

            // enum 타입에 값 대입
            myColor = Color.Red;
            Console.WriteLine(myColor); // Red

            if (myColor == Color.Red)
            {
                Console.WriteLine("Red");
            } else
            {
                Console.WriteLine("Not Red");
            }

            int c = (int)Color.Green; // enum은 내부적으로 정수형으로 저장되므로 int로 암시적 형변환이 가능하다.
            Console.WriteLine(c);

            Color Test = Color.Red | Color.Green; // enum은 비트 연산이 가능하다.
            Console.WriteLine(Test); // Red(0000) | Green(0010) = 0010 -> Green


            // 조건 null 연산자
            int? i = null;
            i = i ?? 10; // i가 null이면 10을 대입, null이 아니면 i의 값을 유지
        }
    }
}

using System.Text;

namespace day4_string
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            // 문자열 변수
            string s1 = "C++";
            string s2 = "Programming";

            s1 = "C#"; // 문자열은 Immutable 속성이다. 즉, 한 번 받은 값은 다시 변경할 수 없다.
            // 이게 되는 이유는 이 메모리 주소에 값을 변경하는 게 아니라 새롭게 string 객체를 생성하고 그게 s1이 되는거다. 즉, 다른 메모리 주소를 가진다.

            // 문자 변수
            char c1 = 'a';
            char c2 = 'b';

            // 문자열 결합
            string s3 = s1 + " " + s2; // 문자열 결합은 새로운 문자열 객체를 생성한다. 즉, s3는 새로운 메모리 주소를 가진다.
            Console.WriteLine(s3); // C# Programming

            // 부분 문자열 발췌
            string s3substring = s3.Substring(0,2); // s3의 0번째 인덱스부터 2개의 문자를 발췌한다. 즉, "C#"이 된다.
            Console.WriteLine(s3substring);

            // 문자열을 문자 배열로 변환
            char[] charArray = s3.ToCharArray(); // s3 문자열을 문자 배열로 변환한다. 즉, ['C', '#', ' ', 'P', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'i', 'n', 'g']가 된다.
            foreach(char c in charArray)
            {
                Console.WriteLine(c);
            }

            // 문자 배열을 문자열로 변환
            string s4 = new string(charArray); // charArray 문자 배열을 문자열로 변환한다. 즉, "C# Programming"이 된다.
            Console.WriteLine(s4);

            // 문자 변환
            char d1 = 'A';
            char d2 = (char)(d1 + 2);
            Console.WriteLine(d2); // 'C'가 된다. 왜냐하면 'A'의 ASCII 값이 65이므로 65 + 2 = 67이 되고, 67에 해당하는 문자가 'C'이기 때문이다.

            // StringBuilder 클래스
            // Immutable 타입인 string과 달리 StringBuilder는 mutable 타입이다. 즉, StringBuilder 객체는 생성된 후에도 내용을 변경할 수 있다.
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 26; i++)
            {
                sb.Append(i.ToString()); // StringBuilder 객체에 문자열을 추가한다. 즉, "012345678910111213141516171819202122232425"가 된다.
                sb.Append(System.Environment.NewLine); // 줄바꿈을 추가한다.
            }
            string s = sb.ToString(); // 이렇게 문자열로 변환해주는 이유는 다른 함수에 넘겨줄 때, string으로 넘겨주거나 StringBuilder가 계속 메모리를 들고있는 걸 방지 (효율)
            Console.WriteLine(s);
            Console.WriteLine(sb);
        }
    }
}

using System; // System 네임스페이스를 사용하여 콘솔 입출력과 같은 기능을 사용할 수 있도록 합니다. System 네임스페이스는 C#에서 기본적으로 제공되는 기능들을 포함하고 있습니다.
using static System.Console; // System.Console 클래스의 모든 정적 멤버를 직접 사용할 수 있도록 하는 using static 지시문입니다. 이를 통해 Console.WriteLine() 대신 WriteLine()을 사용할 수 있습니다.

namespace day1_hello
{
    internal class MainApp
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("Hello, World!"); // 원래는 System.Console.WriteLine()이지만 using static System.Console; 덕분에 WriteLine()으로 간단히 사용할 수 있습니다. Hello, World!를 프롬프트에 출력
                return;
            }

            WriteLine("Hello, {0}", args[0]); // Hello, {0}를 프롬프트에 출력
            // Console에 띄울 때는 WriteLine() 메서드를 사용한다. WriteLine() 메서드는 괄호 안에 있는 문자열을 콘솔에 출력한다. {0}은 문자열에서 첫 번째 인수의 위치를 나타내며, args[0]은 명령줄 인수 배열에서 첫 번째 요소를 참조한다. 따라서, 프로그램이 실행될 때 명령줄 인수를 제공하면 해당 인수가 {0} 자리로 대체되어 출력된다.
        }
    }
}

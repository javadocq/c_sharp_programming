namespace day7_condition
{
    internal class MainApp
    {
        static bool verbose = false;
        static bool continueOnError = false;
        static bool loggin = false;
        static void Main(string[] args) // 인자를 넘기는 방법은 bin/Debug/net10.0로 움직여서 ./day7_condition.exe /verbose 이렇게 하면 /verbose가 인자가 된다.
        // 인자를 2개 넘기려면 ./day7_condition.exe /continue /verbose 이렇게 사용
        // 만약 powershell에서 실행한다면 빌드를 코드를 변경할 때마다 해줘야 한다.
        { 
            if (args.Length < 1)
            {
                Console.WriteLine("No Option");
                return;
            }

            string option = args[0].ToLower();
            switch(option)
            {
                case "/verbose":
                    verbose = true;
                    break;
                case "/continue":
                    continueOnError = true;
                    break;
                case "/logging":
                    loggin = true;
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    return;

            }

            Console.WriteLine(verbose);
            Console.WriteLine(continueOnError);
            Console.WriteLine(loggin);
        }
    }
}

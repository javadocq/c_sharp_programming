using System.Diagnostics;

namespace day8_loop
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            // 3차배열 선언
            string[,,] arr = new string[,,] {
                { {"1", "2"}, {"11","22"} },
                { {"3", "4"}, {"33", "44"} }
             };

            //for 루프 : 3번 루프를 만들어 돌림
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Debug.WriteLine(arr[i, j, k]);
                    }
                }
            }

            //foreach 루프 : 한번에 3차배열 모두 처리 
            foreach (var s in arr)
            {
                Debug.WriteLine(s);
            }

            //for와 foreach의 성능 차이는 별로 없지만 가독성 측면에서 foreach가 더 좋다.

            // 입력 while 예제
            List<char> list = new List<char>(); // C++의 vector와 비슷한 역할을 하는 리스트 선언
            ConsoleKeyInfo key; // 키 입력을 받는 변수, ConsoleKeyInfo는 키보드 입력에 대한 정보를 담는 구조체
            do
            {
                key = Console.ReadKey(); // ReadLine과 달리 ReadKey는 키 입력을 바로 받아들임
                list.Add(key.KeyChar); // 입력된 키를 리스트에 추가
            } while(key.KeyChar != 'Q'); // Q 키가 입력될 때까지 반복

            Console.WriteLine();
            foreach(var s in list) // 입력된 키를 출력 var은 char 타입으로 추론됨
            {
                Console.WriteLine(s);
            }
        }
    }
}

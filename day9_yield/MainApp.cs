using System.Collections;

namespace day9_yield
{
    public class MyList
    {
        private int[] data = { 1, 2, 3, 4, 5 };

        public IEnumerator GetEnumerator() // IEnumerable 인터페이스의 GetEnumerator 메서드를 구현하여 반복자 반환
        {
            foreach (int item in data)
            {
                yield return item; // yield return을 사용하여 데이터를 하나씩 반환
            }
        }
    }
    internal class MainApp
    {
        static IEnumerable<int> GetNumber() // IEnumerable의 핵심 역할은 지연 실행(Lazy Evaluation이다)
        // 일반적인 리스트는 메모리에 모든 데이터를 다 담아두고 반환하지만, IEnumerable은 필요할 때마다 데이터를 하나씩 반환한다.
        {
            yield return 10; // 첫 번째 루프에서 반환되는 값, return을 만나고 함수가 종료되는 게 아니라 Pause 개념으로 멈춰있다. 이후 다시 실행되면 여기서부터 시작
            yield return 20; // 두 번째 루프에서 반환되는 값
            yield return 30; // 세 번째 루프에서 반환되는 값
        }
        static void Main(string[] args)
        {
            foreach (int number in GetNumber())
            {
                Console.WriteLine(number);
            }

            var myList = new MyList();

            // foreach를 사용하여 Iteration
            foreach (int item in myList) // MyList 클래스의 GetEnumerator 메서드가 yield return을 사용하여 데이터를 반환하므로, foreach 루프에서 MyList 객체를 반복할 수 있다.
            {
                Console.WriteLine(item);
            }

            // 수동 Iteration
            IEnumerator it = myList.GetEnumerator();
            it.MoveNext(); // 첫 번째 요소로 이동
            Console.WriteLine(it.Current); // 현재 요소 출력 (1)
            it.MoveNext(); // 두 번째 요소로 이동
            Console.WriteLine(it.Current);

            // IEnumerator 인터페이스는 MoveNext() 메서드를 통해 다음 요소로 이동하고, Current 속성을 통해 현재 요소를 가져올 수 있다.
        }
    }
}

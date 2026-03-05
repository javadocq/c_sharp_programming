namespace day18_generics
{
    class MyStack<T>
    {
        private T[] _stack;
        private int _top;
        public MyStack(int capacity)
        {
            _stack = new T[capacity]; // 제네릭 배열 생성
            _top = -1;
        }
        public void Push(T item) // 제네릭 매개변수 T를 사용하여 Push 메서드 정의
        {
            if (_top < _stack.Length - 1)
            {
                _stack[++_top] = item;
            }
            else
            {
                throw new InvalidOperationException("Stack is full.");
            }
        }
        public T Pop()
        {
            if (_top >= 0)
            {
                return _stack[_top--];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }
    }
    internal class MainApp
    {
        static void Main(string[] args)
        {
            MyStack<int> intStack = new MyStack<int>(5); // int 타입의 MyStack 인스턴스 생성
            intStack.Push(10);
            intStack.Push(20);
            Console.WriteLine(intStack.Pop()); // 20 출력
            Console.WriteLine(intStack.Pop()); // 10 출력
            MyStack<string> stringStack = new MyStack<string>(5); // string 타입의 MyStack 인스턴스 생성
            stringStack.Push("Hello");
            stringStack.Push("World");
            Console.WriteLine(stringStack.Pop()); // "World" 출력
            Console.WriteLine(stringStack.Pop()); // "Hello" 출력


            // Generic 클래스들
            List<int> intList = new List<int>(); // int 타입의 List 인스턴스 생성
            intList.Add(10);

            Console.WriteLine(intList[0]); // 10 출력

            Dictionary<string, int> dict = new Dictionary<string, int>(); // string 키와 int 값의 Dictionary 인스턴스 생성
            dict.Add("One", 1);
            dict["Two"] = 2;
        }
    }
}

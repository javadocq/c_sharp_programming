namespace day19_interface
{
    public interface IComparable
    {
        int CompareTo(object obj);
    }

    public class MyPerson : IComparable {
        private int key; // 비교의 기준이 될 값
        private int value;

        public int Key
        {
            get
            {
                return this.key;
            }
            set
            {
                this.key = value;
            }
        }
        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public int CompareTo(object obj)
        {
            // Unboxing/ Casting
            MyPerson other = (MyPerson)obj;

            // 나의 키와 상대방(other)의 키를 비교해서 결과를 반환
            return this.key.CompareTo(other.key); // 여기의 CompareTo는 int형의 기본 CompareTo 메서드
        }
    }

    internal class MainApp
    {
        static void Main(string[] args)
        {
            MyPerson[] list = new MyPerson[] {
                new MyPerson() { Key = 3, Value = 300 },
                new MyPerson() { Key = 5, Value = 500 },
                new MyPerson() { Key = 4, Value = 400 },
            };

            Console.WriteLine("Before sorting:");
            PrintList(list);

            Console.WriteLine("After sorting:");
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (list[i].CompareTo(list[j]) < 0)
                    {
                        MyPerson temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            PrintList(list);

        }

        // 출력을 위한 간단한 보조 메서드
        static void PrintList(MyPerson[] list)
        {
            foreach (var p in list)
            {
                Console.WriteLine($"Key: {p.Key}, Value: {p.Value}");
            }
        }

    }

}

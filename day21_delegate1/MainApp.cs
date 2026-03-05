using System.ComponentModel.Design.Serialization;

namespace day21_delegate1
{
    class MyClass {
        // delegate 선언
        private delegate void RunDelegate(int i); // 입력 파라미터는 int 1개, 리턴 값이 없는 메서드를 가리킨다.

        private void RunThis(int val)
        {
            Console.WriteLine("{0}", val);
        }

        private void RunThat(int value)
        {
            Console.WriteLine("{0:X}", value); // 16진수로 출력

        }
        public void Perform()
        {
            // delegate 인스턴스 생성
            RunDelegate run1 = new RunDelegate(RunThis); // RunThis 메서드를 가리키는 delegate 인스턴스 생성
            run1(16); // RunThis(16) 메서드 호출

            RunDelegate run2 = new RunDelegate(RunThat); // RunThat 메서드를 가리키는 delegate 인스턴스 생성
            run2(13); // RunThat(16) 메서드 호출
        }
    }

    class MySort
    {
        public delegate int CompareDelegate(int a, int b); // 두 개의 int를 입력으로 받고 int를 반환하는 delegate 선언

        public static void Sort(int[] array, CompareDelegate compare)
        {
            if (array.Length < 2)
            {
                return;
            }

            int ret;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    ret = compare(array[i], array[j]);
                    if (ret != -1)
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Display(array);
        }
        public static void Display(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }

    internal class MainApp
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Perform();

            new MainApp().Run();
        }

        void Run()
        {
            int[] a = { 53, 3, 89, 1, 5, 21, 8 };

            MySort.CompareDelegate compare = Ascending;
            MySort.Sort(a, compare);

            compare = Descending;
            MySort.Sort(a, compare);
        }

        int Ascending(int i1, int i2)
        {
            if (i1 == i2)
            {
                return 0;
            }
            else
            {
                return (i1 > i2) ? -1 : 0;
            }
        }

        int Descending(int i1, int i2)
        {
            if (i1 == i2)
            {
                return 0;
            }
            else
            {
                return (i1 < i2) ? -1 : 0;
            }
        }
    }
}

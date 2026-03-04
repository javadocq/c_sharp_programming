using System.Runtime.CompilerServices;

namespace day12_class
{
    public class MyCustomer
    {
        // 필드
        private string name;
        // private int age; 자동 구현 속성은 또 별개로 필드 변수가 만들어지기 때문에 필드 변수를 중복시키면 안되어서 이 줄을 제거

        // 이벤트
        public event EventHandler NameChanged;

        // 생성자
        public MyCustomer()
        {
            name = string.Empty;
        }

        // 속성 (get, set) 프로퍼티 개념
        public string Name { 
            get { return name; }
            set
            {
                if (this.name != value)
                {
                    name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(this, EventArgs.Empty); // 이름이 바뀌면 외부에 알린다!
                    }
                }
            }
        }

        public int Age // 요즘 C#에서는 자동 구현 속성(auto-implemented property)을 많이 사용한다. 필드와 get/set 메서드를 자동으로 만들어준다.
        {
            get; set;
        } = -1; // 자동 구현 속성, 초기값은 -1

        // 메서드
        public string GetCustomerInfo()
        {
            return $"Name: {this.name}, Age: {this.Age}"; // this.name은 get메서드를 호출한 것과 똑같다.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCustomer customer = new MyCustomer();
            customer.Name = "Alice"; // 이것도 직접 접근이 아니라 set메서드를 호출한 것과 같다.
            customer.Age = 21;
            string s = customer.GetCustomerInfo();
            Console.WriteLine(s);
        }
    }
}

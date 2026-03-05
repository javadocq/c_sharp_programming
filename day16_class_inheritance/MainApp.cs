namespace day16_class_inheritance
{
    // 기준 클래스
    public class Animal {
        public string Name { get; protected set; } // 읽기는 누구나, 쓰기는 자식만
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    // 파생 클래스
    public class Dog : Animal
    {
        //public Dog(string name, int age)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //}
        public Dog(string name, int age) : base(name, age) // 파생 클래스의 생성자에서 부모 클래스의 생성자를 호출하는 방법도 있다. 호출할 때는 base()문법 사용
        {
            this.Name = name;
            this.Age = age;
        }
        public void Bark()
        {
            Console.WriteLine("{0} is barking, and it is {1} years", this.Name, this.Age);
        }
    }

    // 파생 클래스
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }
        public void MEOW()
        {
            Console.WriteLine("{0} is meow, and it is {1} years", this.Name, this.Age);
        }
    }

    // 추상 클래스
    public abstract class Shape
    {
        public abstract double Area(int x, int y); // 추상 메서드, 구현은 파생 클래스에서 해야 한다.
    }

    // 추상 클래스의 파생 클래스
    public class Rectangle : Shape
    {
        public override double Area(int x, int y)
        {
            return x * y;
        }
    }

    internal class MainApp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Dog", 21);
            // dog.Age = 3; // MainApp은 Animal의 파생 클래스가 아니기 때문에 Dog 객체를 통해 직접 접근이 불가능
            dog.Bark(); 

            Rectangle rect = new Rectangle();
            Console.WriteLine(rect.Area(3, 4));

        }
    }
}

### 프로퍼티(Property)

- 프로퍼티는 클래스의 필드와 메서드 사이에 위치하는 멤버입니다. 
- 프로퍼티는 클래스의 데이터를 캡슐화하고, 외부에서 접근할 수 있도록 하는 역할을 합니다. 프로퍼티는 일반적으로 get과 set 액세서로 구성되어 있으며, 이를 통해 데이터를 읽거나 쓸 수 있습니다.

사용법
- 프로퍼티는 다음과 같이 정의할 수 있습니다:
```csharp
public class Person
{
	private string name; // 필드
	public string Name // 프로퍼티
	{
		get { return name; } // get 액세서
		set { name = value; } // set 액세서
	}
}

public class Program
{
	public static void Main()
	{
		Person person = new Person();
		person.Name = "Alice"; // set 액세서 호출
		Console.WriteLine(person.Name); // get 액세서 호출, 출력: Alice
	}
}
```
### C# 인터페이스

- 클래스와 비슷하게 인터페이스는 메서드, 속성, 이벤트, 인덱서 등을 갖지만, 인터페이스는 이를 직접 구현하지는 않고 단지 정의만을 갖는다.
- 인터페이스는 클래스나 구조체가 특정 기능을 구현하도록 강제하는 계약 역할을 한다. 인터페이스를 구현하는 클래스나 구조체는 인터페이스에서 정의된 모든 멤버를 구현해야 한다.
- 한 클래스는 하나의 기준 클래스만을 가질 수 있지만, 인터페이스는 여러 개 가질 수 있다.

```csharp
public class MyClass: Component, IDbConnection, IDisposable
{
	// IDbConnection 인터페이스의 멤버 구현
	public void Open() { /* ... */ }
	public void Close() { /* ... */ }
	public string ConnectionString { get; set; }
	
	// IDisposable 인터페이스의 멤버 구현
	public void Dispose() { /* ... */ }
}
```
### C# 인터페이스의 정의

- 인터페이스는 C# 키워드 interface를 사용하여 정의한다.
- 인터페이스 정의 시에는 내부 멤버들에 대해 public과 같은 접근 제한자를 사용할 수 없다.
- 인터페이스의 모든 멤버는 암묵적으로 public으로 간주된다.

```
public interface IComparable {
	// 멤버 앞에 접근제한자 사용 안함
	int CompareTo(object obj);
}
```


### C# 제네릭

- 일반적으로 제네릭은 코드의 재사용성을 올려주는 역할을 한다.
- 동일한 기능인데 타입만 다르게 처리하는 경우, 제네릭을 사용하면 코드의 중복을 줄일 수 있다.
- 제네릭 타입은 데이터 요소 타입을 확정하지 않고, 데이터 타입 자체를 타입 파라미터로 받아들이도록 클래스를 정의한다.

### 제네릭 타입 제약

- 제네릭 타입을 정의할 때, 타입 파라미터에 대한 제약을 설정할 수 있다.
```csharp
// T는 Value 타입
class MyClass<T> where T : struct 

// T는 Reference 타입
class MyClass<T> where T : class

// T는 디폴트 생성자를 가져야 함
class MyClass<T> where T : new() 

// T는 MyBase의 파생클래스이어야 함
class MyClass<T> where T : MyBase

// T는 IComparable 인터페이스를 가져야 함
class MyClass<T> where T : IComparable

// 좀 더 복잡한 제약들
class EmployeeList<T> where T : Employee,
   IEmployee, IComparable<T>, new()
{
}

// 복수 타입 파라미터 제약
class MyClass<T, U> 
    where T : class 
    where U : struct
{
}
```
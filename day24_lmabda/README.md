### C# 람다식

- => 연산자는 C#에서는 람다식을 표현할 때 사용한다.
- 람다식은 무명 함수를 표현하는데 사용 (입력 파라미터) => 실행 문장

```csharp
// 입력 파라미터가 없는 경우
// () => Console.Write("No");

// 입력 파라미터가 있는 경우
// (s,e) => { Console.WriteLine(s); Console.WriteLine(e); };

// 입력 파라미터 타입을 명시하는 경우
// (string s, string e) => { Console.WriteLine(s); Console.WriteLine(e); };
```

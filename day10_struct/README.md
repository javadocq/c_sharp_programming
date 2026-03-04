### Value Type vs Reference Type

C#은 Value Type과 Reference Type을 구분한다.
- Value Type: Stack에 저장되고, 값 자체를 저장한다. (예: int, float, struct)
- Reference Type: Heap에 저장되고, 객체의 주소를 저장한다. (예: class, array)

struct를 사용하면 Value Type이 되며, class를 사용하면 Reference Type이 된다. 
Value Type은 복사될 때 값이 복사되고, Reference Type은 참조가 복사된다. 
따라서 Value Type은 독립적으로 존재하지만, Reference Type은 여러 변수가 같은 객체를 참조할 수 있다.

### Struct 구조체

많은 경우 C#에서 클래스를 사용하지만, 
경우에 따라 클래스보다 상대적으로 가벼운 오버헤드를 지닌 구조체가 필요할 수 있다.
C#의 구조체는 클래스와 같이 메서드, 프로퍼티 등 거의 비슷한 구조를 가지고 있지만, 상속은 할 수 없다.

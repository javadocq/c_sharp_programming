using System.Diagnostics;

namespace day25_anonymous_type
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            var t = new { Name = "홍길동", Age = 30 };
            Console.WriteLine($"Name: {t.Name}, Age: {t.Age}");

            var v = new[] {
                new { Name = "김철수", Age = 25, Phone = "010-1234-5678", Address = "경기도 부천시"},
                new { Name = "이영희", Age = 28, Phone = "010-9876-5432", Address = "서울시 강남구"},
                new { Name = "박민수", Age = 35, Phone = "010-5555-6666", Address = "인천시 남동구"}
                };

            // LINQ Select 이용, 나이가 30이 넘는 데이터를 모아 익명타입 반환
            var list = v.Where(p => p.Age >= 30).Select(p => new { p.Name, p.Age, p.Phone, p.Address });
            foreach (var item in list)
            {
                Debug.WriteLine(item.Name + " " + item.Age + " " + item.Phone + " " + item.Address);
            }
        }
    }
}

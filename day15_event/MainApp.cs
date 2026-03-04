namespace day15_event
{
    public class  MyButton
    {
        public string text { get; set; }
        public event EventHandler Click;

        public void OnClick()
        {
            Console.WriteLine("Button Clicked");

            // 가입자가 있는 지 확인 후 이벤트 발생
            // ?. 연산자는 Click이 null이 아닐 때만 Invoke를 호출하도록 합니다.
            // this는 C# 6.0에서 도입된 null 조건 연산자입니다.
            // EventArgs.Empty는 이벤트 핸들러에 전달할 빈 이벤트 인스턴스입니다.
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
    internal class MainApp
    {
        static void Main(string[] args)
        {
            MyButton btn = new MyButton { text = "Click Me" };

            // 이벤트 구독
            btn.Click += (sender, e) => // 이 sender는 결국 btn 이다.
            {
                MyButton b = sender as MyButton; // 버튼(btn)이 클릭(Click)되면, 이벤트를 보낸 녀석(sender)을 버튼(MyButton)으로 변환해서 그 버튼의 글자(Text)를 콘솔에 찍어라!
                Console.WriteLine($"Button Text: {b.text}");
            };

            // 일반 메서드 형태의 핸들러 등록
            btn.Click += OnBtnClickCustom;

            btn.OnClick(); // 여기서 아까 이벤트 구독한 것도 실행이 된다. sender는 btn 자신

            // 이벤트 구독 해제
            btn.Click -= OnBtnClickCustom;
        }

        // 이벤트 핸들러 메서드
        static void OnBtnClickCustom(object sender, EventArgs e)
        {
            Console.WriteLine("[로그] 별도의 메서드 핸들러가 동작함.");
        }
    }
}

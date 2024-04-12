namespace ex11_events
{
    delegate int Caculate(int a, int b);
    delegate void EventHandler(string message); // 이벤트핸들러 대리자

    class CustomNotifier
    {
        // 이벤트 등록
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened($"{number} : 짝!"); // 이벤트핸들러 발생, 자신의 메서드가 아닌 외부에서 만들어진 메서드를 대신 실행
            }
        }
    } // 우리가 구현하는게 아닌 원래부터 만들어져 있는 것

    internal class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] : {message}");
        }
        static void Main(string[] args)
        {
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for(int i = 1; i <30; i++)
            {
                notifier.DoSomething(i); // 내장된 클래스의 어떠한 메서드 호출
            }

            #region "익명 메서드"
            Caculate calc; // 대리자

            // 메서드 이름이 존재x
            // 익명 메서드, 한번 사용 이후 다시 호출할 필요없을 때 사용
            calc = delegate(int a, int b) { return a + b; };

            var result = calc(10, 4);
            #endregion
        }
    }
}

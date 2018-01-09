using csharp.test.app.greet;

namespace csharp.test.app
{
    class Application
    {
        public static void Main()
        {
            Application a = new Application();

            Hello h1 = new Hello();
            h1.sayHello();

            HowDoYouDo h2 = new HowDoYouDo();
            h2.sayHowDoYouDo();

            a.Leave();
        }

        private void Leave()
        {
            Goodbye g = new Goodbye();
            g.sayGoodBye();
        }
    }
}

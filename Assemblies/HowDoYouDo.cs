using System.Reflection;
[assembly: AssemblyKeyFile("app.snk")]
[assembly: AssemblyVersion("1.0.0.0")]

namespace csharp.test.app
{
    public class HowDoYouDo
    {
        public void sayHowDoYouDo()
        {
            System.Console.WriteLine("How do you do, I am a Global Assembly!!!");
        }
    }
}

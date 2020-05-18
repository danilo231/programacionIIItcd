using System;

namespace _2ejerexamen
{
    class Program
    {
        static void Main(string[] args)
        {
            Singletom uno = Singletom.getInstance();
            uno.seta("buenos dias");
            uno.showMessage();
            Singletom dos = Singletom.getInstance();
            dos.seta("buenas tardes");
            uno.showMessage();
            Console.ReadKey();
        }
    }
}

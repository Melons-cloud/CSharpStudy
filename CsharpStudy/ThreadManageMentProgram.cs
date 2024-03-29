using System;
using System.Threading;

namespace CsharpStudy
{
    public class ThreadManageMentProgram
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
            //线程暂停5000毫秒
            int sleepfor = 5000;
            Console.WriteLine("Child Thread Paused for {0} seconds",sleepfor/1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        static void Main1(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main : Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
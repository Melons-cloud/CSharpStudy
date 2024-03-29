using System;
using System.Threading;

namespace CsharpStudy
{
    public class ThreadAbort
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts");
                
                //计数到10
                for (int counter = 0; counter <=10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                    
                }
                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        static void Main1(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main : Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            //停止主线程一段时间
            Thread.Sleep(2000);
            //中止子线程
            Console.WriteLine("In Main : Aborting the Child thread");
            childThread.Abort();
            Console.ReadKey();
        }
    }
}
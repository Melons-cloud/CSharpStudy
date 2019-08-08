using System;
using System.Threading;

namespace CsharpStudy
{
    public class ThreadFollow
    {
        int num = 10; //设置当前总票数

        void Ticket()
        {
            while (true) //设置无线循环
            {
                if (num > 0)
                {

                    Thread.Sleep(100);
                    //票数减一
                    Console.WriteLine(Thread.CurrentThread.Name + "----票数" + num--);
                }
            }


        }

        static void Main(string[] args)
        {
            ThreadFollow p = new ThreadFollow(); //创建对象，以便调用对象方法
            //分别实例化4个线程对象
            Thread tA = new Thread(new ThreadStart(p.Ticket));
            tA.Name = "线程一";
            Thread tB = new Thread(new ThreadStart(p.Ticket));
            tB.Name = "线程二";
            Thread tC = new Thread(new ThreadStart(p.Ticket));
            tC.Name = "线程三";
            Thread tD = new Thread(new ThreadStart(p.Ticket));
            tD.Name = "线程四";

            //启动线程
            tA.Start();
            tB.Start();
            tC.Start();
            tD.Start();
            Console.ReadLine();
        }
    }
}
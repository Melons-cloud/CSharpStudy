using System;

namespace CsharpStudy
{
    //发布器类
    public class EventTest
    {
        private int value;

        public delegate void NumMainipulationHandler();

        public event NumMainipulationHandler ChangeNum;

        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();  //事件触发
            }
            else
            {
                Console.WriteLine("event not fire");
                Console.ReadKey();  //回车继续
            }
           
        }

        public EventTest()
        {
            int n = 5;
            SetValue(n);
        }

        public void SetValue(int n)
        {
            if (value!=n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }
//订阅器类
    public class subscribEvent
    {
        public void printf()
        {
            Console.WriteLine("event fire");
            Console.ReadKey(); //回车继续
        }
    }
    //触发
    public class MainClass
    {
        public static void Main()
        {
            EventTest eventTest = new EventTest();  //实例化对象，第一次没有触发事件
            subscribEvent subscribEvent =new subscribEvent();  //实例化对象
            eventTest.SetValue(7);
            eventTest.SetValue(11);
        }
    }
}
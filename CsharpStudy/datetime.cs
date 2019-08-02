using System;

namespace CsharpStudy
{
    public class datetime
    {
        static void Main1(string[] args)
        {
            DateTime strDateTime = DateTime.Now;//获取当前日期时间
            //输出短日期格式
            Console.WriteLine(string.Format("当前日期的短日期格式表示:{0:d}",strDateTime));
            //输出常日期格式
            Console.WriteLine(string.Format("当前日期的常日期格式表示:{0:D}",strDateTime));
            Console.WriteLine();
            //输出完整日期/时间格式(短时间)
            Console.WriteLine(string.Format("当前日期时间的完整日期/时间格式(短时间)表示{0:f}",strDateTime));
            //输出完整日期/时间格式(长时间)
            Console.WriteLine(string.Format("当前日期时间的完整日期/时间格式(长时间)表示{0:F}",strDateTime));
            Console.WriteLine();
            //输出时间格式
            Console.WriteLine(string.Format("当前时间的短时间格式表示:{0:t}",strDateTime));
            //输出长时间格式
            Console.WriteLine(string.Format("当前时间的长时间格式表示:{0:T}",strDateTime));
            Console.WriteLine();//换行
            //输出月/日格式
            Console.WriteLine(string.Format("当前日期的月/日格式表示:{0:M}",strDateTime));
            //输出年/月格式
            Console.WriteLine(string.Format("当前日期的年/月格式表示:{0:Y}",strDateTime));
            Console.ReadKey();

        }
    }
}
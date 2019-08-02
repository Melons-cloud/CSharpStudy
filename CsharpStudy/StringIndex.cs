using System;

namespace CsharpStudy
{
    public class StringIndex
    {
        static void Main1(string[] args)
        {
            string str = "We are the world";   //创建字符串
            int firstIndex = str.IndexOf("r");  //获取字符串中"r"第一次出现的索引位置
            //获取字符串中"r"第二次出现的位置,从第一次出现的索引位置之后开始查找
            int secondIndex = str.IndexOf("r", firstIndex + 1);
            //获取字符串中"r"第三次出现的位置,从第二次出现的索引位置之后开始查找
            int thirdIndex = str.IndexOf("r", secondIndex + 1);
            //输出三次获取的索引位置
            Console.WriteLine("r第一次出现的索引位置是:"+firstIndex);
            Console.WriteLine("r第二次出现的索引位置是:"+secondIndex);
            Console.WriteLine("r第三次出现的索引位置是:"+thirdIndex);
        }
    }
}
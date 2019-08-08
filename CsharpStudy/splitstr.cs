using System;

namespace CsharpStudy
{
    public class splitstr
    {
        static void Main1(string[] args)
        {
            //声明字符串
            string str = "让编程学习不再难，让编程创造财富不再难，让编程改变工作和人生不再难";
            //声明分割字符的数组
            char[] separater = {'.'};
            //分割字符串
            string[] splitStrings = str.Split(separater, StringSplitOptions.RemoveEmptyEntries);
            //使用for循环遍历数组，并输出
            for (int i = 0; i < splitStrings.Length; i++)
            {
                Console.WriteLine(splitStrings[i]);
            }

            Console.ReadLine();

        }
    }
}
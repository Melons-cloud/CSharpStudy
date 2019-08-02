using System;

namespace CsharpStudy
{
    public class NameAndPassword
    {
        static void Main1(string[] args)
        {
            Console.Write("请输入登录用户名: ");
            //读取输入的内容，赋给name字符串
            string name = Console.ReadLine();
            Console.Write("请输入登录密码: ");
            //读取输入的内容，赋给password字符串
            string password = Console.ReadLine();
            if (name=="mr" && password.Equals("mrsoft"))   //判断用户名和密码是否正确
            
            {
                Console.WriteLine("密码输入成功，恭喜您!");
            }
            else
            {
                Console.WriteLine("用户名或者密码输入错误！");
            }

            Console.ReadKey();
        }
    }
}
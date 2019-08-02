using System;

namespace CsharpStudy
{
    public class filename
    {
        static void Main1(string[] args)
        {
            string strfile = "Program.cs";
            Console.WriteLine("文件完整名称: "+strfile);
            //获取文件名
            string strFileName = strfile.Substring(0, strfile.IndexOf('.'));
            //获取文件扩展名
            string strExtension = strfile.Substring(strfile.IndexOf("."));
            
            Console.WriteLine("文件名: "+strFileName);
            Console.WriteLine("扩展名:"+strExtension);
        }
    }
}
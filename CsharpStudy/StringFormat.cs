using System;

namespace CsharpStudy
{
    public class StringFormat
    {
        static void Main(string[] args)
        {
            
            //输出金额
            Console.WriteLine(string.Format("121+121的结果是(以货币形式显示):{0:C}",121+121));
            //输出科学计数法
            Console.WriteLine(string.Format("212.21用科学技术法表示:{0:E}",212.21));
            //输出以分隔符显示的数字,N0显示的数字中不包括小数
            Console.WriteLine(string.Format("2122以分隔符数字显示的结果是:{0:N0}",2122));
            //输出小数点后两位,F2保留两位小数
            Console.WriteLine(string.Format("π取两位小数点:{0:F2}",Math.PI));
            //输出十六进制,X4表示显示4位数形式的十六进制数
            Console.WriteLine(string.Format("33的16进制结果是:{0:X4}",33));
            //输出百分号数字，P0表示显示的百分比中不包括小数
            Console.WriteLine(string.Format("天才是由{0:P0}的灵感，加上{1:P0}的汗水。",0.01,0.99));
            Console.ReadKey();
        }
    }
}
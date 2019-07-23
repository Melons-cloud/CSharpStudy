using System;
[AttributeUsage(AttributeTargets.All)]


    public class Reflection : System.Attribute
    {
        public readonly string Url;

        public string Topic //Topic是一个命名(named)参数
        {
            get { return topic; }
            set { topic = value; }

        }

        public Reflection(string url)   //url是一个定位(positional)参数
        {
            this.Url = url;
        }

        private string topic;

    }

[Reflection("Information on the class MyClass")]
class MyClass
{
    
}

namespace AttributeAppl
{
    class Progam
    {
        static void Main5(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }

            Console.ReadLine();
        }
    }
    
 }
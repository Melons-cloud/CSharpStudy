using System;

namespace first_space
{
    public class namespace_c1
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }

    }
}
namespace second_space{

    class namespace_c2
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }

}

class TestClass
{
    static void Main3(string[] args)
    {
        first_space.namespace_c1 fc =new first_space.namespace_c1();
        second_space.namespace_c2 sc = new second_space.namespace_c2();
        fc.func();
        sc.func();
        Console.ReadKey();
    }
    
    
    
}

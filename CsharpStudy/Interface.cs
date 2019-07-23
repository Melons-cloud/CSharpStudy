using System;

namespace CsharpStudy
{
    interface IParentInterface
    {
        void ParentInterfaceMethod();
    }

    interface IMyInterface:IParentInterface
    {
        void MethodToImplement();
    }
     class InterfaceImplementer:IMyInterface
    {
         static void Main1()
        {
            InterfaceImplementer implementer = new InterfaceImplementer();
            implementer.MethodToImplement();
            implementer.ParentInterfaceMethod();
            
            
        }

        public void ParentInterfaceMethod()
        {
           Console.WriteLine("MethodToImplement() called.");
        }

        public void MethodToImplement()
        {
           Console.WriteLine("ParentInterfaceMethod() called");
        }
    }
}
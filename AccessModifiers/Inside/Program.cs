using System;
using Outside;
namespace Inside;

class Program {
    public static void Main(){
        Son son =new Son();
        Father father=new Father();
        GrandFather grandfather=new GrandFather();
        //Console.WriteLine(father.ProtectedNumber);
        Console.WriteLine(son.PublicNumber);
        Console.WriteLine(son.PrivateOut);
        Console.WriteLine(son.ProtectedOut);
        Console.WriteLine(father.InternalNumber);
        Console.WriteLine(grandfather.PublicOutsideNumber);
        Console.WriteLine(father.ProtectedInternalOut);
 
    }
}
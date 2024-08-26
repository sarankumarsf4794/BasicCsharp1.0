using System;

namespace IfElse;

class Program{
    public static void Main(string[] args){
        Console.WriteLine("enter your mark : ");
        int mark=Convert.ToInt32(Console.ReadLine());
         if(mark>80 && mark<=100){
         Console.WriteLine("Grade A");
         }

         else if(mark>60 && mark<81){

         
         Console.WriteLine("Grade B");
         }

         else if(mark>35 && mark<61){
         Console.WriteLine("Grade C");
         }

         else if(mark<=35 && mark>=0){
         Console.WriteLine("Grade D");
         }

         else{
         Console.WriteLine("invalid Input");
         }
    }
}
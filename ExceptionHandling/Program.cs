using System;

namespace ExceptionHandling;

class Program{
    public static void Main(){

            try{
            Console.WriteLine("enter first number");
            int number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int number2=Convert.ToInt32(Console.ReadLine());

            double result=number1/number2;
            Console.WriteLine("result "+result);
            }
            catch(FormatException ex){
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch(DivideByZeroException ex){
                Console.WriteLine("Infinity");
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            
            }
            Console.WriteLine("output");



    }
    
}
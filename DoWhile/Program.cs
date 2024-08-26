using System;
using System.Formats.Asn1;

namespace DoWhile;

class Program{
    public static void Main(string[] args){
        string answer;
        
        do{
            Console.WriteLine("Enter the number you wanna check : ");
            int number1=Convert.ToInt32(Console.ReadLine());
            if(number1%2==0){
                Console.WriteLine($"{number1} is Even");
            }
            else{
                Console.WriteLine($"{number1} is Odd");
            }
            Console.WriteLine("Wanna check another number?");
            Console.WriteLine("Yes or No");
            answer=Console.ReadLine();
            while(answer!="Yes" && answer!="No"){
                Console.WriteLine("Provide a valid input (Yes/No) !!!");
                answer=Console.ReadLine();
            }
             

        }while(answer=="Yes");
}
}
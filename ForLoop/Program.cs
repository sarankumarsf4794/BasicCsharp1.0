using System;

namespace ForLoop;

class Program{
    public static void Main(string[] args){
        Console.WriteLine("enter the starting range : ");
        int start=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the last limit : ");
        int end=Convert.ToInt32(Console.ReadLine());
        double sum=0;

        for(int i=start+1;i<end;i++){
            sum=sum+ Math.Pow(i,2);
        }
        Console.WriteLine($"The sum is : {sum}");
    }
}
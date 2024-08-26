using System;

namespace DateTimee;

class Program{
    public static void Main(){
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine("Year : "+date.Year);
        Console.WriteLine("Month : "+date.Month);
        Console.WriteLine("Day : " +date.Day);
        Console.WriteLine("Hour : "+date.Hour);
        Console.WriteLine("Minutes : "+date.Minute);
        Console.WriteLine("Seconds : "+date.Second);

        Console.WriteLine("-------------------------converting to string-------------------------");
        string date_string=date.ToString("yyyy/mm/dd hh:mm:ss tt");
        string[] array=date_string.Split('/',' ',':');
        Console.WriteLine($"Before Reversing : {date_string} ");
        Console.Write($"After Reversing : ");

        for(int i=array.Length-1;i>=0;i--){
            

            Console.Write($"{array[i]}"+" ");
        }
        Console.WriteLine();

        Console.WriteLine("-------------------------------------------------------------------------");

        Console.WriteLine("Enter the date in (yyyy/mm/dd) : ");
        string str_date=Console.ReadLine();
        DateTime result=DateTime.ParseExact(str_date,"yyyy/mm/dd",null);
        Console.WriteLine($"After converting string to date : {result}");


        


    }
}
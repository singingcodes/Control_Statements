using System;

namespace Control_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement
           // int number = 20;
            // if(number == 10){
            //     Console.WriteLine("number is 10");
            // }else if (number == 20){
            //     Console.WriteLine("number is 20");
            // }
            // else if (number == 30){
            //     Console.WriteLine("number is 30");
            // }else{
            //     Console.WriteLine("please enter a number");
            // }
            // switch statement
            // switch(number){
            //     case 10:
            //     Console.WriteLine("number is 10");
            //     break;
            //      case 20:
            //     Console.WriteLine("number is 20");
            //     break;
            //      case 30:
            //     Console.WriteLine("number is 30");
            //     break;
            //     default:
            //     Console.WriteLine("invalid number");
            //     break;
            // }
            // while loop execution
            // int a = 10;
            // while (a < 20)
            // {
            //     Console.WriteLine("value of a: {0} is"  + a);
            //     a++;
            // }
            // int a = 12;
            // do  {
            //     Console.WriteLine("value of a is "  + a);
            //     a = a + 1;
            // }
            
            // while (a < 20);

            // for statement
    
            // for (int a = 5; a > 0; a--)
            // {
            //     Console.WriteLine(a);
            // }
            // for each loop is used to iterate over arrays and lists
            string[] cars = {"volvo", "toyota", "bmw"};
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
           
             
        }
    }
}

using System;

namespace LeapYear
{
    class Program
    {
         static void Main(string[] args)
        {
            Boolean exit = true;
            int year = 0;
            while(exit){
               
                year = getInput(); 
                exit = checkInput(year);
                
                if(checkInput(year)==false){
                    Exit();
                    break; 
                }
                 Console.WriteLine("Message: " +checkYear(year));
            }
        }
        public static int getInput(){
             Console.Write("Please enter a year: ");
              int year = Convert.ToInt32(Console.ReadLine());
              return year;
        }
        public static Boolean checkYear(int year){
              if(year%400 == 0){
                  return true;
              }
              else if(year %100==0){
                return false;
              }
              else if(year%4==0){
                  return true;
              }
              return false;
        }
        public static Boolean checkInput(int year){
              if(year<=0){
                return false;
                }  
              else{
                return true;
             } 
        }
        public static void Exit(){
            Console.WriteLine("Exiting");
        }
        
        
       
    }    
}



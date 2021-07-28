using System;
class Prog
{
public static void Main()
{
Console.WriteLine("Electricity Bill");
Console.WriteLine("Please enter units");
int units= Convert.ToInt32(Console.ReadLine());

  if(units <= 200 && units >=0)
 {
   int rate=2;
   int total=units*rate;
   Console.WriteLine("Electricity Consumption Bill " + total );
 }
 
 else if(units <= 350 && units >=201)
 {
   int rate=3;
   int total=(200*2)+(units-200)*rate;
   Console.WriteLine("Electricity Consumption Bill " + total );
 }

 else if(units <= 500 && units >=351)
 {
   int rate=5;
   int total=(200*2)+(150*3)+(units-350)*rate;
   Console.WriteLine("Electricity Consumption Bill " + total );
 }

else if(units >=501)
 {
   int rate=7;
   int total=(200*2)+(150*3)+(150*5)+(units-500)*rate;
   Console.WriteLine("Electricity Consumption Bill " + total );
 }

}

}
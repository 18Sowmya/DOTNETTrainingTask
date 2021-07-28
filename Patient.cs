using System;
class Prog
{
public static void Main()
{
Console.WriteLine("Classifying the Patients");
Console.WriteLine("Enter your age");
int age= Convert.ToInt32(Console.ReadLine());

if(age >=16  )
Console.WriteLine("Adultcase");
else	
Console.WriteLine("Paediatric case");
}

}

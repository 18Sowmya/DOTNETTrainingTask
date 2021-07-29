using System;
class Prog1
{
public static void Main()
{
Console.WriteLine("As the age number, the name will be displayed");
Console.WriteLine("Enter your name");
String name=Console.ReadLine();
Console.WriteLine("Enter your age");
int age=Convert.ToInt32(Console.ReadLine());
for(int i=0; i<age; i++)
{
Console.WriteLine(name);
 }
}
}
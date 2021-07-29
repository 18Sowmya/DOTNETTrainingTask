using System;
class Prog2
{
public static void Main()
{
Console.WriteLine("Enter the number to display the multiplication table");
int num=Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=20; i++)
{
int total=i*num;
Console.WriteLine(num+ "*" + i + "=" + total);
}

}
}
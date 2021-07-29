using System;
class Prog4
{
public static void Main()
{
Console.WriteLine("Enter your five subject marks to display the total and percentage");
int [] Marks=new int[5];
Marks[0]=Convert.ToInt32(Console.ReadLine());
Marks[1]=Convert.ToInt32(Console.ReadLine());
Marks[2]=Convert.ToInt32(Console.ReadLine());
Marks[3]=Convert.ToInt32(Console.ReadLine());
Marks[4]=Convert.ToInt32(Console.ReadLine());
int total=0;
foreach(int i in Marks)
total=total+i;
Console.WriteLine("Total is " + total);
int percent=0;
percent=total/Marks.Length;
Console.WriteLine("Percent is " + percent);

}
}
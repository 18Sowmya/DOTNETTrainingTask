using System;
class Prog
{
public static void Main()
{
Console.WriteLine("Campus Recruitment");
Console.WriteLine("Enter your GPA");
int GPA= Convert.ToInt32(Console.ReadLine());

if(GPA >=7  )
{
Console.WriteLine("Aptitude test"); 
Console.WriteLine("Enter your Aptitude Score ");
 int Score= Convert.ToInt32(Console.ReadLine());
if(Score >=7  )
{
Console.WriteLine("Please attend the Technical Interview"); 
Console.WriteLine("Enter your Technical Score ");
 int TechScore= Convert.ToInt32(Console.ReadLine());
if(TechScore >=7  )
{
Console.WriteLine("HR Interview"); 
Console.WriteLine("Enter your HR Score ");
 int HrScore= Convert.ToInt32(Console.ReadLine());

if(HrScore >=7  )
{
Console.WriteLine("Selected"); 
}
else
{
Console.WriteLine("Not Selected");
}
}
else
{
Console.WriteLine("Try after 3 months");
}
}
else
{
Console.WriteLine("Try after 6 months");
}
}
else
{
Console.WriteLine("Not Eligible");
}
}
}
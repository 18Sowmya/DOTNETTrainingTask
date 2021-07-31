using System;
class bClass
{
public void addNo(int a, int b)
{
Console.WriteLine("Addition " + (a+b));
}
public void sub(int a, int b)
{
Console.WriteLine("Subtraction " + (a-b));
}
}

class dClass:bClass
{
public void multi(int a, int b)
{
Console.WriteLine("Multiplication " + (a*b));
}
public void div(int a, int b)
{
Console.WriteLine("Division " + (a/b));
}
}

class mClass
{
public static void Main()
{
Console.WriteLine("Enter the numbers");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
dClass d1= new dClass();
d1.addNo(a,b);
d1.sub(a,b);
d1.multi(a,b);
d1.div(a,b);

}
}
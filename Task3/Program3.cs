using System;
class Oloading
{
public void opt(string eid, string pswd)
{
Console.WriteLine("EmailID, Password");
Console.WriteLine(eid + " " + pswd);
}
public void opt(string mid, int pin)
{
Console.WriteLine("MembershipID, Pin");
Console.WriteLine(mid + " " + pin);
}
public void opt(int mno, int pinn)
{
Console.WriteLine("Mobile number, Pin");
Console.WriteLine(mno + " " + pinn);
}

public static void Main()
{

Oloading obj = new Oloading();
obj.opt("hello@gm.com", "hello");
obj.opt("m939", 789);
obj.opt(0000111100, 9318);

}
}
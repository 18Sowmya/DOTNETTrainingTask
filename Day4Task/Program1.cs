using System;
public class Oneprog
{
public string name;
public int age;
public Oneprog()
{
name="Person1";
age=21;
Console.WriteLine("a. Initialize them using object");
}
}

public class Secprog
{
public string name;
public int age;
public Secprog(string sname, int sage)
{
name=sname;
age=sage;
Console.WriteLine("b. Initialize them by passing parameters");
Console.WriteLine(name);
Console.WriteLine(age);
}
}

class mclass
{
public static void Main()
{
Oneprog obj1=new Oneprog();
Console.WriteLine(obj1.name);
Console.WriteLine(obj1.age);
Secprog obj2=new Secprog("Person2", 22);
}
}

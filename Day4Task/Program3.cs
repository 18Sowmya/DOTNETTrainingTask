using System;
class Emp
{
public int id, exp;
public string name, gender;
public Emp(int eid, string ename, string egender, int eexp)
{
id=eid;
name=ename;
gender=egender;
exp=eexp;
}
}
class Dept
{
string Dname;
int Salary;
public Emp eobj;
double BSalary;
public Dept(string dept, int sal, Emp emp)
{
Dname=dept;
Salary=sal;
eobj=emp;
}


public void calculate_Bonus()
    {
        if (Dname == "SalesAndMarketing")
        {
            BSalary = Salary + (0.2 * Salary);
            Console.WriteLine($"(Bonus Applicable 20%) Employee Salary is:{BSalary} ");
        }
       else if (Dname == "Production")
        {
            BSalary = Salary + (0.1 * Salary);
            Console.WriteLine($"(Bonus Applicable 10%) Employee Salary is:{BSalary}");
        }

        else
        {
            Console.WriteLine($"(No Bonus Applicable) Employee Salary is: {Salary}  ");
        }
 
Console.WriteLine($"Department : {Dname}");
Console.WriteLine($"Employee id : {eobj.id}");
Console.WriteLine($"Employee name : {eobj.name}");
Console.WriteLine($"Gender : {eobj.gender}");
Console.WriteLine($"Experience : {eobj.exp}");
}
public static void Main()
{
Emp e1=new Emp(17, "employee1", "female", 3);
Dept d1=new Dept("SalesAndMarketing",10000, e1);
d1.calculate_Bonus();
Emp e2=new Emp(18, "employee2", "male", 4);
Dept d2=new Dept("Production",20000, e2);
d2.calculate_Bonus();
Emp e3=new Emp(19, "employee3", "female", 5);
Dept d3=new Dept("Support",30000, e3);
d3.calculate_Bonus();



}
}


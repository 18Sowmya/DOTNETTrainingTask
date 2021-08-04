using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace String_Program
{
    [Serializable]
    class SereClass
    {
        int Id;
        String Name;
        String Gender;
        int Age;
        public SereClass(int Eid, String Ename, String Egender, int Eage)
        {
            Id=Eid;
            Name = Ename;
            Gender = Egender;
            Age = Eage;
        }

       
        public static void Main()
        {
            SereClass sclass = new SereClass(17,"Sure","Male",21);
            FileStream fs = new FileStream("D:\\Inatech\\SereData.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, sclass);
            fs.Close();
            
            FileStream fsr = new FileStream("D:\\Inatech\\SereData.txt", FileMode.Open, FileAccess.Read);
            SereClass sc = (SereClass)bf.Deserialize(fsr);
            Console.WriteLine(sc.Id);
            Console.WriteLine(sc.Name);
            Console.WriteLine(sc.Gender);
            Console.WriteLine(sc.Age);
            Console.ReadLine();
            fsr.Close();
        }
    }
}

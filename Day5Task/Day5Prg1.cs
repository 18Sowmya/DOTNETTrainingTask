using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Program
{
    class Day5Prg1
    {
        
            
            public void WriteFyle()
            {
            ArrayList al = new ArrayList();
              al.Add("Cakes");
              al.Add("Mousse");
              al.Add("Brownies");
              al.Add("Icecreams");
              al.Add("Pudding");
            FileStream fs = new FileStream("D:\\Inatech\\Fyle1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.BaseStream.Seek(0, SeekOrigin.End);
                foreach (var i in al)
                {
                sw.Write(i + "\n");
                }
                sw.Flush();
                sw.Close();
                fs.Close();

            }
            public void ReadFyle()
            {
                FileStream fs = new FileStream("D:\\Inatech\\Fyle1.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                Console.WriteLine(
                    sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }

            public void FyleDetail()
            {
              
                FileInfo f1 = new FileInfo("D:\\Inatech\\Fyle1.txt");

                Console.WriteLine(f1.Length);
                Console.WriteLine(f1.CreationTime);

                String filepath = "D:\\Inatech\\Fyle1.txt";
                if (File.Exists(filepath))
                {
                    Console.WriteLine("File Exists");
                }
            Console.ReadLine();
            }
            public static void Main()
        {
           

            Day5Prg1 obj = new  Day5Prg1();
            obj.WriteFyle();
            obj.ReadFyle();
            obj.FyleDetail();
        }
    }
}

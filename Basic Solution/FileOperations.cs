using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\User\\Desktop"+"\\FileManager\\Sample.txt");
            using StreamWriter str= fi.CreateText();
            Console.WriteLine("file has been created");

            str.WriteLine("hello there");
            str.Write("hi");
            Console.WriteLine("written");
      
        }

        public void WriteData()
        {
            FileStream fs = new FileStream ("C:\\Users\\User\\Desktop\\FileManager\\Sample2.txt", FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);    
            Console.WriteLine("enter the text which  you want ");
            string? str= Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            sw.Close();
            
        }

        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\User\\Desktop\\FileManager\\Sample2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = Console.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str=sr.ReadLine();
            }
            sr.Close();
            fs.Close(); 

        }

       /* public void CopyMoveFile()
        {
            FileStream fi1 = new FileStream("C:\\Users\\User\\Desktop\\FileManager\\Sample.txt");
            StreamReader sr = new StreamReader(fs);
            

        }*/

        public void FileProperties()
        {
            FileInfo fi = new FileInfo("C:\\Users\\User\\Desktop" + "\\FileManager\\Sample.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Length.ToString());  
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Exists);
        
        }


    }
}

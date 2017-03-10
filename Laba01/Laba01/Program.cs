using System;
using System.IO;

namespace Laba01
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            string chch = sr.ReadLine();
            string[] mas = chch.Split(' ');
            long a = Int32.Parse(mas[0]);
            long b = Int32.Parse(mas[1]);
            long c = a + b*b;
            sr.Close();
            string d = c.ToString();
            StreamWriter sw = new StreamWriter("output.txt");//для записи
            sw.WriteLine(d);
            sw.Close();
        }
    }
}

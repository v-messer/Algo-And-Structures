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
            int a = Int32.Parse(mas[0]);
            int b = Int32.Parse(mas[1]);
            int c = a + b;
            sr.Close();
            string d = c.ToString();
            StreamWriter sw = new StreamWriter("output.txt");//для записи
            sw.WriteLine(d);
            sw.Close();
        }
    }
}

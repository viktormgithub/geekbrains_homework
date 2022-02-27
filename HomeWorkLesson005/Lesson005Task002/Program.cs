using System;
using System.IO;

namespace Lesson005Task002
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            File.WriteAllText("Lesson005Task002.txt",DateTime.Now.ToString("HH:m:s"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
 
        string s1 = "Hrvatska ima more";
        string s2 = "Italija je prvak svijeta";   
        string prvih8ZnakovaS1 = s1.Substring(0, 8);
        string ostatakS2 = s2.Substring(6);
        string s3 = prvih8ZnakovaS1 + ostatakS2;

        Console.WriteLine("s1: " + s1);
        Console.WriteLine("s2: " + s2);
        Console.WriteLine("s3: " + s3);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWriter fw = new FileWriter("../../stuff.txt");
            fw.WriteToFile("hello");
            FileReader fr = new FileReader();
            //fr.ReadFile("../../stuff.txt");
            //Console.WriteLine(fr.text);
            int num = 55;
            fr.Add5(ref num);
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}

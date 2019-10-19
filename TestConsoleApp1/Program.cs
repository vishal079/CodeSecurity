using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataCall obj = new DataCall();
            DataTable dt = new DataTable();
            dt = obj.GetData();
            Console.WriteLine(dt);
        }
    }
}

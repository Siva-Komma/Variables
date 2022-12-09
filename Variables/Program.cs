using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            LocalVariables lc = new LocalVariables();
            Console.WriteLine("Enetr Var1 ");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Var2 ");
            int var2 = Convert.ToInt32(Console.ReadLine());
            lc.Local();
            Console.ReadLine();

        }
    }
}

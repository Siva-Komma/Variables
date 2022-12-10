using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            Console.WriteLine("Enter Num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num1: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
          
            lc.LocalV(10,20);
            Console.ReadLine();


// Instance variables

           // Instancevar iv = new Instancevar();
          //iv.var1 = 10;
          //  iv.var2 = 20;
            //iv.sum = (iv.var1 + iv.var2);
           // Console.WriteLine(iv.var1);
           // Console.WriteLine(iv.var2);
           // Console.WriteLine(iv.sum);
           // iv.Instancev();



// Static variables

            // StaticVariables.sal = 100000;
            //Console.WriteLine(StaticVariables.name + " average sal " + StaticVariables.sal);
            //Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
         
        static void Main(string[] args)
        {
            int     sum     = 0;
            int     raznost = 0;
            int     umnog   = 0;
            double  del     = 0;

            int operand1 = 10;
            int operand2 = 5;

            DoFatalityBabality(operand1, operand2, ref sum, ref raznost, ref umnog, ref del);


            Console.WriteLine(sum);
            Console.WriteLine(raznost);
            Console.WriteLine(umnog);
            Console.WriteLine(del);

            Console.ReadKey();
        }

        static void DoFatalityBabality(int operand1, int operand2, ref int sum, ref int raznost, ref int umnog, ref double del)
        {
            sum      = operand1 + operand2;
            umnog    = operand1 * operand2;
            del      = operand1 / operand2;
            raznost  = operand1 - operand2;
        }
    }
}

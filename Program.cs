using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            int inputNum = Convert.ToInt32 ( Console.ReadLine ( ) );

            for (int i = 2 ; i < inputNum ; i++)
            {
                if (inputNum % i == 0)
                {
                    Console.WriteLine ( "NO" );
                    break;
                }
                else
                {
                    Console.WriteLine ( "YES" );
                    break;
                }
            }
        }
    }
}

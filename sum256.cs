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
            int iInNumber1;
            int iLoop1;
            int iLoop2;
            int iSum;
            string[] sInNumber2;

            iInNumber1 = int.Parse(Console.ReadLine());
            sInNumber2 = Console.ReadLine().Split(' ');

            for(iLoop1 = 0; iLoop1 < sInNumber2.Length; iLoop1++)
            {
                iSum = iInNumber1 + int.Parse(sInNumber2[iLoop1]);

                if (iSum == 256)
                {
                    Console.WriteLine("yes");
                    return;
                }

                for (iLoop2 = 0; iLoop2 < sInNumber2.Length; iLoop2++)
                {
                    //iLoop1と同じ要素数または最後の要素数の場合
                    if (iLoop1 == iLoop2)
                    {
                        iLoop2++;
                        if (iLoop2 <= sInNumber2.Length)
                        {
                            break;
                        }
                    }

                    iSum = int.Parse(sInNumber2[iLoop1]) + int.Parse(sInNumber2[iLoop2]);
                    if (iSum == 256)
                    {
                        Console.WriteLine("yes");
                        return;
                    }

                }
                
            }

            //結果256にならない
            Console.WriteLine("no");

        }
    }
}

using System;
using System.Linq;

namespace Korlat_Sandor
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Console.WriteLine("Adj meg 1 és 10 közötti számot!");
            szam = Convert.ToInt32(Console.ReadLine());

            if((szam>=1)&&(szam<=10))
                {
                int[] tomb = new int[szam];

                for(int i=0;i<szam;i++)
                    {
                    Console.Write("Kérem a {0}. szamot! ", i+1);
                    tomb[i]=Convert.ToInt32(Console.ReadLine());
                    }
                Console.WriteLine("Legnagyobb szám: {0}, legkisebb szám: {1}", tomb.Max(), tomb.Min());
                }
            else
                {
                Console.WriteLine("1 és 10 közötti számot kérek legközelebb!!! ");
                }
        }
    }
}

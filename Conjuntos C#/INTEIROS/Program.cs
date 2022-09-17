using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTEIROS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConjuntoDeInteiros conj1 = new ConjuntoDeInteiros();
            int [] inteiros1  = new int[11]{0,3,8,0,0,0,0,0,0,0,0};
            int [] inteiros2 = new int[11] { 0, 3, 8, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i <= 10; i++)
            {
                conj1.booleanos1[inteiros1[i]] = true;
            }
            for (int i = 0; i <= 10; i++)
            {
                conj1.booleanos2[inteiros2[i]] = true;
            }
            conj1.uniao(conj1.booleanos1 , conj1.booleanos2);

        }
    }
}

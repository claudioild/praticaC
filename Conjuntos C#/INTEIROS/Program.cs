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
            int [] inteiros1  = new int[11]{0,5,1,0,0,0,0,0,0,0,0};
            int [] inteiros2 = new int[11] { 0, 1, 5, 7, 0, 0, 0, 0, 0, 0, 0 };
            int elementoInserido = 7;
            int elementtoDeletado = 7;
            for (int i = 0; i <= 10; i++)
            {
                conj1.booleanos1[inteiros1[i]] = true;
            }
            for (int i = 0; i <= 10; i++)
            {
                conj1.booleanos2[inteiros2[i]] = true;
            }
            conj1.insereElementoBool1(elementoInserido);
            conj1.deletaElementoBool2(elementtoDeletado);
            Console.WriteLine("Conjunto 1: {0}\nConjunto 2: {1}", conj1.toSetString(conj1.booleanos1), conj1.toSetString(conj1.booleanos2));
            Console.WriteLine("União dos conjuntos: {0}", conj1.toSetString(conj1.uniao(conj1.booleanos1, conj1.booleanos2)));
            Console.WriteLine("Intersecção dos conjuntos: {0}", conj1.toSetString(conj1.intersecao(conj1.booleanos1, conj1.booleanos2)));
            conj1.eIgualA(conj1.booleanos1, conj1.booleanos2);
        }
    }
}

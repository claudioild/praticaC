using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] resultado = new int[6];
            for(int i = 0;i<resultado.Length;i++)
            {
                Console.WriteLine("Digite o resultado do sorteio: ");
            }

            ApostaMegaSena aposta1 = new ApostaMegaSena();
            aposta1.leAposta();
            aposta1.apuraResultado(resultado);
            aposta1.mostraResultado();

            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine(resultado[i]);
            }
        }
    }
}

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
            int contResult = 0;
            int parada=0;
            Console.WriteLine("Digite o resultado do sorteio: ");
            while(contResult<6)
            {
                int numAposta = Int32.Parse(Console.ReadLine());
                for(int j = 0; j < 6; j++) // verifica repetição
                {
                    if(numAposta == resultado[j])
                    {
                        int verifRepet = 0;
                        while(verifRepet < 1)
                        {
                            Console.WriteLine("Digite um número diferente do que já digitou!");
                            numAposta = Int32.Parse(Console.ReadLine());
                            if(numAposta != resultado[j])
                            {
                                verifRepet++;
                            }
                        }
                    }
                    j++;
                }
                while (numAposta < 0 || numAposta > 60) // verifica se o num atende os requisitos
                {
                    Console.WriteLine("O número da aposta deve estar entre 1 e 60!!!");
                    numAposta = Int32.Parse(Console.ReadLine());
                }
                
                resultado[contResult] = numAposta;
                contResult++;
            }
            ApostaMegaSena aposta1 = new ApostaMegaSena();
            aposta1.leAposta();
            aposta1.apuraResultado(resultado);
            aposta1.mostraResultado();

            parada = Int32.Parse(Console.ReadLine());
        }
    }
}

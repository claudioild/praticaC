using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class ApostaMegaSena
    {
        int[] aposta=new int[10];
        int[] resultado = new int[6];
        int contVitoria = 0;
        public void leAposta()
        {
            int i = 0;
            Console.WriteLine("Digite os 10 números da aposta: ");
            while(i<10)
            {
                int numAposta = Int32.Parse(Console.ReadLine());
                for(int j = 0; j < 9; j++) // verifica repetição
                {
                    if(numAposta == aposta[j])
                    {
                        int verifRepet = 0;
                        while(verifRepet < 1)
                        {
                            Console.WriteLine("Digite um número diferente do que já digitou!");
                            numAposta = Int32.Parse(Console.ReadLine());
                            if(numAposta != aposta[j])
                            {
                                verifRepet++;
                            }
                        }
                    }
                    j++;
                }
                while (numAposta < 0 || numAposta > 60)
                {
                    Console.WriteLine("O número da aposta deve estar entre 1 e 60!!!");
                    numAposta = Int32.Parse(Console.ReadLine());
                }
                
                aposta[i] = numAposta;
                i++;

            }
        }
        public void apuraResultado(int[]resultado)
        {
            int i = 0;
            while (i < 10)
            {
                int a = 0;
                while (a < 6)
                {
                    if (resultado[a] == aposta[i])
                    {
                        contVitoria++;
                    }
                    a++;
                }
                i++;
            }
        }
        public void mostraResultado()
        {
            if(contVitoria == 6)
            {
                Console.WriteLine("PARABÉNS VOCÊ ACERTOU {0} NÚMEROS E GANHOU :)", contVitoria) ; 
            }
            else
            {
                Console.WriteLine("INFELIZMENTE VOCÊ ACERTOU SOMENTE {0} E NÃO GANHOU :(", contVitoria);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTEIROS
{
    internal class ConjuntoDeInteiros
    {
        public bool [] booleanos1= new bool[12];
        public bool [] booleanos2 = new bool[12];


        public ConjuntoDeInteiros()
        {
            for (int i = 0; i <= 10; i++)
            {
                booleanos1[i]=false;
            }
            for (int i = 0; i <= 10; i++)
            {
                booleanos2[i] = false;
            }
        }

        public bool[] uniao(bool []booleanos1,bool []booleanos2)
        {
            bool[] booleanosUniao = new bool[12];

            for (int i = 0; i <= 10; i++)
            {
                booleanosUniao[i] = false;
            }

            for(int i = 0;i <= 10; i++)
            {
                if (booleanos1[i] == true || booleanos2[i] == true)
                {
                    booleanosUniao[i] = true;
                }
            }
            return booleanosUniao;
        }
        public bool[] intersecao(bool[] booleanos1, bool[] booleanos2)
        {
            bool[] booleanosIntersec = new bool[12];
            for (int i = 0; i <= 10; i++)
            {
                booleanosIntersec[i] = false;
            }

            
            for (int i = 0; i <= 10; i++)
            {
                if (booleanos1[i] == true && booleanos2[i] == true)
                {
                    booleanosIntersec[i] = true;
                }
            }
            return booleanosIntersec;
        }
        public bool[] insereElemento(int numInserido)
        {
            booleanos1[numInserido] = true;
            return booleanos1;
        }
        public bool[] deletaElemento(int numDeletado)
        {
            booleanos1[numDeletado] = false;
            return booleanos1;
        }

        public string toSetString(bool[] booleanos)
        {
            int [] inteiros = new int [11];
            string listaNum = "";
            for (int i = 0; i <= 10; i++)
            {
                if (booleanos[i] = true)
                {
                    listaNum += i;
                }
                else
                {
                    listaNum += " - ";
                }
                
            }
            return listaNum;
        }
        public void eIgualA (bool[]booleanos1, bool[] booleanos2)
        {
            int contIgualdade = 0;
            for(int i = 0;i <= 10; i++)
            {
                if(booleanos1[i] == booleanos2[i])
                {
                    contIgualdade++;
                }
                if(contIgualdade == 11)
                {
                    Console.WriteLine("Os conjuntos são iguais");
                }
                else
                {
                    Console.WriteLine("Os conjuntos não são iguais");
                }
            }
        }
    }
}

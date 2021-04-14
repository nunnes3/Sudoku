using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando a matriz do tipo inteiro 
            int[,] matriz = new int[9, 9] {
            {1,3,2,5,7,9,4,6,8 },
            {4,9,8,2,6,1,3,7,5},
            {7,5,6,3,8,4,2,1,9},
            {6,4,3,1,5,8,7,9,2},
            {5,2,1,7,9,3,8,4,6},
            {9,8,7,4,2,6,5,3,1},
            {2,1,4,9,3,5,6,8,7},
            {3,6,5,8,1,7,9,2,4},
            {8,7,9,6,4,2,1,5,3},
            };



            // Imprimindo matriz na tela
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();

                for (int x = 0; x < 9; x++)
                {
                    Console.Write(matriz[i, x] + " ");
                }
            }
            Console.WriteLine();

            VerificaMetodos(matriz);

            Console.ReadLine();

            

        }

        private static void VerificaMetodos(int[,] matriz)
        {

            // Caso os metodos retornem true o jogo será validado, caso contrário jogo invalido

            if (VerificaColunasLinhas(matriz) && TresPorTres(matriz) == true)
            {
                Console.WriteLine("Jogo válido");
            }
            else
            {
                Console.WriteLine("NAO");
            }
        }

        private static bool TresPorTres(int[,] matriz)
        {
            HashSet<int> teste = new HashSet<int>();
            bool verificacao = true;

            for (int i = 0; i < 9; i += 3)
            {
                for (int y = 0; y < 9; y += 3)
                {
                    teste = new HashSet<int>();

                    for (int x = 0; x < 3; x++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            verificacao = teste.Add(matriz[x + i, j + y]);
                            if (!verificacao) {

                                return verificacao;
                            }
                        }
                    }

                }
            }
            return verificacao;
        }



        private static bool VerificaColunasLinhas(int[,] matriz)
        {

            //verificando Linhas


            // instanciando variavel bool = true
            bool verificacao = true;

            for (int i = 0; i < 9; i++)
            {

                //Hash set não consegue retornar numeros iguais
                HashSet<int> teste = new HashSet<int>();
                for (int x = 0; x < 9; x++)
                {
                    verificacao = teste.Add(matriz[i, x]);
                    if (!verificacao)
                    {
                         return verificacao; 
                    }
                }
            }

            return verificacao;
        }

    } 

}


    


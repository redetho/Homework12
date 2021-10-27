using System;
//atividade matrizes 2
namespace Homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            //recebe o numero m e converte a linha recebida em int32 (de string para int)
            Console.WriteLine("Digite um número.");
            int m = Convert.ToInt32(Console.ReadLine());
            //recebe o numero n e converte a linha recebida em int32 (de string para int)
            Console.WriteLine("Digite outro número.");
            int n = Convert.ToInt32(Console.ReadLine());
            //cria a matriz com m e n.
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                //recebe a sequencia, separada pela barra de espaço (' ')
                Console.WriteLine("Digite a sequência de números.");
                string[] numeros = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    //transforma a matriz digitada pelo usuário em int.
                    matriz[i, j] = Convert.ToInt32(numeros[j]);
                }
            }
            //recebe X.
            Console.WriteLine("Digite o número a ser encontrado.");
            int x = int.Parse(Console.ReadLine());
            //para cada numero presente na matriz, busca X.
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        //se existe dentro da matriz, avisa e localiza através do IF.
                        Console.WriteLine("o número foi encontrado em:" + i +" , "+ j );
                        if (j > 0)
                        {
                            Console.WriteLine("na esquerda: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("acima: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("na direita: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}

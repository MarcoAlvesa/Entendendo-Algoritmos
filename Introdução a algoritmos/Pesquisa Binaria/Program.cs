using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
namespace PesquisaBinaria
{
    public class Program
    {
        static int pesquisar(int[] lista, int item)
        {
            int baixo = 0;
            int alto = lista.Length - 1;

            while (baixo <= alto)
            {
                int meio = (baixo + alto)/2;
                int chute = lista[meio];
                if (chute == item)
                    return meio;
                if (chute > item)
                    alto = meio - 1;
                else
                {
                    baixo = meio + 1;
                }
            }
            return -1;
        }
        static void Main(string [] args){
            int[] minha_lista = [1, 3, 5, 7, 9];

            Console.WriteLine(pesquisar(minha_lista, 1));
            Console.WriteLine(pesquisar(minha_lista, 3));
            Console.WriteLine(pesquisar(minha_lista, 5));
            Console.WriteLine(pesquisar(minha_lista, 7));
            Console.WriteLine(pesquisar(minha_lista, 9));
            Console.WriteLine(pesquisar(minha_lista, 2));
        }
    }
}
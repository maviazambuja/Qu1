using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1prova1POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome, por favor: ");
            string nomeDoUsuario = Console.ReadLine();
         
            //criei o objeto nome próprio

            NomeProprio nomeProprio = new NomeProprio(nomeDoUsuario);
            nomeProprio.Nome_rev_paper();

            Console.Write("" + nomeProprio);

            
        }
    }
}

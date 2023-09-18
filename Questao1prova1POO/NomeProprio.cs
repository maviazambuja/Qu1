using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1prova1POO
{
    public class NomeProprio
    {
        private string nome_completo;
        private string nome_paper;


        public NomeProprio(string _nome_completo) 
        {
            nome_completo = _nome_completo;
            nome_paper = null;
        }

        public void Nome_rev_paper() 
        {
            string[] partesNome = nome_completo.Split(' '); //fiz um split para separar a string
            int numerostrings = partesNome.Length;
            if (numerostrings == partesNome.Length) 
            {
                Array.Reverse(partesNome);      //função que muda a ordem 
                nome_paper = string.Join("", partesNome);
                nome_paper = nome_paper.Insert(nome_paper.IndexOf(' ') + 1, ",") + ".";

            } 

        }


        public string Nome_completo { get => nome_completo; set => nome_completo = value; }
        public string Nomme_paper { get => nome_paper; set => nome_paper = value; }
    }
}

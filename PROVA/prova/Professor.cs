using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Professor : Pessoa
    {
        private string formacao;

        public Professor(string n, string e, string f) : base(n ,e)
        {
            formacao = f;
        }
       
 
        public string GetFormacao()
        {
            return formacao;
        }


        public override string ToString()
        {
            return $"{formacao}";
        }
    }
}

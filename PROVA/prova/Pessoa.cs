using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Pessoa
    {
        private string email;
        private string nome;

        public Pessoa(string n, string e)
        {
            nome = n;
            email = e;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetEmail()
        {
            return email;
        }

        public override string ToString()
        {
            return $"{nome} - {email}";
        }
    }
}

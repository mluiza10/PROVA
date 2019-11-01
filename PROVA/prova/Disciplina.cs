using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Disciplina
    {
        private string nome;
        private int ch;

        public Disciplina (string n, int ch)
        {
            nome = n;
            this.ch = ch;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCh()
        {
            return ch;
        }

        public override string ToString()
        {
            return $"{nome} - {ch}";
        }
    }
}

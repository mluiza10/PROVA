using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Aluno : Pessoa : Icomparable
    {
        private string matricula;
        private DateTime dataingresso;


        public Aluno(string n, string e, string m) : base(n, e)
        {
            matricula = m;
        }

     

        public int CompareTo(object obj)
        {
            return matricula.CompareTo((obj as Aluno).matricula);
        }

        public override string ToString()
        {
            return $"{matricula} - {dataingresso}";
        }
    }
}

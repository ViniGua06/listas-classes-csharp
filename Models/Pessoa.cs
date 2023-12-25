using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get { return _nome.ToUpper(); }
            set
            {
                _nome = value;
            }
        }

        public int Idade { get; set; }

        public int Codigo { get; set; }
    }
}
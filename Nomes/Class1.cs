using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    public class Pessoa
    {
        public int codigo { get; set; }
        public string nome { get; set; }



        public Pessoa(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public Pessoa()
        {

        }

    }


}
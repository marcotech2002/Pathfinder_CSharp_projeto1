using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_clube
{
    internal abstract class Pessoa
    {
        //Declaração de atributos
        protected int id_pessoa;
        protected String nome_pessoa;
        protected String email_pessoa;
        protected int ativo_pessoa;

        //Getters e setters
        public string Nome_pessoa { get => nome_pessoa; set => nome_pessoa = value; }
        public string Email_pessoa { get => email_pessoa; set => email_pessoa = value; }
        public int Ativo_pessoa { get => ativo_pessoa; set => ativo_pessoa = value; }
        public int Id_pessoa { get => id_pessoa; set => id_pessoa = value; }
    }
}

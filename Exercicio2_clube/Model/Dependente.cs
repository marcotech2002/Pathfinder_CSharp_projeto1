using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_clube
{
    internal class Dependente : Pessoa
    {
        //Declaração de atributos
        private Cliente cliente;
        private String parentesco_dependente;

        //Construtor padrão
        public Dependente()
        {
            this.Cliente = new Cliente();
        }

        //Getter e setter
        public string Parentesco_dependente { get => parentesco_dependente; set => parentesco_dependente = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
    }
}

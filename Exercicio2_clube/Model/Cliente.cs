using System;
using System.Collections.Generic;
using Exercicio2_clube.Model;

namespace Exercicio2_clube
{
    internal class Cliente : Pessoa
    {
        //Declaração de atributos
        private int ddd_cliente;
        private List<Mensalidade> lista_mensalidades;
        private Categoria categoria_cliente;
        private String telefone_cliente;
        private String cep_cliente;
        private String uf_cliente;
        private String cidade_cliente;
        private String bairro_cliente;
        private String logradouro_cliente;
        private List<Dependente> lista_dependentes;

        //Construtor padrão
        public Cliente()
        {
            this.Categoria_cliente = new Categoria();
        }

        //Getters e setters
        public string Cep_cliente { get => cep_cliente; set => cep_cliente = value; }
        public string Uf_cliente { get => uf_cliente; set => uf_cliente = value; }
        public string Cidade_cliente { get => cidade_cliente; set => cidade_cliente = value; }
        public string Bairro_cliente { get => bairro_cliente; set => bairro_cliente = value; }
        public string Logradouro_cliente { get => logradouro_cliente; set => logradouro_cliente = value; }
        public int Ddd_cliente { get => ddd_cliente; set => ddd_cliente = value; }
        public string Telefone_cliente { get => telefone_cliente; set => telefone_cliente = value; }
        internal Categoria Categoria_cliente { get => categoria_cliente; set => categoria_cliente = value; }
        internal List<Mensalidade> Lista_mensalidades { get => lista_mensalidades; set => lista_mensalidades = value; }
        internal List<Dependente> Lista_dependentes { get => lista_dependentes; set => lista_dependentes = value; }

        //Método para retornar o telefone formatado
        public String Telefone()
        {
            String ddd = this.Ddd_cliente.ToString();
            return "(" + ddd + ")" + this.telefone_cliente;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_clube.Model
{
    internal class Mensalidade
    {
        //Declaração de atributos
        private int id_mensalidade;
        private Cliente cliente;
        private DateTime dtv_mensalidade;
        private double vlri_mensalidade;
        private DateTime dtp_mensalidade;
        private int juros_mensalidade;
        private double vlrf_mensalidade;
        private int quitada_mensalidade;

        //Construtor padrão
        public Mensalidade()
        {
            this.cliente = new Cliente();
        }

        //Getters e setters
        public DateTime Dtv_mensalidade { get => dtv_mensalidade; set => dtv_mensalidade = value; }
        public double Vlri_mensalidade { get => vlri_mensalidade; set => vlri_mensalidade = value; }
        public DateTime Dtp_mensalidade { get => dtp_mensalidade; set => dtp_mensalidade = value; }
        public int Juros_mensalidade { get => juros_mensalidade; set => juros_mensalidade = value; }
        public double Vlrf_mensalidade { get => vlrf_mensalidade; set => vlrf_mensalidade = value; }
        public int Quitada_mensalidade { get => quitada_mensalidade; set => quitada_mensalidade = value; }
        public int Id_mensalidade { get => id_mensalidade; set => id_mensalidade = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
    }
}

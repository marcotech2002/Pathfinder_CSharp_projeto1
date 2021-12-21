using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_clube.Model
{
    internal class Categoria
    {
        //Declaração de atributos
        private int id_categoria;
        private String nome_categoria;

        //Getter e setter
        public string Nome_categoria { get => nome_categoria; set => nome_categoria = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
    }
}

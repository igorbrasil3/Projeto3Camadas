using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.CODE.DTO
{
    internal class DTO_cliente
    {
        int id_cliente;
        String nome;
        String email;
        String telefone;
        String endereco;
        String formaPagamento;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string FormaPagamento { get => formaPagamento; set => formaPagamento = value; }
    }
}

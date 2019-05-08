using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; } /*colocado devido a ter uma colection com o usuario*/
        public DateTime DataPrevisaoEntrega { get; set; }

        //para facilitar os campos abaixo foram colocado na mesma classe para facilitar porém poderia estar em outra classe
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto{ get; set; }
        public string NumeroEndereco { get; set; }


        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }


        //Um pedido pode ter um ou vários itens por isso usei a ICollection  
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any()) /* Se não existir nenhum item de pedido faz o procedimento abaixo*/
            {
                AdicionarCritica("Um pedido não pode ficar sem itens"); /*AdicionarCritica é uma funcção que esta dentro da classe Entidade*/                
            }

            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("CEP deve estar preenchido");
            }

            if (FormaPagamentoId == 0)
            {
                AdicionarCritica("Não foi informado a forma de Pagamento");
            }


        }
    }
}

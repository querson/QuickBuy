﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario : Entidade
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        //Um usuário pode ter nenhum ou muitos pedidos por isso usei a ICollection  
        public ICollection<Pedido> Pedidos{ get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

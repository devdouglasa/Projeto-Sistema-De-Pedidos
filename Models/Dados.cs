using System;
using System.Collections.Generic;

namespace projeto_sistema_cadastro.Models
{


    public static class Dados
    {

        public static Pedido PedidoAtual;

        
        static Dados() {

            PedidoAtual = new Pedido();
        }
    }
}
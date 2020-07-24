﻿using System.Globalization;

namespace AdicionaRemoveProduto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // calcula valor total produto estoque
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        // Executa soma valor atual + valor de entrada
        public void AdicionarProdutos(int quantidade)
        {   // Quantidade = Quantidade + quantidade
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {   // Quantidade = Quantidade - quantidade
            Quantidade -= quantidade;
        }
        // formata saida dos dados do produto para String
        public override string ToString()
        {
            return Nome
              + ", $ "
              + Preco.ToString("F2", CultureInfo.InvariantCulture)
              + ", "
              + Quantidade
              + " unidades, Total: $ "
              + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
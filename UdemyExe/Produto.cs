using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UdemyExe
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValotTotalEmStock()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {
            //Quantidade = Quantidade + quantidade;
            Quantidade += quantidade;

        }
        public void RemoverProdutos(int quantidade)
        {
            //Quantidade = Quantidade - quantidade;
            Quantidade -= quantidade;

        }
        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValotTotalEmStock().ToString("F2", CultureInfo.InvariantCulture);
                
        }
    }
}

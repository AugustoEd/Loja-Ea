using System;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaEa
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void Adicionar_Prdodutos(int quantidade)
        {
            Quantidade += quantidade;

        }

        public void Remover_Produtos (int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture)  + " Unidades " + Quantidade + " TOTAL: $ "
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
            
        }
    }
}

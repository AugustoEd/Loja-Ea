using System.Globalization;


namespace LojaEa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Insira o nome do produto");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço do produto:");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Insira a quantidade de itens");
            p.Quantidade= int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do produto:" + p);

            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque:");
            int qte =int.Parse(Console.ReadLine());
            p.Adicionar_Prdodutos(qte);

            Console.WriteLine("Dados atualizados: " + p);


            Console.WriteLine("Digite o numero de produtos a ser removido do estoque:");
            int remov = int.Parse(Console.ReadLine());
            p.Remover_Produtos(remov);

            Console.WriteLine("Dados atualizados: " + p);



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP2
{
     class Loja
    {
        private static List<Pedidos> PedidosLoja = new List<Pedidos>();

        public void Menu()
        {
            Loja loja = new Loja();

            string opcao;

            Console.WriteLine("\nSISTEMA DE CADASTRO E CONSULTA DE PEDIDOS");
            do
            {
                Pedidos Item = new Pedidos();

                Console.WriteLine("\nInforme o ID do Produto: ");
                Item.PedidoId = int.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme a Descrição do Produto: ");
                Item.DescricaoDoProduto = (Console.ReadLine());

                Console.WriteLine("\nInforme o Valor Unitário do Produto: ");
                Item.ValorDoProduto = float.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme a Quantidade: ");
                Item.Quantidade = int.Parse(Console.ReadLine());

                loja.InserirPedido(Item);

                Console.WriteLine("\nDeseja adicionar mais itens ao Pedido?: [s/n]");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "s":
                        Console.WriteLine("\nAdiciona novamente um item ao seu carrinho:");
                        break;

                    case "n":
                        Console.WriteLine("\nPedidos no seu carrinho: \n");
                        Console.WriteLine("-------------------------------------");
                        loja.ListaPedido();
                        loja.Total();
                        break;

                    default:
                        Console.WriteLine("\nO valor digitado é inválido!");
                        break;
                }
            } while (opcao == "s");
        }
        public void ListaPedido()
        {
            foreach(Pedidos pe in PedidosLoja)
            {
                Console.WriteLine("ID: " + pe.PedidoId + "\nDescrição do Produto: " + pe.DescricaoDoProduto + "\nValor Unitário: " + pe.ValorDoProduto + "\nQuantidade: " + pe.Quantidade + "\nData Emissão: " + pe.DataEmissao);
                Console.WriteLine("-------------------------------------");
            }

        }
        public void InserirPedido(Pedidos pedi)
        {
            PedidosLoja.Add(pedi);
        }
        public void Buscar(int idDeBusca)
        {
            Pedidos pedidoAuxiliar;
            pedidoAuxiliar = PedidosLoja.Find(x => x.PedidoId == idDeBusca);
            Console.WriteLine($"ID: {pedidoAuxiliar.PedidoId} ");
            Console.WriteLine($"Descrição do Produto: {pedidoAuxiliar.DescricaoDoProduto} ");
            Console.WriteLine($"Valor Unitário: {pedidoAuxiliar.ValorDoProduto} "); 
            Console.WriteLine($"Quantidade: {pedidoAuxiliar.Quantidade} ");
            Console.WriteLine($"Data Emissão: {pedidoAuxiliar.DataEmissao} "); 
        }
        public void Remove(int idDeBuscaRemover)
        {
            Pedidos idDeBuscaRemo;
            idDeBuscaRemo = PedidosLoja.Find(x => x.PedidoId == idDeBuscaRemover);
            Console.WriteLine(idDeBuscaRemo.DescricaoDoProduto);

            var items = PedidosLoja.ToArray();
            foreach (Pedidos pe in items)
            {
                if(idDeBuscaRemover == pe.PedidoId)
                {
                    PedidosLoja.Remove(pe);
                }
            }
        }
        public void Total()
        {
            float total = 0;
            foreach (Pedidos pe in PedidosLoja)
            {
                total += (pe.ValorDoProduto * pe.Quantidade);
            }
            Console.WriteLine("Total: R$ " + total);
        }
        public float Desconto()
        {
            float total = 0;
            foreach (Pedidos pe in PedidosLoja)
            {
                total += (pe.ValorDoProduto * pe.Quantidade);
            }
            return total;
        }
     

    }   
  
}

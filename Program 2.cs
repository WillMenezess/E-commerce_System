using System;

namespace AOP2
{
    class Program
    {
        // FEITO POR WILLIAM MENEZES, BRUNA VIANA, JHULYO FERREIRA
        enum Menu {Inserir = 1, Buscar = 2, Remover = 3, Listar = 4, Fechar = 5, Sair = 6}
        static void Main(string[] args)
        {
            bool sair = false;
      
            Gerente gerente = new Gerente("Vinicius", 0001, 1001);
            Estagiario estagiario = new Estagiario("Ricardo", 0002, 1002);
            
            Console.WriteLine("\nBem-vindo ao Sistema de Pedidos Lux!");
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Quem está realizando o atendimento?\n");
            Console.WriteLine("1 - Vinicius Rosalen [Gerente] \n2 - Ricardo [Estagiário]\n");

            
            int funcionario = int.Parse(Console.ReadLine());
            int func = funcionario;
            while (true)
            {
                
                if (func == 1 || func == 2)
                {
                    break;
                }
            Console.WriteLine("\nOpcão inválida! Digite a numeração correspondente!\n");
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Quem está realizando o atendimento?\n");
            Console.WriteLine("1 - Vinicius Rosalen [Gerente] \n2 - Ricardo [Estagiário]\n");
            func = int.Parse(Console.ReadLine());
            }
            
            while (!sair)
                {
                    
                    Loja Lux = new Loja();
                      
                    Console.WriteLine("\nEscolha o número da opção no Menu:\n");
                    Console.WriteLine(" 1 - Inserir Pedido\n 2 - Buscar Pedido\n 3 - Remover Pedido\n 4 - Listar Pedidos\n 5 - Fechar Pedido\n 6 - Sair do Sistema\n");
                    int indice = int.Parse(Console.ReadLine());

                    Menu opcao = (Menu)indice;

                    switch (opcao)
                    {
                        case Menu.Inserir:
                            Lux.Menu();
                            break;

                        case Menu.Buscar:
                            Console.WriteLine("\nDigite o Id do Produto: \n");
                            int idDeBusca = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nO Pedido com id {0} encontrado foi: \n", idDeBusca);
                            Console.WriteLine("-------------------------------------");
                            Lux.Buscar(idDeBusca);
                            Console.WriteLine("-------------------------------------");
                            break;

                        case Menu.Remover:
                            Console.WriteLine("\nDigite o Id do Produto no qual quer remover: \n");
                            int idDeBuscaRemo = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nO Pedido com id {0} foi removido com sucesso!: \n", idDeBuscaRemo);
                            Lux.Remove(idDeBuscaRemo);
                            break;

                        case Menu.Listar:
                            Console.WriteLine("\nLista de Pedidos: \n");
                            Console.WriteLine("-------------------------------------");
                            Lux.ListaPedido();
                            break;

                        case Menu.Fechar:
                        Console.WriteLine("\nEncerrando Pedido");
                        int conf = func;
                        if (conf == 1)
                        {
                            double tot = Lux.Desconto();
                            gerente.DescontoGerente(tot);
                        }
                        else if(conf == 2)
                        {
                            double tot = Lux.Desconto();
                            estagiario.DescontoEstagiario(tot);
                        }

                        break;

                        case Menu.Sair:
                            sair = true;
                            break;

                       default:
                            Console.WriteLine("Digite o número da opção correspondente no Menu.");
                            break;
                    }
                }
            
                }           

            }     
        }
    


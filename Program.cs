using System;
using DIO_workshop.Entities;

namespace DIO_workshop
{
    class Program
    {
        static UserRepository userRepository = new UserRepository();
        static int i = 0;
        static void Main(string[] args)
        {
            String opcao = imprime();

            while(opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        MostrarDados();
                        break;

                    case "2":
                        CadastrarUser();
                        i++;
                        break;

                    case "3":
                        AdicionarSaldo();
                        break;

                    case "4":
                        Comprar();
                        break;

                    case "5":
                        ExcluirUser();
                        break;

                    case "6":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
                opcao = imprime();
            }
            Console.WriteLine("Tchau !");
        }

        private static void ExcluirUser()
        {
            Console.WriteLine("Digite o ID que deseja remover");
            int id = int.Parse(Console.ReadLine());

            userRepository.ExcluirUser(id);
        }

        private static void Comprar()
        {
            userRepository.criaProduto();
            Console.WriteLine("Digite o ID da pessoa que quer comprar");
            int id = int.Parse(Console.ReadLine());

            var user = userRepository.EncontraUser(id);
            if (user.RetornaNome() == "")
            {
                Console.WriteLine("Usuario não existe!");
                return;
            }

            var products = userRepository.mostrarProdutos();
            Console.WriteLine("Escolha algum produto");
            foreach(var x in products)
            {
                Console.WriteLine(x.ToString());
            }

            Console.Write("Digite o Id do produto que deseja comprar!");
            int cod = int.Parse(Console.ReadLine());
            var product = userRepository.retornaProduto(cod);

            var comprar = user.comprarProduto(product);
            if(comprar == false)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }
            Console.WriteLine("Produto comprado com sucesso!");
        }

        private static void AdicionarSaldo()
        {
            Console.WriteLine("Digite o ID do usuario que deseja aumentar o saldo!");
            int id = int.Parse(Console.ReadLine());

            var user = userRepository.EncontraUser(id);
            if(user.RetornaNome() == "")
            {
                Console.WriteLine("Usuario não existe!");
                return;
            }

            Console.WriteLine("Digite o valor do saldo para adicionar");
            Double saldo = Double.Parse(Console.ReadLine());
            user.AdicionarSaldo(saldo);
        }

        private static void CadastrarUser()
        {
            Console.Write("Digite seu nome: ");
            String name = Console.ReadLine();
            Console.Write("Digte seu CPF: ");
            String cpf = Console.ReadLine();
            Console.Write("Digite seu saldo: ");
            Double saldo = Double.Parse(Console.ReadLine());

            var user = new User(id: i, name: name, cpf: cpf, saldo: saldo);
            userRepository.InsereUser(user);
        }

        private static void MostrarDados()
        {
            var user = userRepository.ListarDados();
            if(user.Count == 0)
            {
                Console.WriteLine("Não há usuario cadastrado!");
                return;
            }

            foreach(var obj in user)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        private static String imprime()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Mostrar dados");
            Console.WriteLine("2 - Cadastrar Usuario");
            Console.WriteLine("3 - Adicionar saldo");
            Console.WriteLine("4 - Comprar produto");
            Console.WriteLine("5 - Excluir user");
            Console.WriteLine("6 - Limpar tela");
            Console.WriteLine("X - Sair");
            var escolha = Console.ReadLine();
            return escolha;
        }
    }
}

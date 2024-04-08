using System;

namespace PIM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização do seu programa
            InicializarPrograma();
        }

        static void InicializarPrograma()
        {
            // Implemente o código inicial do seu programa aqui
            Console.WriteLine("Bem-vindo ao seu programa PIM!");
            Console.WriteLine("Este é um sistema de reserva de equipamentos audiovisuais.");

            // Aqui você pode chamar outras funções ou métodos do seu programa
            // Exemplo:
            // RealizarReserva();
            // ListarEquipamentosDisponiveis();

            // Ou exibir o menu principal do programa
            ExibirMenuPrincipal();
        }

        static void ExibirMenuPrincipal()
        {
            // Implemente aqui a exibição do menu principal e a lógica para escolha das opções
            Console.WriteLine("\n=== Menu Principal ===");
            Console.WriteLine("1. Realizar Reserva");
            Console.WriteLine("2. Listar Equipamentos Disponíveis");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            // Aqui você pode adicionar a lógica para ler a opção escolhida pelo usuário
            // e chamar os métodos correspondentes

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    RealizarReserva();
                    break;
                case "2":
                    ListarEquipamentosDisponiveis();
                    break;
                case "3":
                    Console.WriteLine("Obrigado por usar o programa. Até mais!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }

            // Após realizar a ação correspondente, você pode exibir novamente o menu principal
            ExibirMenuPrincipal();
        }

        static void RealizarReserva()
        {
            // Implemente aqui a lógica para realizar uma reserva
            Console.WriteLine("\n== Realizar Reserva ==");

            // Aqui você pode solicitar as informações necessárias ao usuário
            // para realizar a reserva, como o nome do equipamento e as datas
            // de início e fim da reserva.

            // Após realizar a reserva, você pode atualizar os dados internos
            // do programa e exibir uma mensagem de confirmação.

            // Exemplo:
            // Console.WriteLine("Reserva realizada com sucesso!");
        }

        static void ListarEquipamentosDisponiveis()
        {
            // Implemente aqui a lógica para listar os equipamentos disponíveis
            Console.WriteLine("\n== Equipamentos Disponíveis ==");

            // Aqui você pode percorrer a lista de equipamentos e exibir os
            // que estão disponíveis para reserva.

            // Exemplo:
            // foreach (var equipamento in listaEquipamentos)
            // {
            //     if (equipamento.Disponivel)
            //     {
            //         Console.WriteLine($"Nome: {equipamento.Nome}, Tipo: {equipamento.Tipo}");
            //     }
            // }
        }
    }
}

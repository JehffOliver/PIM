using System;
using System.Collections.Generic;

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();
    static Usuario usuarioLogado = null;

    static List<Item> estoqueItens = new List<Item>(); // Lista de itens disponíveis para aluguel

    static void Main(string[] args)
    {
        // Inicialização do programa
        InicializarPrograma();
    }

    static void InicializarPrograma()
    {
        // Adiciona alguns usuários de exemplo
        usuarios.Add(new Usuario("usuario1@example.com", "senha123"));
        usuarios.Add(new Usuario("usuario2@example.com", "senha456"));

        // Adiciona alguns itens ao estoque
        estoqueItens.Add(new Item("DataShow", 5)); // 5 DataShows disponíveis
        estoqueItens.Add(new Item("Projetor", 3)); // 3 Projetores disponíveis
        estoqueItens.Add(new Item("Caixa de Som", 2)); // 2 Caixas de Som disponíveis

        Console.WriteLine("Bem-vindo ao sistema de reserva de equipamentos audiovisuais!");

        // Loop principal
        while (true)
        {
            if (usuarioLogado == null)
            {
                Console.WriteLine("\n=== Menu Inicial ===");
                Console.WriteLine("1. Entrar");
                Console.WriteLine("2. Criar nova conta");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AutenticarUsuario();
                        break;
                    case "2":
                        CriarNovaConta();
                        break;
                    case "3":
                        Console.WriteLine("Obrigado por usar o sistema. Até mais!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            }
            else
            {
                ExibirMenuPrincipal();
            }
        }
    }

    static void AutenticarUsuario()
    {
        Console.Write("\nDigite seu e-mail: ");
        string email = Console.ReadLine();
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine();

        Usuario usuario = usuarios.Find(u => u.Email == email && u.Senha == senha);
        if (usuario != null)
        {
            usuarioLogado = usuario;
            Console.WriteLine($"Bem-vindo de volta, {usuarioLogado.Email}!");
        }
        else
        {
            Console.WriteLine("E-mail ou senha incorretos. Por favor, tente novamente ou crie uma nova conta.");
        }
    }

    static void CriarNovaConta()
    {
        Console.Write("\nDigite um novo e-mail: ");
        string novoEmail = Console.ReadLine();
        Console.Write("Digite uma nova senha: ");
        string novaSenha = Console.ReadLine();

        usuarios.Add(new Usuario(novoEmail, novaSenha));
        Console.WriteLine("Nova conta criada com sucesso! Você pode entrar agora.");
    }

    static void ExibirMenuPrincipal()
    {
        Console.WriteLine("\n=== Menu Principal ===");
        Console.WriteLine("1. Realizar Reserva");
        Console.WriteLine("2. Listar Equipamentos Disponíveis");
        Console.WriteLine("3. Alugar Itens");
        Console.WriteLine("4. Visualizar Reservas");
        Console.WriteLine("5. Sair");
        Console.Write("Escolha uma opção: ");

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
                AlugarItens();
                break;
            case "4":
                usuarioLogado.VisualizarReservas();
                break;
            case "5":
                usuarioLogado = null;
                Console.WriteLine("Desconectado com sucesso.");
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                break;
        }
    }

    static void RealizarReserva()
    {
        Console.WriteLine("\n== Realizar Reserva ==");
        // Lógica para realizar reserva aqui
    }

    static void ListarEquipamentosDisponiveis()
    {
        Console.WriteLine("\n== Equipamentos Disponíveis ==");
        // Lógica para listar equipamentos disponíveis aqui
    }

    static void AlugarItens()
    {
        Console.WriteLine("\n== Alugar Itens ==");
        // Lógica para alugar itens aqui
    }
}
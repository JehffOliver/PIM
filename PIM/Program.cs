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

        // Adiciona os itens ao estoque com a quantidade máxima permitida (10 de cada)
        AdicionarItensAoEstoque();

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
        Console.WriteLine("4. Devolução de Itens");
        Console.WriteLine("5. Visualizar Reservas");
        Console.WriteLine("6. Sair");
        Console.Write("Escolha uma opção: ");

        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.WriteLine("Escolha o item desejado:");
                usuarioLogado.ListarEquipamentosDisponiveis(estoqueItens);
                Console.Write("Digite o número do item desejado: ");
                int indiceItem = int.Parse(Console.ReadLine()) - 1;
                Item itemSelecionado = estoqueItens[indiceItem];
                DateTime dataInicio = DateTime.Now;
                Console.WriteLine($"Item alugado, a data de entrega será dia: {dataInicio.AddDays(1).ToString("dd/MM/yyyy")}");
                usuarioLogado.RealizarReserva(itemSelecionado, dataInicio);
                break;
            case "2":
                usuarioLogado.ListarEquipamentosDisponiveis(estoqueItens);
                break;
            case "3":
                usuarioLogado.AlugarItens();
                break;
            case "4":
                usuarioLogado.DevolucaoItens();
                break;
            case "5":
                usuarioLogado.VisualizarReservas();
                break;
            case "6":
                usuarioLogado = null;
                Console.WriteLine("Desconectado com sucesso.");
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                break;
        }
    }

    static void AdicionarItensAoEstoque()
    {
        // Adiciona os itens ao estoque com a quantidade máxima permitida (10 de cada)
        estoqueItens.Add(new Item("DataShow", 10));
        estoqueItens.Add(new Item("Projetor", 10));
        estoqueItens.Add(new Item("Caixa de Som", 10));
        estoqueItens.Add(new Item("Notebook", 10));
        estoqueItens.Add(new Item("Televisor com DVD", 10));
        estoqueItens.Add(new Item("Telão", 10));
        estoqueItens.Add(new Item("Microfone sem Fio", 10));
        estoqueItens.Add(new Item("Kit de Conferência", 10));
        estoqueItens.Add(new Item("Gravador de Áudio", 10));
        estoqueItens.Add(new Item("Câmera de Vídeo", 10));
        estoqueItens.Add(new Item("Mesa de Som", 10));
        estoqueItens.Add(new Item("Tripé para Câmera", 10));
        estoqueItens.Add(new Item("Luz de Estúdio", 10));
        estoqueItens.Add(new Item("Chroma Key", 10));
        estoqueItens.Add(new Item("Cabo HDMI", 10));
        estoqueItens.Add(new Item("Adaptador VGA", 10));
        estoqueItens.Add(new Item("Microfone de Lapela", 10));
        estoqueItens.Add(new Item("Mesa de Corte", 10));
        estoqueItens.Add(new Item("Lente de Zoom", 10));
        estoqueItens.Add(new Item("Drone", 10));
    }

    // Métodos para as demais funcionalidades do sistema (RealizarReserva, ListarEquipamentosDisponiveis, AlugarItens, DevolucaoItens) aqui...
}
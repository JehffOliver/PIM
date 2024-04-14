using System;
using System.Collections.Generic;

namespace SistemaReservaEquipamentos
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static Usuario usuarioLogado = null;

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
            Console.WriteLine("3. Visualizar Reservas");
            Console.WriteLine("4. Sair");
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
                    VisualizarReservas();
                    break;
                case "4":
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
            // Implementar a lógica para realizar uma reserva
            Console.WriteLine("\n== Realizar Reserva ==");
            // ...
        }

        static void ListarEquipamentosDisponiveis()
        {
            // Implementar a lógica para listar equipamentos disponíveis
            Console.WriteLine("\n== Equipamentos Disponíveis ==");
            // ...
        }

        static void VisualizarReservas()
        {
            // Implementar a lógica para visualizar reservas do usuário logado
            Console.WriteLine("\n== Suas Reservas ==");
            // ...
        }
    }
}

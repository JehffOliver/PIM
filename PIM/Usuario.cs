using System;
using System.Collections.Generic;

class Usuario
{
    public string Email { get; }
    public string Senha { get; }
    public Item Item { get; set; }
    public List<Reserva> Reservas { get; private set; }

    public Usuario(string email, string senha)
    {
        Email = email;
        Senha = senha;
        Reservas = new List<Reserva>();
    }

    public void RealizarReserva(Item item, DateTime dataInicio)
    {
        if (item.QuantidadeDisponivel > 0)
        {
            DateTime dataFim = dataInicio.AddDays(1); // Calcula a data de fim como 1 dia após a data de início
            Reservas.Add(new Reserva(item, dataInicio, dataFim));
            item.AtualizarQuantidade(-1);
            Console.WriteLine("Reserva realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Não há unidades disponíveis desse item para reserva.");
        }
    }

    public void ListarEquipamentosDisponiveis(List<Item> estoque)
    {
        Console.WriteLine("\n=== Equipamentos Disponíveis ===");
        for (int i = 0; i < estoque.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {estoque[i].Nome} - Quantidade disponível: {estoque[i].QuantidadeDisponivel}");
        }
    }

    public void AlugarItens()
    {
        // Implementação do método para alugar itens
    }

    public void DevolucaoItens()
    {
        // Implementação do método para devolução de itens
    }

    public void VisualizarReservas()
    {
        Console.WriteLine("\n== Suas Reservas ==");
        foreach (var reserva in Reservas)
        {
            Console.WriteLine($"Item: {reserva.Item.Nome} | Data Início: {reserva.DataInicio} | Data Fim: {reserva.DataFim}");
        }
    }
}
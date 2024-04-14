using System;
using System.Collections.Generic;

class Usuario
{
    public string Email { get; set; }
    public string Senha { get; set; }
    public List<Reserva> Reservas { get; set; }

    public Usuario(string email, string senha)
    {
        Email = email;
        Senha = senha;
        Reservas = new List<Reserva>();
    }

    public void VisualizarReservas()
    {
        Console.WriteLine("\n== Suas Reservas ==");
        foreach (var reserva in Reservas)
        {
            Console.WriteLine($"Item: {reserva.Equipamento.Nome}, Data Início: {reserva.DataInicio}, Data Fim: {reserva.DataFim}");
        }
    }

    public void RealizarReserva(Equipamento equipamento, DateTime dataInicio, DateTime dataFim)
    {
        Reservas.Add(new Reserva(equipamento, dataInicio, dataFim));
    }
}
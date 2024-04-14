using System;
using System.Collections.Generic;

namespace SistemaReservaEquipamentos
{
    // Classe para representar um equipamento audiovisual
    class Equipamento
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public bool Disponivel { get; set; }

        public Equipamento(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
            Disponivel = true; // Equipamento é inicialmente disponível
        }
    }

    // Classe para representar uma reserva de equipamento
    class Reserva
    {
        public Equipamento Equipamento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Reserva(Equipamento equipamento, DateTime dataInicio, DateTime dataFim)
        {
            Equipamento = equipamento;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }

    // Classe para representar um usuário
    class Usuario
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}

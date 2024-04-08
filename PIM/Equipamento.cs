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

        // Construtor para inicializar um equipamento
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

        // Construtor para inicializar uma reserva
        public Reserva(Equipamento equipamento, DateTime dataInicio, DateTime dataFim)
        {
            Equipamento = equipamento;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }

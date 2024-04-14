using SistemaReservaEquipamentos;
using System;

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
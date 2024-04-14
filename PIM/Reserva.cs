using System;

class Reserva
{
    public Equipamento Equipamento { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public Item Item { get; set; }

    public Reserva()
    {
    }

    public Reserva(Item item, DateTime dataInicio, DateTime dataFim)
    {
        Item = item;
        DataInicio = dataInicio;
        DataFim = dataFim;
    }
}
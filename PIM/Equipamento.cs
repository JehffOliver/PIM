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

    public void Alugar()
    {
        Disponivel = false;
    }
}
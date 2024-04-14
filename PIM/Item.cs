class Item
{
    public string Nome { get; }
    public int QuantidadeDisponivel { get; set; }

    public Item(string nome, int quantidadeDisponivel)
    {
        Nome = nome;
        QuantidadeDisponivel = quantidadeDisponivel;
    }

    public void AtualizarQuantidade(int quantidade)
    {
        QuantidadeDisponivel += quantidade;
    }
}
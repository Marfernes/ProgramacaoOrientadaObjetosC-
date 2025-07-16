
public class Musica
{
    public string nome { get; set; }
    public string artista { get; set; }
    public int duracao { get; set; }
    private bool disponivel { get; set; }

    public void EscrevaDisponivel(bool value)
    {
        disponivel = value;
    }

    public bool LeiaDisponivel()
    {
        return disponivel;
    }
    public void ExibirFichaTecnica()
    {

        Console.WriteLine($"{nome}");
        Console.WriteLine($"{artista}");
        Console.WriteLine($"{duracao}");
        if (disponivel)
        {
            Console.WriteLine("Música disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}

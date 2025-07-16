
public class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>  $"A música {Nome} pertence a banda {Artista}";
  
    public void ExibirFichaTecnica()
    {

        Console.WriteLine($"{Nome}");
        Console.WriteLine($"{Artista}");
        Console.WriteLine($"{Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Música disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}


public class Carro
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int AnoCarro { get; set; }
    public string DescricaoDetalhada { get => $"fabricante do carro é {Fabricante}, modelo {Modelo} com ano de fabricação {AnoCarro}"; }

    public void ExibirAnoDoCarro()
    {
        
        if (AnoCarro < 1960 || AnoCarro > 2023) 
        {
            Console.WriteLine($"Ano inválido!");
        }
        
    }
}



Musica musica = new Musica();

musica.Nome = "Nome dele é Jesus!";
musica.Artista = "Marcelo Nunes";
musica.Duracao = 12;
musica.Disponivel = true;

Console.WriteLine(musica.Disponivel);
Console.WriteLine(musica.DescricaoResumida);


Musica musica2 = new Musica();
musica2.Nome = "Nome dele é Jesus 2!";
musica2.Artista = "Marcelo Nunes";
musica2.Duracao = 12;
musica.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
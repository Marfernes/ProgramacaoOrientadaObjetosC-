
Musica musica = new Musica();

musica.nome = "Nome dele é Jesus!";
musica.artista = "Marcelo Nunes";
musica.duracao = 12;
musica.EscrevaDisponivel(true);
Console.WriteLine(musica.LeiaDisponivel());

Musica musica2 = new Musica();
musica2.nome = "Nome dele é Jesus 2!";
musica2.artista = "Marcelo Nunes";
musica2.duracao = 12;
musica.EscrevaDisponivel(false);
Console.WriteLine(musica2.LeiaDisponivel());

musica.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
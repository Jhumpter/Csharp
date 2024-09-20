Album album = new Album();
album.Nome = "Metallica";

Musica musica1 = new Musica();
musica1.Nome = "Sad But True";
musica1.Duracao = 524;

Musica musica2 = new Musica();
musica2.Nome = "Enter Sandman";
musica2.Duracao = 330;

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);

album.ExibirDiscografia();
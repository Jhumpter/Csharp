Album album = new Album("Black Album");

Banda metallica = new Banda("Metallica");

Musica musica1 = new Musica(metallica, "Sad But True")
{ // É possível dar um valor a um atributo da seguinte forma, ao invés de declarar cada atributo
    Duracao = 524,
    Disponivel = true,
};

Musica musica2 = new Musica(metallica, "Enter Sandman")
{
    Duracao = 330,
    Disponivel = false,
};

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);
metallica.AdicionarAlbum(album);

musica1.FichaTecnica();
musica2.FichaTecnica();
album.ExibirMusicasDaBanda();
metallica.ExibirDiscografia();
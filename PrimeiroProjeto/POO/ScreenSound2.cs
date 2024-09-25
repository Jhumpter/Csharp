Album album = new Album("Black Album");

Band metallica = new Band("Metallica");

Song music1 = new Song(metallica, "Sad But True")
{ // É possível dar um valor a um atributo da seguinte forma, ao invés de declarar cada atributo
    Duration = 524,
    Available = true,
};

Song music2 = new Song(metallica, "Enter Sandman")
{
    Duration = 330,
    Available = false,
};

Episode ep1 = new Episode("Village Batle", 1, 150);
ep1.AddGuest("Johnny");
ep1.AddGuest("Guri");
Episode ep2 = new Episode("Fight", 2, 198);
ep2.AddGuest("Pablo Marçal");
ep2.AddGuest("Datena");
Podcast podpah = new Podcast("Podpah", "Igão e Mítico");
podpah.AddEpisode(ep1);
podpah.AddEpisode(ep2);
podpah.ShowDetails();

/*album.AddSong(music1);
album.AddSong(music2);
metallica.AddAlbum(album);

music1.Technicalsheet();
music2.Technicalsheet();
album.ShowSongsFromBand();
metallica.ShowDiscography();*/


Episodio episodio1 = new Episodio(100, 99, "Nove nove");
episodio1.AdicionarConvidados("Joel");
episodio1.AdicionarConvidados("Lu");
episodio1.AdicionarConvidados("Alan");

Episodio episodio2 = new Episodio(100, 33, "Trinta e três");
episodio2.AdicionarConvidados("Gleryston");
episodio2.AdicionarConvidados("João");
episodio2.AdicionarConvidados("Yuri");

Episodio episodio3 = new Episodio(100, 88, "Oito oito");
episodio3.AdicionarConvidados("Raimundo");
episodio3.AdicionarConvidados("Leonardo");
episodio3.AdicionarConvidados("Alan");

Podcast podcast = new Podcast("Joel", "Podcast do Joel");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.AdicionarEpisodio(episodio3);
podcast.ExibirDetalhes();
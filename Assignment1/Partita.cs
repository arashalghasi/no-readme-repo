class Partita
{
	private Giocatore g1; // giocatore 1
	private Giocatore g2; // giocatore 2

	public Partita(Giocatore g1, Giocatore g2) // costruttore della classe Partita che prende in ingresso due giocatori
	{
		this.g1 = g1; // assegno il valore passato al costruttore alla variabile g1 della classe Partita
		this.g2 = g2; // assegno il valore passato al costruttore alla variabile g2 della classe Partita
	}

	public void Gioca() // metodo per giocare la partita
	{
		Console.WriteLine("Giocatore 1: " + this.g1.GetNome()); // stampo il nome del giocatore 1
		Console.WriteLine("Giocatore 2: " + this.g2.GetNome()); // stampo il nome del giocatore 2
		Console.WriteLine("Giocatore 1 sceglie:"); // stampo il nome del giocatore 1
		string scelta1 = Console.ReadLine(); // leggo la scelta del giocatore 1
		Console.WriteLine("Giocatore 2 sceglie:"); // stampo il nome del giocatore 2
		string scelta2 = Console.ReadLine(); // leggo la scelta del giocatore 2
		if (scelta1 == scelta2) // se le scelte sono uguali
		{
			Console.WriteLine("Pareggio!"); // stampo pareggio
		}
		else if (scelta1 == "sasso" && scelta2 == "forbice" || scelta1 == "carta" && scelta2 == "sasso" || scelta1 == "forbice" && scelta2 == "carta") // se il giocatore 1 vince
		{
			Console.WriteLine("Vince il giocatore 1!"); // stampo vince il giocatore 1
			this.g1.SetPunteggio(this.g1.GetPunteggio() + 1); // assegno un punto al giocatore 1
		}
		else // se il giocatore 2 vince
		{
			Console.WriteLine("Vince il giocatore 2!");
			this.g2.SetPunteggio(this.g2.GetPunteggio() + 1); // assegno un punto al giocatore 2
		}
	}
	public void StampaPunteggio() // metodo per stampare il punteggio dei giocatori
	{
		Console.WriteLine("Punteggio giocatore 1: " + this.g1.GetPunteggio()); // stampo il punteggio del giocatore 1
		Console.WriteLine("Punteggio giocatore 2: " + this.g2.GetPunteggio()); // stampo il punteggio del giocatore 2
	}
}

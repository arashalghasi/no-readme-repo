// Program.cs - sasso carta forbice tra due giocatori con classe Giocatore e classe Partita modifica

class Giocatore
{
	private string nome; // nome del giocatore
	private int punteggio; // punteggio del giocatore

	public Giocatore(string nome) // costruttore della classe Giocatore che prende in ingresso il nome del giocatore
	{
		this.nome = nome; // assegno il valore passato al costruttore alla variabile nome della classe Giocatore
		this.punteggio = 0; // inizializzo il punteggio del giocatore a 0
	}

	public void SetPunteggio(int punteggio) // metodo per assegnare un punteggio al giocatore
	{
		this.punteggio = punteggio; // assegno il valore passato al metodo alla variabile punteggio della classe Giocatore
	}

	public int GetPunteggio() // metodo per ottenere il punteggio del giocatore
	{
		return this.punteggio; // ritorno il punteggio del giocatore
	}

	public string GetNome() // metodo per ottenere il nome del giocatore
	{
		return this.nome; // ritorno il nome del giocatore
	}
}

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

class Program
{
	static void Main(string[] args)
	{
		Giocatore g1 = new Giocatore("Mario"); // creo un oggetto di tipo Giocatore con nome Mario
		Giocatore g2 = new Giocatore("Computer"); // creo un oggetto di tipo Giocatore con nome Computer
		Partita p1 = new Partita(g1, g2); // creo un oggetto di tipo Partita con i giocatori g1 e g2
		p1.Gioca(); // gioco la partita
		p1.StampaPunteggio(); // stampo il punteggio dei giocatori
	}
}

// Output:
// Giocatore 1: Mario
// Giocatore 2: Computer
// Giocatore 1 sceglie:
// sasso
// Giocatore 2 sceglie:
// carta
// Vince il giocatore 2!
// Punteggio giocatore 1: 0
// Punteggio giocatore 2: 1

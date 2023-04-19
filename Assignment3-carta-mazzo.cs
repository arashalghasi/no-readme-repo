// Program.cs - semplice gioco di carte con classe Carta e classe Mazzo

class Carta
{
	private string seme; // seme della carta
	private int valore; // valore della carta

	public Carta(string seme, int valore) // costruttore della classe Carta che prende in ingresso il seme e il valore della carta
	{
		this.seme = seme; // assegno il valore passato al costruttore alla variabile seme della classe Carta
		this.valore = valore; // assegno il valore passato al costruttore alla variabile valore della classe Carta
	}

	public string GetSeme() // metodo per ottenere il seme della carta
	{
		return this.seme; // ritorno il seme della carta
	}

	public int GetValore() // metodo per ottenere il valore della carta
	{
		return this.valore; // ritorno il valore della carta
	}
}

class Mazzo
{
	private Carta[] carte; // array di carte

	public Mazzo() // costruttore della classe Mazzo
	{
		this.carte = new Carta[52]; // inizializzo l'array di carte con 52 carte
		string[] semi = { "cuori", "quadri", "fiori", "picche" }; // creo un array di stringhe con i semi delle carte
		int indice = 0; // indice per l'array di carte
		for (int i = 0; i < semi.Length; i++) // ciclo per i semi
		{
			for (int j = 1; j <= 13; j++) // ciclo per i valori
			{
				this.carte[indice] = new Carta(semi[i], j); // creo una carta con seme semi[i] e valore j e la assegno all'array di carte
				indice++; // incremento l'indice
			}
		}
	}

	public void Mescola() // metodo per mescolare le carte
	{
		Random rnd = new Random(); // creo un oggetto di tipo Random
		for (int i = 0; i < this.carte.Length; i++) // ciclo per le carte
		{
			int indiceCasuale = rnd.Next(0, this.carte.Length); // creo un indice casuale
			Carta cartaCasuale = this.carte[indiceCasuale]; // creo una carta casuale
			this.carte[indiceCasuale] = this.carte[i]; // assegno alla carta casuale la carta i
			this.carte[i] = cartaCasuale; // assegno alla carta i la carta casuale
		}
	}

	public Carta Pesca() // metodo per pescare una carta
	{
		Carta carta = this.carte[0]; // creo una carta e la assegno alla prima carta dell'array di carte
		Carta[] carteNuove = new Carta[this.carte.Length - 1]; // creo un array di carte con una carta in meno
		for (int i = 1; i < this.carte.Length; i++) // ciclo per le carte
		{
			carteNuove[i - 1] = this.carte [i]; // assegno alla carta i - 1 la carta i dell'array di carte originale (in questo modo la prima carta viene saltata)
		}
		this.carte = carteNuove; // assegno all'array di carte originale l'array di carte con una carta in meno
		return carta; // ritorno la carta
	}
}

class Program
{
	static void Main(string[] args)
	{
		Mazzo mazzo = new Mazzo(); // creo un oggetto di tipo Mazzo
		mazzo.Mescola(); // mescolo le carte
		Carta carta = mazzo.Pesca(); // pesco una carta
		Console.WriteLine(carta.GetSeme() + " " + carta.GetValore()); // stampo il seme e il valore della carta
	}
}

// Output:
// cuori 10

// Program.cs - semplice gioco di poker con 5 dadi e classe Dado

class Dado
{
	private int faccia; // faccia del dado

	public Dado() // costruttore della classe Dado
	{
		this.faccia = 1; // assegno 1 alla faccia del dado
	}

	public void Lancia() // metodo per lanciare il dado
	{
		Random rnd = new Random(); // creo un oggetto di tipo Random
		this.faccia = rnd.Next(1, 7); // assegno un valore casuale alla faccia del dado
	}

	public int GetFaccia() // metodo per ottenere la faccia del dado
	{
		return this.faccia; // ritorno la faccia del dado
	}
}

class Program
{
	static void Main(string[] args)
	{
		Dado[] dadi = new Dado[5]; // creo un array di 5 dadi
		for (int i = 0; i < dadi.Length; i++) // ciclo per i dadi
		{
			dadi[i] = new Dado(); // creo un nuovo dado e lo assegno all'array di dadi
		}
		for (int i = 0; i < dadi.Length; i++) // ciclo per i dadi
		{
			dadi[i].Lancia(); // lancio il dado
			Console.WriteLine(dadi[i].GetFaccia()); // stampo la faccia del dado
		}
	}
}

// Output:
// 3
// 5
// 2
// 6
// 1

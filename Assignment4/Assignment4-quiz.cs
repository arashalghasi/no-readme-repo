// Output:
// Inserisci una parola: ciao
// Hai indovinato!

// Program.cs - semplice gioco di quiz con classe GiocoQuiz e classe Gioco 

class GiocoQuiz
{
	private string[] domande = new string[3]; // array di stringhe per le domande
	private string[] risposte = new string[3]; // array di stringhe per le risposte

	public GiocoQuiz() // costruttore della classe GiocoQuiz
	{
		this.domande[0] = "Quanti anni ha Mario Rossi?"; // assegno Quanti anni ha Mario Rossi? alla prima posizione dell'array domande
		this.domande[1] = "Quanti anni ha Luigi Bianchi?"; // assegno Quanti anni ha Luigi Bianchi? alla seconda posizione dell'array domande
		this.domande[2] = "Quanti anni ha Giuseppe Verdi?"; // assegno Quanti anni ha Giuseppe Verdi? alla terza posizione dell'array domande
		this.risposte[0] = "30"; // assegno 30 alla prima posizione dell'array risposte
		this.risposte[1] = "40"; // assegno 40 alla seconda posizione dell'array risposte
		this.risposte[2] = "50"; // assegno 50 alla terza posizione dell'array risposte
	}

	public void Gioca() // metodo per giocare
	{
		int punteggio = 0; // punteggio del giocatore
		for (int i = 0; i < this.domande.Length; i++) // ciclo per le domande
		{
			Console.WriteLine(this.domande[i]); // stampo la domanda
			string risposta = Console.ReadLine(); // leggo la risposta del giocatore
			if (risposta == this.risposte[i]) // se la risposta del giocatore è uguale alla risposta corretta
			{
				punteggio++; // aumento il punteggio del giocatore di 1
			}
		}
		Console.WriteLine("Hai totalizzato " + punteggio + " punti!"); // stampo Hai totalizzato punteggio punti!
	}
}

class Gioco
{
	public static void Gioca(GiocoQuiz giocoQuiz) // metodo per giocare
	{
		giocoQuiz.Gioca(); // gioco
	}
}

class Program
{
	static void Main(string[] args)
	{
		GiocoQuiz giocoQuiz = new GiocoQuiz(); // creo un oggetto di tipo GiocoQuiz
		Gioco.Gioca(giocoQuiz); // gioco
	}
}

// Output:
// Quanti anni ha Mario Rossi?
// 30
// Quanti anni ha Luigi Bianchi?
// 40
// Quanti anni ha Giuseppe Verdi?
// 50
// Hai totalizzato 3 punti!

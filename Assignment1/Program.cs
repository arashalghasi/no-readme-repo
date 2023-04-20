// Program.cs - MODIFICATO sasso carta forbice tra due giocatori con classe Giocatore e classe Partita 


class Program
{
	static void Main(string[] args)
	{
		Giocatore g1 = new Giocatore("Mario"); // creo un oggetto di tipo Giocatore con nome Mario
		Giocatore g2 = new Giocatore("Computer"); // creo un oggetto di tipo Giocatore con nome Computer
		Partita p1 = new Partita(g1, g2); // creo un oggetto di tipo Partita con i giocatori g1 e g2
		p1.Gioca(); // gioco la partita
		p1.StampaPunteggio(); // stampo il punteggio dei giocatori
		//modifica
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
// Punteggio giocatore
// Punteggio giocatore 2: 1

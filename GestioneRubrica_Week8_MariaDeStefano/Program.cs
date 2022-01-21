using GestioneRubrica_Week8_MariaDeStefano_Core.BusinessLayer;
using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using GestioneRubrica_Week8_MariaDeStefano_RepMock;

IBusinessLayer bl =new MainBusinessLayer(new RepositoryContattiMock(), new RepositoryIndirizziMock());

bool continua = true;

while(continua)
{
    int choose = SchermoMenu();
    continua = AnalizzaScelta(choose);
}

int SchermoMenu()
{
    Console.WriteLine("*****Menu*****");
    Console.WriteLine("\n Funzionalità Contatti");
    Console.WriteLine("\n 1. Aggiungi un nuovo contatto");
    Console.WriteLine("\n 2. Visualizza tutti i contatti");    
    Console.WriteLine("\n 3. Elimina un contatto");

    Console.WriteLine("\n Funzionalità Indirizzi");
    Console.WriteLine("\n 4. Aggiungere un nuovo indirizzo");
    Console.WriteLine("\n 0. Exit");

    int choose;
    Console.WriteLine("Cosa vuoi fare: inserisci la tua scelta");
    while (!(int.TryParse(Console.ReadLine(), out choose) && choose >= 0 && choose <= 4))
    {
        Console.WriteLine("Scelta Sbaglitata. Inserisci una nuova scelta: ");
    }
    return choose;
}

bool AnalizzaScelta(int choose)
{
    switch (choose)
    {
        case 1:
            AggiungiNuovoContatto();
            break;
        case 2:
            VisualizzaTuttiIContatti();
            break;
        case 3:
            EliminaContatto();
            break;
        case 4:
            AggiungiIndirizzo();
            break;
        case 0:
            return false;

    }
    return true;
}

void AggiungiIndirizzo()
{
    Console.WriteLine("Inserisci i dati del nuovo indirizzo: ");
    Console.WriteLine("Via: ");
    string via=Console.ReadLine();
    Console.WriteLine("Città: ");
    string città=Console.ReadLine();
    Console.WriteLine("CAP: ");
    string cap=Console.ReadLine();
    Console.WriteLine("Provincia: ");
    string provincia=Console.ReadLine();
    Console.WriteLine("Nazione: ");
    string nazione=Console.ReadLine();
    Console.WriteLine("Quale Tipologia di indirizzo è: "); //da fare;
    
    Console.WriteLine("Visulizza Elenco Contatti: ");
    VisualizzaTuttiIContatti();
    Console.WriteLine("\n Id del Contatto a cui vuoi associare l'indirizzo: ");
    int indirizzoId=int.Parse(Console.ReadLine());

    Indirizzo nuovoIndirizzo = new Indirizzo();
    nuovoIndirizzo.Via = via;
    nuovoIndirizzo.Città = città;
    nuovoIndirizzo.CAP = cap;
    nuovoIndirizzo.Provincia = provincia;
    nuovoIndirizzo.Nazione = nazione;
    nuovoIndirizzo.IDContatto = indirizzoId;
    

    Esito esito= bl.AddNuovoIndirizzo(nuovoIndirizzo);
    Console.WriteLine(esito.Messaggio);

        
}

void EliminaContatto()
{
    Console.WriteLine("Elenco Contatti: ");
    VisualizzaTuttiIContatti();
   
}



void VisualizzaTuttiIContatti()
{
   List<Contatto> contatti= new List<Contatto>();
    if (contatti.Count == 0)
    {
        Console.WriteLine("Nessun Contatto Presente");
            }
    else
    {
        foreach (var item in contatti)
        {
            Console.WriteLine(item);
        }
    }
}

void AggiungiNuovoContatto()
{
    Console.WriteLine("Inserisci i dati del nuovo contatto: ");
    Console.WriteLine("Nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Cognome: ");
    string cognome = Console.ReadLine();

    Contatto nuovoContatto = new Contatto();
    nuovoContatto.Name = nome;
    nuovoContatto.Surname = cognome;

    Esito esito = bl.AddNuovoContatto(nuovoContatto);
    Console.WriteLine(esito.Messaggio);
}
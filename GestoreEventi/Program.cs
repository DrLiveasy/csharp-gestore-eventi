// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using System;
//------------------MILESTONE 2------------------
/*
Console.WriteLine("Hello, World!");

Console.Write("Inserisci il nome dell'evento: ");
string nomeEvento = Console.ReadLine();
Console.Write("Inserisci data dell'evento (gg/mm/yyyy): ");
string dataStringa = Console.ReadLine();
Console.Write("Inserisci il numero di posti totali: ");
int capienzaMax = int.Parse(Console.ReadLine());

Evento eventoInput = new Evento(nomeEvento, dataStringa, capienzaMax);

Console.Write("Qanti posti desideri prenotare? ");
int postiDaPrenotare = int.Parse(Console.ReadLine());

eventoInput.PrenotaPosti(postiDaPrenotare);

Console.WriteLine("Numero di posto prenotati = "+eventoInput.GetPostiPrenotati1());
Console.WriteLine("numero di posti disponibili = " + (eventoInput.GetCapienzaMax1() - eventoInput.GetPostiPrenotati1()));

while (true) 
{
    Console.WriteLine("vuoi disdire posti? (si/no)?");
    string risposta = Console.ReadLine();
    if (risposta == "si")
    {
        Console.WriteLine("Indica il numero di posti da disdire: ");
        int postiDaDisdire = int.Parse(Console.ReadLine());
        eventoInput.DisdiciPosti(postiDaDisdire);
        Console.WriteLine("Numero di posto prenotati = " + eventoInput.GetPostiPrenotati1());
        Console.WriteLine("numero di posti disponibili = " + (eventoInput.GetCapienzaMax1() - eventoInput.GetPostiPrenotati1()));
    }else if (risposta == "no")
    { 
        Console.WriteLine("Ok va bene!");

        Console.WriteLine("Numero di posto prenotati = " + eventoInput.GetPostiPrenotati1());
        Console.WriteLine("numero di posti disponibili = " + (eventoInput.GetCapienzaMax1() - eventoInput.GetPostiPrenotati1()));
        Console.WriteLine(eventoInput.ToString());
        break;
    }
    else
    {
        Console.WriteLine("Perfavore rispondere solo con (si o no)");
    }
}*/

//------------------MILESTONE 4------------------

try
{
    Console.Write("Inserisci il nome del tuo programma Eventi: ");
    string InputNomeProgramma = Console.ReadLine();
    Console.Write("Indica il numero di eventi da inserire: ");
    int numeroDiEventiDaInserire = int.Parse(Console.ReadLine());

    ProgrammaEventi ProgrammaUtente = new ProgrammaEventi(InputNomeProgramma);

    for (int i = 0; i < numeroDiEventiDaInserire;i++)
    {
        Console.WriteLine("\n");
        Console.Write("Inserisci il nome dell'evento: ");
        string nomeEvento = Console.ReadLine();
        Console.Write("Inserisci data dell'evento (gg/mm/yyyy): ");
        string dataStringa = Console.ReadLine();
        Console.Write("Inserisci il numero di posti totali: ");
        int capienzaMax = int.Parse(Console.ReadLine());
       
        Evento eventoInput = new Evento(nomeEvento, dataStringa, capienzaMax);

        ProgrammaUtente.AggiungiEvento(eventoInput);

    }

    Console.WriteLine("il numero di eventi nel programma è: "+ProgrammaUtente.EventiPresenti());

    Console.WriteLine("Ecco il tuo programma eventi: ");

    Console.WriteLine(ProgrammaUtente.ToString());

    Console.Write("inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");
    string dataStringa2 = Console.ReadLine();

    DateTime dataInserita = DateTime.ParseExact(dataStringa2, "dd/MM/yyyy", null);

    ProgrammaUtente.StampaListaInConsole1(ProgrammaUtente.RistetuisciListaEventiConStessaData(dataInserita));



}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

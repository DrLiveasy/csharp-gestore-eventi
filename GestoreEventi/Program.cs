// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using System;

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
}
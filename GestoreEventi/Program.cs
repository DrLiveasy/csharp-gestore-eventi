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

Console.WriteLine();
Evento eventoInput = new Evento(nomeEvento, dataStringa, capienzaMax);

Console.Write("Qanti posti desideri prenotare? ");
int postiDaPrenotare = int.Parse(Console.ReadLine());

eventoInput.PrenotaPosti(postiDaPrenotare);

Console.WriteLine("Numero di posto prenotati : "+eventoInput.GetPostiPrenotati1());
Console.WriteLine("numero di posti disponibili = " + (eventoInput.GetPostiPrenotati1() - eventoInput.GetCapienzaMax1()));
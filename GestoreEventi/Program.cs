// See https://aka.ms/new-console-template for more information
using GestoreEventi;

Console.WriteLine("Hello, World!");

Console.Write("Inserisci il nome dell'evento: ");
string nomeEvento = Console.ReadLine();
Console.Write("Inserisci data dell'evento (gg/mm/yyyy): ");
string dataStringa = Console.ReadLine();
Console.Write("Inserisci il numero di posti totali: ");
int capienzaMax = int.Parse(Console.ReadLine());

Evento EventoInput = new Evento(nomeEvento, dataStringa, capienzaMax);


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        #region Proprietà
        private string Titolo;
        private List<Evento> eventi;
        #endregion

        #region Costruttori
        public ProgrammaEventi(string titolo)
        {
            SetTitolo1(titolo);
            this.eventi = new List<Evento>();
        }
        #endregion

        #region Getters-Setters
        public string GetTitolo1()
        {
            return this.Titolo;
        }

        public void SetTitolo1(string value)
        {
            if (value == "")
            {
                throw new Exception("Il titolo non può essere vuoto!");
            }
            else
            {
                this.Titolo = value;
            }
        }
        #endregion

        #region Metodi
        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }
        public List<Evento> RistetuisciListaEventiConStessaData(DateTime data)
        {
            List<Evento> EventiNellaStessaData = new List<Evento>();

            foreach(Evento evento in eventi)
            {
                DateTime dataEvento = evento.GetData1();
                if ( dataEvento == data)
                {
                    EventiNellaStessaData.Add(evento);
                }
            }

            return EventiNellaStessaData;
        }
        public static void StampaListaInConsole(List<Evento> listaEventi)
        {
            foreach (Evento evento in listaEventi)
            {
                Console.WriteLine(evento.ToString());
            }
        }

        public int EventiPresenti()
        {
            int contaEventi = this.eventi.Count;

            return contaEventi;
        }
        public void SvuotaListaEventi()
        {
            this.eventi.Clear();
        }
        public override string ToString()
        {
            string str = "";

            foreach(Evento evento in this.eventi)
            {
                str += "\t" + evento.ToString() + "\n";
            }

            return this.Titolo +"\n"+ str;
        }
        public void StampaListaInConsole1(List<Evento> listaEventi)
        {
            foreach (Evento evento in listaEventi)
            {
                Console.WriteLine(evento.ToString());
            }
        }
        #endregion


    }
}
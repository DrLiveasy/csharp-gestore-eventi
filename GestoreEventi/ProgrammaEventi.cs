using System;
using System.Collections.Generic;
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

        #endregion


    }
}

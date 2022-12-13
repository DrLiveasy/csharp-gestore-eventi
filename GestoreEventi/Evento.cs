using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        #region PROPRIETA E STATO
        //Proprietà
        private string Titolo;
        private DateTime Data;
        //Stato
        private int CapienzaMax;
        private int PostiPrenotati;
        
        #endregion

        #region Costruttori
        public Evento(string titolo, string data, int capienzaMax)
        {
            SetTitolo1(titolo);
            SetData1(data);
            SetCapienzaMax1(capienzaMax);

            this.PostiPrenotati = 0;
        }

        #endregion

        #region Getters-Seters
        public string GetTitolo1()
        {
            return Titolo;
        }
        public void SetTitolo1(string value)
        {
            if (value == "")
            {
                throw new Exception("Il Titolo non può essere vuoto!");
            }
            else
            {
                this.Titolo = value;
            }
        }
        public DateTime GetData1()
        {
            return this.Data;
        }
        public void SetData1(string value)
        {
            DateTime dataOraAttuale = DateTime.Now;

            DateTime dataInserita = DateTime.ParseExact(value, "dd/MM/yyyy", null);

            if (value == "")
            {
                throw new Exception("la data non può essere vuota!");
            }
            else if (dataOraAttuale > dataInserita)
            {
                throw new Exception("non puoi inserire una data passata!");
            }
            else
            {
                this.Data = dataInserita;
            }
        }
        public int GetCapienzaMax1()
        {
            return CapienzaMax;
        }

        public void SetCapienzaMax1(int value)
        {
            if ( value < 0)
            {
                throw new Exception("la capienza massima non può essere un numero negativo !");
            }
            else
            {
                this.CapienzaMax = value;
            }
        }

        public int GetPostiPrenotati1()
        {
            return PostiPrenotati;
        }


        #endregion

        #region Metodi Public

        public void PrenotaPosti(int value)
        {
            DateTime dataOraAttuale = DateTime.Now;
            if (this.Data < dataOraAttuale)
            {
                throw new Exception("L'evento e già passato non si può prenotare posti!");
            }else if (this.CapienzaMax == this.PostiPrenotati || this.CapienzaMax < value)
            {
                throw new Exception("mi dispiace il numero di posti richiesti non è disponibile !");
            }
            else
            {
                this.PostiPrenotati += value;
            }
        }
        public void DisdiciPosti(int value)
        {
            DateTime dataOraAttuale = DateTime.Now;
            if (this.Data < dataOraAttuale)
            {
                throw new Exception("Evento già passato , non si può fare questa operazion!");
            }
            else if (this.PostiPrenotati < value)
            {
                throw new Exception("non ci sono posti sufficienti da disdire!");
            }
            else
            {
                this.PostiPrenotati -= value;
            }
        }
        public override string ToString()
        {
            return $"Data Evento: {this.Data}\t Titolo Evento: {this.Titolo}";
        }
        #endregion


    }

}


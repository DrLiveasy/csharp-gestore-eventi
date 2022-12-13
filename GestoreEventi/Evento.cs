﻿using System;
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
        private string Data;
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
        public string GetData1()
        {
            return Data;
        }
        public void SetData1(string value)
        {
            DateTime dataOraAttuale = DateTime.Now;
            DateTime data = DateTime.Parse(value);
            if (value == "")
            {
                throw new Exception("la data non può essere vuota!");
            }
            else if (dataOraAttuale > data)
            {
                throw new Exception("non puoi inserire una data passata!");
            }
            else
            {
                this.Data = value;
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













    }

}


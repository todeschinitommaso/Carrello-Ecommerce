﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    public class prodotto
    {
        private string _id, _nome, _produttore, _descrizione;
        private float _prezzo;

        public prodotto(string id, string nome, string produttore, string descrizione, float prezzo)
        {
            Id = id;
            Nome = nome;
            Produttore = produttore;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Produttore
        {
            get { return _produttore; }
            set { _produttore = value; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public float Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        public void setPrezzo(float prezzo)
        {
            this._prezzo = prezzo;
        }
    }
}

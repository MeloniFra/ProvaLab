using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBiblioteca
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private int _oraApertura;
        private int _oraChiusura;
        private List<Libro> _libri;

        public Biblioteca(string nome, string indirizzo, int oraApertura, int oraChiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OraApertura = oraApertura;
            OraChiusura = oraChiusura;
            _libri = new List<Libro>();
        }

        public Biblioteca(string nome, string indirizzo, int oraApertura, int oraChiusura, List<Libro> libri) : this(nome, indirizzo, oraApertura, oraChiusura)
        {
            Libri = libri;
        }

        public string Nome
        {
            get => default;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome non valido");
                }
                _nome = value;
            }
        }

        public string Indirizzo
        {
            get => default;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Indirizzo non valido");
                }
                _indirizzo = value;
            }
        }

        public int OraApertura
        {
            get => default;
            set
            {
                if (value < 0 | value > 23)
                {
                    throw new Exception("Ora di Apertura non valida");
                }
                _oraApertura = value;
            }
        }

        public int OraChiusura
        {
            get => default;
            set
            {
                if (value < 0 | value > 23)
                {
                    throw new Exception("Ora di Chiusura non valida");
                }
                _oraChiusura = value;
            }
        }

        public List<Libro> Libri
        {
            get; set;
        }

        public void AggiungiLibro(Libro libro)
        {
            _libri.Add(libro);
        }

        public List<Libro> GetLibriStessoTitolo(string titolo)
        {
            List<Libro> libriStessoTitolo = new List<Libro>();
            foreach (Libro l in _libri)
            {
                if (titolo.ToLower() == l.Titolo.ToLower())
                {
                    libriStessoTitolo.Add(l);
                }
            }
            return libriStessoTitolo;
        }

        public List<Libro> GetLibriStessoAutore(string autore)
        {
            List<Libro> libriStessoAutore = new List<Libro>();
            foreach (Libro l in _libri)
            {
                if (autore.ToLower() == l.Autore.ToLower())
                {
                    libriStessoAutore.Add(l);
                }
            }
            return libriStessoAutore;
        }

        public int GetNLibri()
        {
            return _libri.Count;
        }
    }
}

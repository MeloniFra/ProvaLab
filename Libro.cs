using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBiblioteca
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private int _annoDiPubblicazione;
        private string _editore;
        private int _nPagine;

        public Libro(string autore, string titolo, int annoDiPubblicazione, string editore, int nPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoDiPubblicazione = annoDiPubblicazione;
            Editore = editore;
            NPagine = nPagine;
        }

        public string Autore
        {
            get => default;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Inserire un Autore valido");
                }
                _autore = value;
            }
        }

        public string Titolo
        {
            get => default;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Inserire un Titolo valido");
                }
                _titolo = value;
            }
        }

        public int AnnoDiPubblicazione
        {
            get => default;
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new Exception("Inserire un Anno di pubblicazione valido");
                }
                _annoDiPubblicazione = value;
            }
        }

        public string Editore
        {
            get => default;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Inserire un Editore valido");
                }
                _editore = value;
            }
        }

        public int NPagine
        {
            get => default;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Inserire almeno 1 pagina");
                }
                _nPagine = value;
            }
        }

        public string ReadingTime()
        {
            if (NPagine <= 100)
            {
                return "1 ora";
            }
            else if (NPagine <= 200)
            {
                return "2 ore";
            }
            else
            {
                return "2 o più ore";
            }
        }

        public override string ToString()
        {
            return $"Autore: {Autore} Titolo: {Titolo} Anno di pubblicazione: {AnnoDiPubblicazione} Editore: {Editore} N°Pagine: {NPagine} Tempo di lettura: {ReadingTime()}";
        }
    }
}

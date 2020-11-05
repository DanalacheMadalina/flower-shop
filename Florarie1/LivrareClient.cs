using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florarie1
{
  public  class LivrareClient:IComparable,ICloneable
    {
        private int codLivrare;
        private string nume;
        private string prenume;
        private string oras;
        private string adresa;
        private int telefon;
        private double valoareTransport;
        private double valoareComanda;



        public int CodLivrare
        {
            get { return codLivrare; }
            set { if (value > 0) codLivrare = value; }
        }
        public int Telefon
        {
            get { return telefon; }
            set { if (value > 0) telefon = value; }
        }
        public double ValoareTransport
        {
            get { return valoareTransport; }
            set { if (value > 0) valoareTransport = value; }

        }
        public double ValoareComanda
        {
            get { return valoareComanda; }
            set { if (value > 0) valoareComanda = value; }

        }
        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { if (value != null) prenume = value; }
        }
        public string Oras
        {
            get { return oras; }
            set { if (value != null) oras = value; }
        }
        public string Adresa
        {
            get { return adresa; }
            set { if (value != null) adresa = value; }
        }
        public LivrareClient(string nume, string prenume,string oras, string adresa, int telefon)
        {

            this.nume = nume;
            this.prenume = prenume;
            this.oras = oras;
            this.adresa = adresa;
            this.telefon = telefon;
        }
        public LivrareClient(double valoareComanda)
        {
            this.valoareComanda = valoareComanda;
        }
        
            object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            LivrareClient p = (LivrareClient)obj;
            if (this.codLivrare < p.codLivrare)
                return -1;
            else if (this.codLivrare > p.codLivrare)
                return 1;
            else return string.Compare(this.nume, p.nume);
        }
    }
}

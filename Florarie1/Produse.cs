using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florarie1
{
     public class Produse:ICloneable,IComparable
    {
      
        private string nume;
        private double pret;
        private int cantitate;


        public Produse()
        {
            
        }


      
        public int Cantitate
        {
            get { return cantitate; }
            set { if (value > 0) cantitate = value; }
        }
        public double Pret
        {
            get { return pret; }
            set { if (value > 0) pret = value; }

        }
        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

public Produse(string nume, double pret, int cantitate)
        {
            this.nume = nume;
            this.pret = pret;
            this.cantitate = cantitate;
        }
        public  Produse(int codProdus, string nume, double pret, int cantitate)
        {
           
            this.nume = nume;
            this.pret = pret;
            this.cantitate = cantitate;
        }
       

        public override string ToString()
        {
            return nume + " " + pret + " " + cantitate;
        }


        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
           
        }
        public int CompareTo(object obj)
        {
            Produse p = (Produse)obj;
            if (this.cantitate < p.cantitate)
                return -1;
            else if (this.cantitate > p.cantitate)
                return 1;
            else return string.Compare(this.nume, p.nume);
        }


    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florarie1
{
 
    public partial class AdaugaProd : Form
    {
        public Produse a = new Produse();
        string Provider;

        public AdaugaProd()
        {
            InitializeComponent();
               //Provider = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= produs.accdb";
        }
        public AdaugaProd(Produse param)
        {
            InitializeComponent();
            a = param;
            tb_nume.Text = a.Nume;
            tb_pret.Text = a.Pret.ToString();
            tb_stoc.Text = a.Cantitate.ToString();
            
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            string nume = tb_nume.Text;
            double pret = 0;
            int cantitate = 0;
            try
            {
                pret = Convert.ToDouble(tb_pret.Text);
                cantitate = Convert.ToInt32(tb_stoc.Text);
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            a.Nume = nume;
            a.Pret = pret;
            a.Cantitate = cantitate;

           
        }

        private void Tb_nume_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florarie1
{
    public partial class ProdusNou : Form
    {
        string Provider;
        public ProdusNou()
        {
            InitializeComponent();
            Provider = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= produs.accdb";
            UpdateList();
        }
        private void UpdateList()
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(Provider);
            string sql = "SELECT * FROM  produs";
            OleDbCommand comanda = new OleDbCommand(sql, conexiune);

            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["nume"].ToString());
                    itm.SubItems.Add(reader["pret"].ToString());
                    itm.SubItems.Add(reader["cantitate"].ToString());

                    Produse p = new Produse
                    {

                        Nume = reader["nume"].ToString(),
                        Pret = Convert.ToDouble(reader["pret"].ToString()),
                        Cantitate = Convert.ToInt32(reader["cantitate"].ToString()),
                    };

                    itm.Tag = p;
                    listView1.Items.Add(itm);

                }
                reader.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexiune.Close();
            }
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void StergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(Provider);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();
                comanda.Transaction = conexiune.BeginTransaction();

                comanda.CommandText = " delete from produs where nume=@nume";
                comanda.Parameters.Add("nume", OleDbType.Char).Value = ((Produse)listView1.SelectedItems[0].Tag).Nume;
                comanda.ExecuteScalar();
                comanda.Transaction.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                comanda.Transaction.Rollback();
            }
            finally
            {
                conexiune.Close();
            }
            UpdateList();
        }

        private void ModificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaProd ap = new AdaugaProd((Produse)listView1.SelectedItems[0].Tag);

            ap.ShowDialog();

            if (ap.DialogResult == DialogResult.OK)
            {
                OleDbConnection conexiune = new OleDbConnection(Provider);
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                try
                {
                    conexiune.Open();
                    comanda.Transaction = conexiune.BeginTransaction();
                    comanda.CommandText = " update produs set pret=@pret, "+ "  cantitate=@cantitate  where nume=@nume";
                   
                    comanda.Parameters.Add("pret", OleDbType.Double).Value = ap.a.Pret;
                    comanda.Parameters.Add("cantitate", OleDbType.Integer).Value = ap.a.Cantitate;
                    comanda.Parameters.Add("nume", OleDbType.Char).Value = ap.a.Nume;
                    comanda.ExecuteScalar();
                    comanda.Transaction.Commit();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    comanda.Transaction.Rollback();
                }
                finally
                {
                    conexiune.Close();
                }
                UpdateList();
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaProd f2 = new AdaugaProd();
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                OleDbConnection conexiune = new OleDbConnection(Provider);
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                try
                {
                    conexiune.Open();
                    comanda.Transaction = conexiune.BeginTransaction();


                    comanda.CommandText = "INSERT INTO produs(nume, pret,cantitate)" + "VALUES( @nume,@pret,@cantitate)";

                    comanda.Parameters.Add("nume", OleDbType.Char).Value = f2.a.Nume;//putem pune si exceptie gen de 10 caractere dupa , Add("nume", OleDbType.Char,10)
                    comanda.Parameters.Add("pret", OleDbType.Double).Value = f2.a.Pret;
                    comanda.Parameters.Add("cantitate", OleDbType.Integer).Value = f2.a.Cantitate;



                    comanda.ExecuteNonQuery(); 
                    comanda.Transaction.Commit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    comanda.Transaction.Rollback();
                }
                finally
                {
                    conexiune.Close();
                }
                UpdateList();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Statistici s = new Statistici();
            s.Show();
        }
    }
}



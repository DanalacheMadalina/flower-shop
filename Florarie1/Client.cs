using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Florarie1
{
    
    public partial class Client : Form
    {
        Produse p = new Produse();
        private object encoding;
        string Provider = null;
        ArrayList lista;
        ArrayList listaComandata = new ArrayList();

        public Client()
        {
            InitializeComponent();
            Provider = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= produs.accdb";
            UpdateList();
           
        }
        public Client(ArrayList lista2)
        {
            InitializeComponent();
            Provider = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = produs.accdb";
            
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


        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buton_select_Catitate_Click(object sender, EventArgs e)
        {
           
            int cantitate_aleasa = Convert.ToInt32(tb_cantitate.Text);
            OleDbConnection conexiune = new OleDbConnection(Provider);
            OleDbCommand comanda = new OleDbCommand();
            string numeFl = "aaa";
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked == true)
                {
                    ListViewItem itemA = new ListViewItem(item.SubItems[0].Text, 0);
                    numeFl = item.SubItems[0].Text;
                    itemA.SubItems.Add(item.SubItems[1].Text);
                    itemA.SubItems.Add(tb_cantitate.Text);
                    listView2.Items.Add(itemA);
                    listView2.Show();
                }
            }
            double total = 0.00;
            foreach (ListViewItem it in listView2.Items)
            {
                total += int.Parse(it.SubItems[1].Text) * int.Parse(it.SubItems[2].Text);
            }
            label4.Text = total.ToString() ;
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune; comanda.CommandText = "update produs set cantitate=cantitate - ? where nume=?";
                comanda.Parameters.Add("cantitate", OleDbType.Integer).Value = Convert.ToInt32(tb_cantitate.Text);
                comanda.Parameters.Add("nume", OleDbType.Char).Value = numeFl;
                comanda.ExecuteNonQuery();
                MessageBox.Show("Produs modificat");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tb_cantitate.Text = "";
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                this.Hide();
                Livrare f = new Livrare(listaComandata, label4.Text);
                
                OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = produs.accdb");
                OleDbCommand comanda = new OleDbCommand("select pret from produs", conexiune);
                foreach (ListViewItem itm in listView1.CheckedItems)
                {
                    try
                    {
                        conexiune.Open();
                        OleDbDataReader reader = comanda.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
                f.Show();
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati minim un produs!", "Comanda");
            }
            
             
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void ContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
          
         }

        private void SalvareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SalvareFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*txt)|*.txt";  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(((Produse)listView1.SelectedItems[0].Tag).ToString()); 
                sw.Close();
                fs.Close();
            }
        }

        private void SalvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MemoryStream memStream = new MemoryStream();  
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("Lista-persoane");

            foreach (ListViewItem lvi in listView1.Items)
            {
                Produse plocal = (Produse)lvi.Tag;
                writer.WriteStartElement("Produs");

                writer.WriteStartElement("nume");
                writer.WriteValue(plocal.Nume);
                writer.WriteEndElement();  

              
                writer.WriteStartElement("Pret");
                writer.WriteValue(plocal.Pret);
                writer.WriteEndElement();

                writer.WriteStartElement("Cantitate");
                writer.WriteValue(plocal.Cantitate);
                writer.WriteEndElement();

                writer.WriteEndElement();  
            }
            writer.WriteEndElement(); 
            writer.WriteEndDocument();
            writer.Close();

            string xmlString = Encoding.UTF8.GetString(memStream.ToArray()); 
            memStream.Close();
            memStream.Dispose();        
            StreamWriter sw = new StreamWriter("fisier.xml");
            sw.WriteLine(xmlString);
            sw.Close();
            MessageBox.Show("Fisier generat cu succes!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void StatisticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistici grafic = new Statistici();
            grafic.Show();
        }

        private void StergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView2.SelectedItems[0].Remove();
        }

        private void Client_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

       
     
        private void SAlvareXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("Lista-persoane");

            foreach (ListViewItem lvi in listView1.Items)
            {
                Produse plocal = (Produse)lvi.Tag;
                writer.WriteStartElement("Produs");

                writer.WriteStartElement("nume");
                writer.WriteValue(plocal.Nume);
                writer.WriteEndElement();


                writer.WriteStartElement("Pret");
                writer.WriteValue(plocal.Pret);
                writer.WriteEndElement();

                writer.WriteStartElement("Cantitate");
                writer.WriteValue(plocal.Cantitate);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            string xmlString = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();
            memStream.Dispose();
            StreamWriter sw = new StreamWriter("fisier.xml");
            sw.WriteLine(xmlString);
            sw.Close();
            MessageBox.Show("Fisier generat cu succes!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SalveazaTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(((Produse)listView1.SelectedItems[0].Tag).ToString());
                sw.Close();
                fs.Close();
            }
        }

        private void IesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    }



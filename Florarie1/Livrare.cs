using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florarie1
{
    public partial class Livrare : Form
    {
        private BindingManagerBase  bmOrders;
        private DataSet ds;
        public ArrayList produseComandate;
        public Livrare()
        {
            InitializeComponent();
           

        }
        public Livrare(ArrayList lista, string t)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            produseComandate = lista;
            textBox1.Text = t;
            InitializeazaDate();
            this.comboBox1.Items.Add("Bucuresti");
            this.comboBox1.Items.Add("Botosani");
            this.comboBox1.Items.Add("Cluj");
            this.comboBox1.Items.Add("Timisoara");
        }
        private void InitializeazaDate()
        {
            InitializareDS();
            BindControls();
        }
      
        private void InitializareDS()
        {
            ds = new DataSet("myDataSet");
            DataTable tLivrari = new DataTable("Livrari");
           
            DataColumn DataLivrarii = new DataColumn("DataLivrarii", typeof(DateTime));
          
            tLivrari.Columns.Add(DataLivrarii);
            ds.Tables.Add(tLivrari);
       
            DataRow newRow1;
            
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    newRow1 = tLivrari.NewRow();
                    newRow1["DataLivrarii"] = new DateTime(2019, i, j * 2);
                    tLivrari.Rows.Add(newRow1);
                }
            }

        }
        private void BindControls()
        {
            dateTimePicker1.DataBindings.Add(new Binding("Value", ds, "Livrari.DataLivrarii"));
            bmOrders = this.BindingContext[ds, "Livrari"];
        }
        private void Livrare_Load(object sender, EventArgs e)
        {
        }

        private void Tb_valLivrare_TextChanged(object sender, EventArgs e)
        {         
        }
        

        
        private void Label3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.DoDragDrop(label3.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }
        private void Label4_MouseDown(object sender, MouseEventArgs e)
        {
            label4.DoDragDrop(label4.Text, DragDropEffects.Copy | DragDropEffects.Move);

        }
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
        }
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))

            {
                e.Effect = DragDropEffects.Copy;

            }
            else
                e.Effect = DragDropEffects.None;

        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void frm_print(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);

        }
        private void Finalizare_Click(object sender, EventArgs e)
        {
            bool vb = false;
            try
            {
                string nume = tb_nume.Text;
                if (tb_nume.Text == string.Empty)
                {
                    vb = true;
                    tb_nume.Focus();
                    errorProvider1.SetError(tb_nume, "Introduceti numele!");
                }
                string prenume = tb_prenume.Text;
                if (tb_prenume.Text == string.Empty)
                {
                    vb = true;
                    tb_prenume.Focus();
                    errorProvider1.SetError(tb_prenume, "Introduceti prenumele!");
                }
                string telefon = tb_telefon.Text;
                if (tb_telefon.Text == string.Empty)
                {
                    vb = true;
                    tb_telefon.Focus();
                    errorProvider1.SetError(tb_telefon, "Introduceti nr de telefon!");
                }
                string adresa = tb_adresa.Text;
                if (tb_adresa.Text == string.Empty)
                {
                    vb = true;
                    tb_adresa.Focus();
                    errorProvider1.SetError(tb_adresa, "Introduceti adresa de livrare!");
                }
                string oras = comboBox1.Text;
                if (comboBox1.Text == string.Empty)
                {
                    vb = true;
                    comboBox1.Focus();
                    errorProvider1.SetError(comboBox1, "Introduceti orasul!");
                }
                if (panel1.Visible == false)
                {
                    panel1.Visible = true;
                    panel1.Refresh();
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(this.frm_print);
                    PrintPreviewDialog pdlg = new PrintPreviewDialog();
                    pdlg.Document = pd;
                    pdlg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bmOrders.Position -= 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bmOrders.Position += 1;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen s = new Pen(Color.Black, 3);
            SolidBrush br = new SolidBrush(Color.LightPink);
            e.Graphics.DrawString("Factura " +dateTimePicker1.Text, new Font(FontFamily.GenericSerif, 12), br, 40, 20);
            e.Graphics.DrawString("Nume:" +tb_nume.Text, new Font(FontFamily.GenericSerif, 12), new SolidBrush(Color.Black), 20, 100);
           
            e.Graphics.DrawString("Valoare comenzii: " +textBox1.Text , new Font(FontFamily.GenericSerif, 10), new SolidBrush(Color.Black), 20, 120);
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Client cl = new Client();
            cl.Show();
        }

        private void Tb_nume_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Tb_nume_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void Tb_prenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Label2_MouseDown_1(object sender, MouseEventArgs e)
        {
            label2.DoDragDrop(label2.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Livrare_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Livrare_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tasta = e.KeyChar.ToString();
            if(tasta=="x"||tasta=="X")
            {
                MessageBox.Show("exit");
                this.Close();
            }
        }


    }
}

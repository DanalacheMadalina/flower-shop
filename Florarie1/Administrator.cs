using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florarie1
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("administrator.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadToEnd();
            string[] substr = Regex.Split(text, " ");
            int i = 0;
            bool ok = true;
            while (ok == true && i < substr.Length)
            {
                if (tb_username.Text == substr[i] && tb_pw.Text == substr[i + 1])
                {

                    ok = false;
                }

                i = i + 2;

            }
            if (ok == false)
            {
                this.Hide();
                ProdusNou a = new ProdusNou();
                a.Show();
            }
            else
            {
                MessageBox.Show("Logare incorecta");
            }

            GC.Collect();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
       
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}

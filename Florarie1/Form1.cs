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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Client_Click(object sender, EventArgs e)
        {
           
            Client f = new Client();
            f.Show();
        }

        private void LogAdministrator_Click(object sender, EventArgs e)
        {
            
            Administrator a = new Administrator();
            a.Show();
        }
    }
}

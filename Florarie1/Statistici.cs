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
    public partial class Statistici : Form
    {
        int coloane;
        string[] x;
            float [] y;
        public Statistici()
        {
            InitializeComponent();
            coloane = 5;
            x = new string[] { "Martie", "Mai", "Iunie" ,"Iulie", "August"};
            y = new float[] { 500f, 420f, 300f, 340f, 421f};


        }
        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
        private void Inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle zonaClient = e.ClipRectangle;
            Brush fundal = new SolidBrush(Color.White);
            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 20;
            zonaClient.Y += 20;
            zonaClient.Height -= 40;
            zonaClient.Width -= 40;


            int i, vl = zonaClient.Left, vb = zonaClient.Bottom,
                vr = zonaClient.Right, vt = zonaClient.Top;

            Pen creionRosu = new Pen(Color.Red, 2);
            g.DrawRectangle(creionRosu, zonaClient);

            SolidBrush[] pensule = new SolidBrush[]
                {
                new SolidBrush(Color.Pink),
                new SolidBrush(Color.MediumPurple),
                new SolidBrush(Color.CadetBlue),
                new SolidBrush(Color.Yellow),
                new SolidBrush(Color.MediumSeaGreen),
                new SolidBrush(Color.OrangeRed)

                };

            Pen[] creioane = new Pen[]
            {
                new Pen(Color.Red),
                new Pen(Color.Blue),
                new Pen(Color.Green),
                new Pen(Color.Olive),
                new Pen(Color.Yellow),
                new Pen(Color.Cyan)
            };

            SolidBrush pnsCrt;
            Pen penCrt;

            float rap_dist_lat = 0.2f, max;
            int lat = (vr - vl) / (int)((coloane + 1) * rap_dist_lat + coloane);
            int dist = (int)(lat * rap_dist_lat);

            for (max = y[0], i = 1; i < coloane; i++)
                if (max < y[i])
                    max = y[i];

            penCrt = creioane[0];
            pnsCrt = pensule[5];
            g.DrawLine(penCrt, vl, vt, vl, vb);
            g.DrawLine(penCrt, vl, vb, vr, vb);

            penCrt = creioane[1];
            for (i = 0; i < coloane; i++)
            {
                pnsCrt = pensule[(4 + i) % 6];
                PointF pnt = new PointF(vl + dist + i * (lat + dist), vb - y[i] * (vb - vt) / max);
                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);

                g.FillRectangle(pnsCrt, new RectangleF(pnt, sz));
                string denx = " " + x[i];
                g.DrawString(denx, Font, pnsCrt, vl + dist + lat / 2 + i * (lat + dist), vb + 5);
                
                string deny = " " + y[i];
                g.DrawString(deny, Font, pnsCrt, vl + dist + lat / 3 + i * (lat + dist), vt+ 10);

            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ProdusNou s = new ProdusNou();
            s.Show();
        }
    }
}

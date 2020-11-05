namespace Florarie1
{
    partial class Livrare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livrare));
            this.label_nume = new System.Windows.Forms.Label();
            this.label2_prenume = new System.Windows.Forms.Label();
            this.label3_Oras = new System.Windows.Forms.Label();
            this.label4_adresa = new System.Windows.Forms.Label();
            this.label5_telefon = new System.Windows.Forms.Label();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.tb_prenume = new System.Windows.Forms.TextBox();
            this.tb_adresa = new System.Windows.Forms.TextBox();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.finalizare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.Location = new System.Drawing.Point(21, 19);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(45, 17);
            this.label_nume.TabIndex = 0;
            this.label_nume.Text = "Nume";
            // 
            // label2_prenume
            // 
            this.label2_prenume.AutoSize = true;
            this.label2_prenume.Location = new System.Drawing.Point(21, 74);
            this.label2_prenume.Name = "label2_prenume";
            this.label2_prenume.Size = new System.Drawing.Size(65, 17);
            this.label2_prenume.TabIndex = 1;
            this.label2_prenume.Text = "Prenume";
            // 
            // label3_Oras
            // 
            this.label3_Oras.AutoSize = true;
            this.label3_Oras.Location = new System.Drawing.Point(21, 124);
            this.label3_Oras.Name = "label3_Oras";
            this.label3_Oras.Size = new System.Drawing.Size(39, 17);
            this.label3_Oras.TabIndex = 2;
            this.label3_Oras.Text = "Oras";
            // 
            // label4_adresa
            // 
            this.label4_adresa.AutoSize = true;
            this.label4_adresa.Location = new System.Drawing.Point(21, 172);
            this.label4_adresa.Name = "label4_adresa";
            this.label4_adresa.Size = new System.Drawing.Size(53, 17);
            this.label4_adresa.TabIndex = 3;
            this.label4_adresa.Text = "Adresa";
            // 
            // label5_telefon
            // 
            this.label5_telefon.AutoSize = true;
            this.label5_telefon.Location = new System.Drawing.Point(21, 221);
            this.label5_telefon.Name = "label5_telefon";
            this.label5_telefon.Size = new System.Drawing.Size(56, 17);
            this.label5_telefon.TabIndex = 4;
            this.label5_telefon.Text = "Telefon";
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(158, 19);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(100, 22);
            this.tb_nume.TabIndex = 6;
            this.tb_nume.TextChanged += new System.EventHandler(this.Tb_nume_TextChanged);
            this.tb_nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_nume_KeyPress);
            // 
            // tb_prenume
            // 
            this.tb_prenume.Location = new System.Drawing.Point(158, 74);
            this.tb_prenume.Name = "tb_prenume";
            this.tb_prenume.Size = new System.Drawing.Size(100, 22);
            this.tb_prenume.TabIndex = 7;
            this.tb_prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_prenume_KeyPress);
            // 
            // tb_adresa
            // 
            this.tb_adresa.Location = new System.Drawing.Point(158, 172);
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.Size = new System.Drawing.Size(100, 22);
            this.tb_adresa.TabIndex = 8;
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(158, 221);
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(100, 22);
            this.tb_telefon.TabIndex = 9;
            this.tb_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_telefon_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(312, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Personalizeaza-ti buchetul!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(400, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Felicitare";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label3_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(492, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ambalaj mat";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseDown);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(601, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 68);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // finalizare
            // 
            this.finalizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.finalizare.Location = new System.Drawing.Point(623, 391);
            this.finalizare.Name = "finalizare";
            this.finalizare.Size = new System.Drawing.Size(165, 47);
            this.finalizare.TabIndex = 19;
            this.finalizare.Text = "Finalizeaza comanda si verifica factura!";
            this.finalizare.UseVisualStyleBackColor = false;
            this.finalizare.Click += new System.EventHandler(this.Finalizare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 361);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cand vrei sa fie livrata comanda?";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(351, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 210);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Valoarea comenzii";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(686, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Inapoi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(315, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Sclipici";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseDown_1);
            // 
            // Livrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.finalizare);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_telefon);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.tb_prenume);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.label5_telefon);
            this.Controls.Add(this.label4_adresa);
            this.Controls.Add(this.label3_Oras);
            this.Controls.Add(this.label2_prenume);
            this.Controls.Add(this.label_nume);
            this.Name = "Livrare";
            this.Text = "Livrare";
            this.Load += new System.EventHandler(this.Livrare_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Livrare_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Livrare_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nume;
        private System.Windows.Forms.Label label2_prenume;
        private System.Windows.Forms.Label label3_Oras;
        private System.Windows.Forms.Label label4_adresa;
        private System.Windows.Forms.Label label5_telefon;
        private System.Windows.Forms.TextBox tb_nume;
        private System.Windows.Forms.TextBox tb_prenume;
        private System.Windows.Forms.TextBox tb_adresa;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button finalizare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}
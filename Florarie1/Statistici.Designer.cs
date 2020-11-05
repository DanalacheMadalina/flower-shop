namespace Florarie1
{
    partial class Statistici
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buton_inapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(44, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 316);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evolutia vanzarilor lunare";
            // 
            // buton_inapoi
            // 
            this.buton_inapoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buton_inapoi.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F);
            this.buton_inapoi.Location = new System.Drawing.Point(656, 12);
            this.buton_inapoi.Name = "buton_inapoi";
            this.buton_inapoi.Size = new System.Drawing.Size(132, 53);
            this.buton_inapoi.TabIndex = 5;
            this.buton_inapoi.Text = "Inapoi";
            this.buton_inapoi.UseVisualStyleBackColor = true;
            this.buton_inapoi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Statistici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buton_inapoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Statistici";
            this.Text = "Statistici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buton_inapoi;
    }
}
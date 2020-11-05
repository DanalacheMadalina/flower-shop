namespace Florarie1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LogAdministrator = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bine ati venit la Floraria IRIS";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LogAdministrator
            // 
            this.LogAdministrator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LogAdministrator.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LogAdministrator.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogAdministrator.Location = new System.Drawing.Point(199, 322);
            this.LogAdministrator.Name = "LogAdministrator";
            this.LogAdministrator.Size = new System.Drawing.Size(136, 50);
            this.LogAdministrator.TabIndex = 1;
            this.LogAdministrator.Text = "Administrator";
            this.LogAdministrator.UseVisualStyleBackColor = false;
            this.LogAdministrator.Click += new System.EventHandler(this.LogAdministrator_Click);
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.client.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.client.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.Location = new System.Drawing.Point(521, 322);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(129, 50);
            this.client.TabIndex = 2;
            this.client.Text = "Client";
            this.client.UseVisualStyleBackColor = false;
            this.client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.client);
            this.Controls.Add(this.LogAdministrator);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogAdministrator;
        private System.Windows.Forms.Button client;
    }
}


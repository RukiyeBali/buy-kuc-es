namespace If_else
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
            this.lblSayı1 = new System.Windows.Forms.Label();
            this.lblSayı2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSayı1
            // 
            this.lblSayı1.AutoSize = true;
            this.lblSayı1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayı1.ForeColor = System.Drawing.Color.Crimson;
            this.lblSayı1.Location = new System.Drawing.Point(71, 49);
            this.lblSayı1.Name = "lblSayı1";
            this.lblSayı1.Size = new System.Drawing.Size(72, 24);
            this.lblSayı1.TabIndex = 0;
            this.lblSayı1.Text = "Sayı1:";
            // 
            // lblSayı2
            // 
            this.lblSayı2.AutoSize = true;
            this.lblSayı2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayı2.ForeColor = System.Drawing.Color.Crimson;
            this.lblSayı2.Location = new System.Drawing.Point(71, 115);
            this.lblSayı2.Name = "lblSayı2";
            this.lblSayı2.Size = new System.Drawing.Size(72, 24);
            this.lblSayı2.TabIndex = 1;
            this.lblSayı2.Text = "Sayı2:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Gold;
            this.btnHesapla.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Crimson;
            this.btnHesapla.Location = new System.Drawing.Point(163, 181);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 40);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSayı1
            // 
            this.txtSayı1.Location = new System.Drawing.Point(163, 53);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(100, 20);
            this.txtSayı1.TabIndex = 3;
            // 
            // txtSayı2
            // 
            this.txtSayı2.Location = new System.Drawing.Point(163, 115);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(100, 20);
            this.txtSayı2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(560, 352);
            this.Controls.Add(this.txtSayı2);
            this.Controls.Add(this.txtSayı1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSayı2);
            this.Controls.Add(this.lblSayı1);
            this.Name = "Form1";
            this.Text = "Büyük mü? yoksa Küçük mü? ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayı1;
        private System.Windows.Forms.Label lblSayı2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayı1;
        private System.Windows.Forms.TextBox txtSayı2;
    }
}


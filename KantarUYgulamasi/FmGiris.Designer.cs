namespace KantarUYgulamasi
{
    partial class FmGiris
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
            this.rapor = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.Btnkayit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblSofor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rapor
            // 
            this.rapor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rapor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rapor.ForeColor = System.Drawing.SystemColors.Window;
            this.rapor.Location = new System.Drawing.Point(63, 138);
            this.rapor.Name = "rapor";
            this.rapor.Size = new System.Drawing.Size(109, 55);
            this.rapor.TabIndex = 7;
            this.rapor.Text = "Rapor";
            this.rapor.UseVisualStyleBackColor = false;
            this.rapor.Click += new System.EventHandler(this.rapor_Click);
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.giris.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.ForeColor = System.Drawing.SystemColors.Window;
            this.giris.Location = new System.Drawing.Point(63, 64);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(109, 53);
            this.giris.TabIndex = 5;
            this.giris.Text = "Giriş";
            this.giris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.giris.UseVisualStyleBackColor = false;
            // 
            // Btnkayit
            // 
            this.Btnkayit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btnkayit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnkayit.Location = new System.Drawing.Point(484, 235);
            this.Btnkayit.Name = "Btnkayit";
            this.Btnkayit.Size = new System.Drawing.Size(144, 52);
            this.Btnkayit.TabIndex = 8;
            this.Btnkayit.Text = "Kayıt";
            this.Btnkayit.UseVisualStyleBackColor = false;
            this.Btnkayit.Click += new System.EventHandler(this.Btnkayit_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 20);
            this.textBox2.TabIndex = 10;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(259, 64);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 12;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblSofor
            // 
            this.lblSofor.AutoSize = true;
            this.lblSofor.Location = new System.Drawing.Point(261, 122);
            this.lblSofor.Name = "lblSofor";
            this.lblSofor.Size = new System.Drawing.Size(32, 13);
            this.lblSofor.TabIndex = 13;
            this.lblSofor.Text = "Şoför";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kayıt Eden";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(385, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 20);
            this.textBox4.TabIndex = 15;
            // 
            // FmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblSofor);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btnkayit);
            this.Controls.Add(this.rapor);
            this.Controls.Add(this.giris);
            this.Name = "FmGiris";
            this.Text = "FmGiris";
            this.Load += new System.EventHandler(this.FmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rapor;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button Btnkayit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblSofor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
    }
}
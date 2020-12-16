namespace KantarUYgulamasi
{
    partial class FmCikis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCikis));
            this.rapor = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.lblGAgirlik = new System.Windows.Forms.Label();
            this.lblSofor = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btnkayit = new System.Windows.Forms.Button();
            this.lblUagirlik = new System.Windows.Forms.Label();
            this.lblCagirlik = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.kantarDataSet = new KantarUYgulamasi.kantarDataSet();
            this.kantarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamyonTableAdapter = new KantarUYgulamasi.kantarDataSetTableAdapters.kamyonTableAdapter();
            this.kamyonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kantarDataSet2 = new KantarUYgulamasi.kantarDataSet2();
            this.kamyonTableAdapter1 = new KantarUYgulamasi.kantarDataSet2TableAdapters.kamyonTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.kantarDataSet4 = new KantarUYgulamasi.kantarDataSet4();
            this.kamyonBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kamyonTableAdapter2 = new KantarUYgulamasi.kantarDataSet4TableAdapters.kamyonTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kantarDataSet8 = new KantarUYgulamasi.kantarDataSet8();
            this.kamyonBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kamyonTableAdapter3 = new KantarUYgulamasi.kantarDataSet8TableAdapters.kamyonTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitEdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisAgirlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamyonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamyonBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamyonBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // rapor
            // 
            this.rapor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rapor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rapor.ForeColor = System.Drawing.SystemColors.Window;
            this.rapor.Location = new System.Drawing.Point(12, 223);
            this.rapor.Name = "rapor";
            this.rapor.Size = new System.Drawing.Size(109, 55);
            this.rapor.TabIndex = 10;
            this.rapor.Text = "Rapor";
            this.rapor.UseVisualStyleBackColor = false;
            this.rapor.Click += new System.EventHandler(this.rapor_Click);
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.giris.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.ForeColor = System.Drawing.SystemColors.Window;
            this.giris.Location = new System.Drawing.Point(12, 52);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(109, 53);
            this.giris.TabIndex = 8;
            this.giris.Text = "Giriş";
            this.giris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // lblGAgirlik
            // 
            this.lblGAgirlik.AutoSize = true;
            this.lblGAgirlik.Location = new System.Drawing.Point(844, 162);
            this.lblGAgirlik.Name = "lblGAgirlik";
            this.lblGAgirlik.Size = new System.Drawing.Size(60, 13);
            this.lblGAgirlik.TabIndex = 21;
            this.lblGAgirlik.Text = "Giriş Ağırlığı";
            // 
            // lblSofor
            // 
            this.lblSofor.AutoSize = true;
            this.lblSofor.Location = new System.Drawing.Point(844, 112);
            this.lblSofor.Name = "lblSofor";
            this.lblSofor.Size = new System.Drawing.Size(32, 13);
            this.lblSofor.TabIndex = 20;
            this.lblSofor.Text = "Şoför";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(842, 63);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 19;
            this.lblPlaka.Text = "Plaka";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(938, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(938, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(938, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 16;
            // 
            // Btnkayit
            // 
            this.Btnkayit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btnkayit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnkayit.Location = new System.Drawing.Point(946, 314);
            this.Btnkayit.Name = "Btnkayit";
            this.Btnkayit.Size = new System.Drawing.Size(144, 52);
            this.Btnkayit.TabIndex = 15;
            this.Btnkayit.Text = "Kayıt Sil";
            this.Btnkayit.UseVisualStyleBackColor = false;
            this.Btnkayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUagirlik
            // 
            this.lblUagirlik.AutoSize = true;
            this.lblUagirlik.Location = new System.Drawing.Point(844, 276);
            this.lblUagirlik.Name = "lblUagirlik";
            this.lblUagirlik.Size = new System.Drawing.Size(63, 13);
            this.lblUagirlik.TabIndex = 25;
            this.lblUagirlik.Text = "Ürün Ağırlığı";
            // 
            // lblCagirlik
            // 
            this.lblCagirlik.AutoSize = true;
            this.lblCagirlik.Location = new System.Drawing.Point(844, 219);
            this.lblCagirlik.Name = "lblCagirlik";
            this.lblCagirlik.Size = new System.Drawing.Size(62, 13);
            this.lblCagirlik.TabIndex = 24;
            this.lblCagirlik.Text = "Çıkış Ağırlığı";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(938, 219);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(938, 276);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(152, 20);
            this.textBox5.TabIndex = 22;
            // 
            // kantarDataSet
            // 
            this.kantarDataSet.DataSetName = "kantarDataSet";
            this.kantarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kantarDataSetBindingSource
            // 
            this.kantarDataSetBindingSource.DataSource = this.kantarDataSet;
            this.kantarDataSetBindingSource.Position = 0;
            // 
            // kamyonBindingSource
            // 
            this.kamyonBindingSource.DataMember = "kamyon";
            this.kamyonBindingSource.DataSource = this.kantarDataSetBindingSource;
            // 
            // kamyonTableAdapter
            // 
            this.kamyonTableAdapter.ClearBeforeFill = true;
            // 
            // kamyonBindingSource1
            // 
            this.kamyonBindingSource1.DataMember = "kamyon";
            this.kamyonBindingSource1.DataSource = this.kantarDataSet2;
            // 
            // kantarDataSet2
            // 
            this.kantarDataSet2.DataSetName = "kantarDataSet2";
            this.kantarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamyonTableAdapter1
            // 
            this.kamyonTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::KantarUYgulamasi.Properties.Resources.on_off;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1085, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 51);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1011, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 51);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cikis.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.SystemColors.Window;
            this.cikis.Location = new System.Drawing.Point(12, 135);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(109, 55);
            this.cikis.TabIndex = 9;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = false;
            // 
            // kantarDataSet4
            // 
            this.kantarDataSet4.DataSetName = "kantarDataSet4";
            this.kantarDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamyonBindingSource2
            // 
            this.kamyonBindingSource2.DataMember = "kamyon";
            this.kamyonBindingSource2.DataSource = this.kantarDataSet4;
            // 
            // kamyonTableAdapter2
            // 
            this.kamyonTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.soforDataGridViewTextBoxColumn,
            this.kayitEdenDataGridViewTextBoxColumn,
            this.girisAgirlikDataGridViewTextBoxColumn,
            this.girisTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kamyonBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(152, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 237);
            this.dataGridView1.TabIndex = 29;
            // 
            // kantarDataSet8
            // 
            this.kantarDataSet8.DataSetName = "kantarDataSet8";
            this.kantarDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamyonBindingSource3
            // 
            this.kamyonBindingSource3.DataMember = "kamyon";
            this.kamyonBindingSource3.DataSource = this.kantarDataSet8;
            // 
            // kamyonTableAdapter3
            // 
            this.kamyonTableAdapter3.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // soforDataGridViewTextBoxColumn
            // 
            this.soforDataGridViewTextBoxColumn.DataPropertyName = "Sofor";
            this.soforDataGridViewTextBoxColumn.HeaderText = "Sofor";
            this.soforDataGridViewTextBoxColumn.Name = "soforDataGridViewTextBoxColumn";
            // 
            // kayitEdenDataGridViewTextBoxColumn
            // 
            this.kayitEdenDataGridViewTextBoxColumn.DataPropertyName = "Kayit_Eden";
            this.kayitEdenDataGridViewTextBoxColumn.HeaderText = "Kayit_Eden";
            this.kayitEdenDataGridViewTextBoxColumn.Name = "kayitEdenDataGridViewTextBoxColumn";
            // 
            // girisAgirlikDataGridViewTextBoxColumn
            // 
            this.girisAgirlikDataGridViewTextBoxColumn.DataPropertyName = "Giris_Agirlik";
            this.girisAgirlikDataGridViewTextBoxColumn.HeaderText = "Giris_Agirlik";
            this.girisAgirlikDataGridViewTextBoxColumn.Name = "girisAgirlikDataGridViewTextBoxColumn";
            // 
            // girisTarihDataGridViewTextBoxColumn
            // 
            this.girisTarihDataGridViewTextBoxColumn.DataPropertyName = "Giris_Tarih";
            this.girisTarihDataGridViewTextBoxColumn.HeaderText = "Giris_Tarih";
            this.girisTarihDataGridViewTextBoxColumn.Name = "girisTarihDataGridViewTextBoxColumn";
            // 
            // FmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUagirlik);
            this.Controls.Add(this.lblCagirlik);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblGAgirlik);
            this.Controls.Add(this.lblSofor);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btnkayit);
            this.Controls.Add(this.rapor);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.giris);
            this.Name = "FmCikis";
            this.Text = "FmCikis";
            this.Load += new System.EventHandler(this.FmCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamyonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamyonBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamyonBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rapor;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Label lblGAgirlik;
        private System.Windows.Forms.Label lblSofor;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btnkayit;
        private System.Windows.Forms.Label lblUagirlik;
        private System.Windows.Forms.Label lblCagirlik;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private kantarDataSet kantarDataSet;
        private System.Windows.Forms.BindingSource kantarDataSetBindingSource;
        private System.Windows.Forms.BindingSource kamyonBindingSource;
        private kantarDataSetTableAdapters.kamyonTableAdapter kamyonTableAdapter;
        private System.Windows.Forms.Button button2;
        private kantarDataSet2 kantarDataSet2;
        private System.Windows.Forms.BindingSource kamyonBindingSource1;
        private kantarDataSet2TableAdapters.kamyonTableAdapter kamyonTableAdapter1;
        private System.Windows.Forms.Button cikis;
        private kantarDataSet4 kantarDataSet4;
        private System.Windows.Forms.BindingSource kamyonBindingSource2;
        private kantarDataSet4TableAdapters.kamyonTableAdapter kamyonTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kantarDataSet8 kantarDataSet8;
        private System.Windows.Forms.BindingSource kamyonBindingSource3;
        private kantarDataSet8TableAdapters.kamyonTableAdapter kamyonTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitEdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisAgirlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihDataGridViewTextBoxColumn;
    }
}
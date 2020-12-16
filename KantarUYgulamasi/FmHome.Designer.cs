namespace KantarUYgulamasi
{
    partial class FmHome
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
            this.giriss = new System.Windows.Forms.Button();
            this.raporr = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kantarDataSet1 = new KantarUYgulamasi.kantarDataSet();
            this.kantarDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamyonTableAdapter1 = new KantarUYgulamasi.kantarDataSetTableAdapters.kamyonTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kantarDataSet11 = new KantarUYgulamasi.kantarDataSet1();
            this.kamyonTableAdapter2 = new KantarUYgulamasi.kantarDataSet1TableAdapters.kamyonTableAdapter();
            this.KayitSil = new System.Windows.Forms.Button();
            this.btnguncel = new System.Windows.Forms.Button();
            this.kantarDataSet5 = new KantarUYgulamasi.kantarDataSet5();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kamyonTableAdapter3 = new KantarUYgulamasi.kantarDataSet5TableAdapters.kamyonTableAdapter();
            this.kantarDataSet9 = new KantarUYgulamasi.kantarDataSet9();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.kamyonTableAdapter4 = new KantarUYgulamasi.kantarDataSet9TableAdapters.kamyonTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitEdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisAgirlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.kantarDataSet111 = new KantarUYgulamasi.kantarDataSet11();
            this.kantarDataSet10 = new KantarUYgulamasi.kantarDataSet10();
            this.bindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.kamyonTableAdapter5 = new KantarUYgulamasi.kantarDataSet10TableAdapters.kamyonTableAdapter();
            this.kamyonTableAdapter6 = new KantarUYgulamasi.kantarDataSet11TableAdapters.kamyonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // giriss
            // 
            this.giriss.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.giriss.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giriss.ForeColor = System.Drawing.SystemColors.Window;
            this.giriss.Location = new System.Drawing.Point(65, 56);
            this.giriss.Name = "giriss";
            this.giriss.Size = new System.Drawing.Size(109, 51);
            this.giriss.TabIndex = 0;
            this.giriss.Text = "Giriş";
            this.giriss.UseVisualStyleBackColor = false;
            this.giriss.Click += new System.EventHandler(this.giriss_Click);
            // 
            // raporr
            // 
            this.raporr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.raporr.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporr.ForeColor = System.Drawing.SystemColors.Window;
            this.raporr.Location = new System.Drawing.Point(65, 131);
            this.raporr.Name = "raporr";
            this.raporr.Size = new System.Drawing.Size(109, 52);
            this.raporr.TabIndex = 7;
            this.raporr.Text = "Rapor";
            this.raporr.UseVisualStyleBackColor = false;
            this.raporr.Click += new System.EventHandler(this.raporr_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "kamyon";
            this.bindingSource1.DataSource = this.kantarDataSet1;
            // 
            // kantarDataSet1
            // 
            this.kantarDataSet1.DataSetName = "kantarDataSet";
            this.kantarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kantarDataSet1BindingSource
            // 
            this.kantarDataSet1BindingSource.DataSource = this.kantarDataSet1;
            this.kantarDataSet1BindingSource.Position = 0;
            // 
            // kamyonTableAdapter1
            // 
            this.kamyonTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "kamyon";
            this.bindingSource2.DataSource = this.kantarDataSet11;
            // 
            // kantarDataSet11
            // 
            this.kantarDataSet11.DataSetName = "kantarDataSet1";
            this.kantarDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamyonTableAdapter2
            // 
            this.kamyonTableAdapter2.ClearBeforeFill = true;
            // 
            // KayitSil
            // 
            this.KayitSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.KayitSil.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitSil.ForeColor = System.Drawing.SystemColors.Window;
            this.KayitSil.Location = new System.Drawing.Point(65, 206);
            this.KayitSil.Name = "KayitSil";
            this.KayitSil.Size = new System.Drawing.Size(109, 56);
            this.KayitSil.TabIndex = 9;
            this.KayitSil.Text = "Kayıt Sil";
            this.KayitSil.UseVisualStyleBackColor = false;
            this.KayitSil.Click += new System.EventHandler(this.KayıtSil_Click);
            // 
            // btnguncel
            // 
            this.btnguncel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnguncel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnguncel.Location = new System.Drawing.Point(65, 281);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(109, 51);
            this.btnguncel.TabIndex = 10;
            this.btnguncel.Text = "Güncelle";
            this.btnguncel.UseVisualStyleBackColor = false;
            this.btnguncel.Click += new System.EventHandler(this.btnguncel_Click);
            // 
            // kantarDataSet5
            // 
            this.kantarDataSet5.DataSetName = "kantarDataSet5";
            this.kantarDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "kamyon";
            this.bindingSource3.DataSource = this.kantarDataSet5;
            // 
            // kamyonTableAdapter3
            // 
            this.kamyonTableAdapter3.ClearBeforeFill = true;
            // 
            // kantarDataSet9
            // 
            this.kantarDataSet9.DataSetName = "kantarDataSet9";
            this.kantarDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "kamyon";
            this.bindingSource4.DataSource = this.kantarDataSet9;
            // 
            // kamyonTableAdapter4
            // 
            this.kamyonTableAdapter4.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.soforDataGridViewTextBoxColumn,
            this.kayitEdenDataGridViewTextBoxColumn,
            this.girisAgirlikDataGridViewTextBoxColumn,
            this.girisTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(223, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 325);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Plaka";
            this.dataGridViewTextBoxColumn1.HeaderText = "Plaka";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // bindingSource6
            // 
            this.bindingSource6.DataMember = "kamyon";
            this.bindingSource6.DataSource = this.kantarDataSet111;
            // 
            // kantarDataSet111
            // 
            this.kantarDataSet111.DataSetName = "kantarDataSet11";
            this.kantarDataSet111.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kantarDataSet10
            // 
            this.kantarDataSet10.DataSetName = "kantarDataSet10";
            this.kantarDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource5
            // 
            this.bindingSource5.DataMember = "kamyon";
            this.bindingSource5.DataSource = this.kantarDataSet10;
            // 
            // kamyonTableAdapter5
            // 
            this.kamyonTableAdapter5.ClearBeforeFill = true;
            // 
            // kamyonTableAdapter6
            // 
            this.kamyonTableAdapter6.ClearBeforeFill = true;
            // 
            // FmHome
            // 
            this.ClientSize = new System.Drawing.Size(941, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguncel);
            this.Controls.Add(this.KayitSil);
            this.Controls.Add(this.raporr);
            this.Controls.Add(this.giriss);
            this.Name = "FmHome";
            this.Text = "FmHome";
            this.Load += new System.EventHandler(this.FmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private kantarDataSet kantarDataSet;
        private System.Windows.Forms.BindingSource kamyonBindingSource;
        private kantarDataSetTableAdapters.kamyonTableAdapter kamyonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şoförDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girişTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayıtEdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ağırlıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button guncelbnt;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button giriss;
        private System.Windows.Forms.Button raporr;
        private kantarDataSet kantarDataSet1;
        private System.Windows.Forms.BindingSource kantarDataSet1BindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kantarDataSetTableAdapters.kamyonTableAdapter kamyonTableAdapter1;
        private kantarDataSet1 kantarDataSet11;
        private System.Windows.Forms.BindingSource bindingSource2;
        private kantarDataSet1TableAdapters.kamyonTableAdapter kamyonTableAdapter2;
        private System.Windows.Forms.Button KayitSil;
        private System.Windows.Forms.Button btnguncel;
        private kantarDataSet5 kantarDataSet5;
        private System.Windows.Forms.BindingSource bindingSource3;
        private kantarDataSet5TableAdapters.kamyonTableAdapter kamyonTableAdapter3;
        private kantarDataSet9 kantarDataSet9;
        private System.Windows.Forms.BindingSource bindingSource4;
        private kantarDataSet9TableAdapters.kamyonTableAdapter kamyonTableAdapter4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kantarDataSet10 kantarDataSet10;
        private System.Windows.Forms.BindingSource bindingSource5;
        private kantarDataSet10TableAdapters.kamyonTableAdapter kamyonTableAdapter5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitEdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisAgirlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihDataGridViewTextBoxColumn;
        private kantarDataSet11 kantarDataSet111;
        private System.Windows.Forms.BindingSource bindingSource6;
        private kantarDataSet11TableAdapters.kamyonTableAdapter kamyonTableAdapter6;
    }
}
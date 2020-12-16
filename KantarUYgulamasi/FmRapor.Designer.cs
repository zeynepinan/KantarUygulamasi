namespace KantarUYgulamasi
{
    partial class FmRapor
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
            this.raporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kantarDataSet3 = new KantarUYgulamasi.kantarDataSet3();
            this.raporTableAdapter = new KantarUYgulamasi.kantarDataSet3TableAdapters.raporTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.goster = new System.Windows.Forms.Button();
            this.kantarDataSet6 = new KantarUYgulamasi.kantarDataSet6();
            this.raporBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raporTableAdapter1 = new KantarUYgulamasi.kantarDataSet6TableAdapters.raporTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitEdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisAgirlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisAgirlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAgirlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raporBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kantarDataSet7 = new KantarUYgulamasi.kantarDataSet7();
            this.raporTableAdapter2 = new KantarUYgulamasi.kantarDataSet7TableAdapters.raporTableAdapter();
            this.aramatxt = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // raporBindingSource
            // 
            this.raporBindingSource.DataMember = "rapor";
            this.raporBindingSource.DataSource = this.kantarDataSet3;
            // 
            // kantarDataSet3
            // 
            this.kantarDataSet3.DataSetName = "kantarDataSet3";
            this.kantarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raporTableAdapter
            // 
            this.raporTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(408, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // goster
            // 
            this.goster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goster.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goster.ForeColor = System.Drawing.SystemColors.Window;
            this.goster.Location = new System.Drawing.Point(606, 12);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(113, 60);
            this.goster.TabIndex = 3;
            this.goster.Text = "Göster";
            this.goster.UseVisualStyleBackColor = false;
            this.goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // kantarDataSet6
            // 
            this.kantarDataSet6.DataSetName = "kantarDataSet6";
            this.kantarDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raporBindingSource1
            // 
            this.raporBindingSource1.DataMember = "rapor";
            this.raporBindingSource1.DataSource = this.kantarDataSet6;
            // 
            // raporTableAdapter1
            // 
            this.raporTableAdapter1.ClearBeforeFill = true;
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
            this.girisTarihDataGridViewTextBoxColumn,
            this.cikisAgirlikDataGridViewTextBoxColumn,
            this.urunAgirlikDataGridViewTextBoxColumn,
            this.cikisTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.raporBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 321);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // cikisAgirlikDataGridViewTextBoxColumn
            // 
            this.cikisAgirlikDataGridViewTextBoxColumn.DataPropertyName = "Cikis_Agirlik";
            this.cikisAgirlikDataGridViewTextBoxColumn.HeaderText = "Cikis_Agirlik";
            this.cikisAgirlikDataGridViewTextBoxColumn.Name = "cikisAgirlikDataGridViewTextBoxColumn";
            // 
            // urunAgirlikDataGridViewTextBoxColumn
            // 
            this.urunAgirlikDataGridViewTextBoxColumn.DataPropertyName = "Urun_Agirlik";
            this.urunAgirlikDataGridViewTextBoxColumn.HeaderText = "Urun_Agirlik";
            this.urunAgirlikDataGridViewTextBoxColumn.Name = "urunAgirlikDataGridViewTextBoxColumn";
            // 
            // cikisTarihDataGridViewTextBoxColumn
            // 
            this.cikisTarihDataGridViewTextBoxColumn.DataPropertyName = "Cikis_Tarih";
            this.cikisTarihDataGridViewTextBoxColumn.HeaderText = "Cikis_Tarih";
            this.cikisTarihDataGridViewTextBoxColumn.Name = "cikisTarihDataGridViewTextBoxColumn";
            // 
            // raporBindingSource2
            // 
            this.raporBindingSource2.DataMember = "rapor";
            this.raporBindingSource2.DataSource = this.kantarDataSet7;
            // 
            // kantarDataSet7
            // 
            this.kantarDataSet7.DataSetName = "kantarDataSet7";
            this.kantarDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raporTableAdapter2
            // 
            this.raporTableAdapter2.ClearBeforeFill = true;
            // 
            // aramatxt
            // 
            this.aramatxt.Location = new System.Drawing.Point(31, 25);
            this.aramatxt.Name = "aramatxt";
            this.aramatxt.Size = new System.Drawing.Size(178, 20);
            this.aramatxt.TabIndex = 5;
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnara.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.ForeColor = System.Drawing.SystemColors.Window;
            this.btnara.Location = new System.Drawing.Point(232, 12);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(112, 40);
            this.btnara.TabIndex = 6;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(768, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.aramatxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FmRapor";
            this.Text = "FmRapor";
            this.Load += new System.EventHandler(this.FmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private kantarDataSet3 kantarDataSet3;
        private System.Windows.Forms.BindingSource raporBindingSource;
        private kantarDataSet3TableAdapters.raporTableAdapter raporTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button goster;
        private kantarDataSet6 kantarDataSet6;
        private System.Windows.Forms.BindingSource raporBindingSource1;
        private kantarDataSet6TableAdapters.raporTableAdapter raporTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kantarDataSet7 kantarDataSet7;
        private System.Windows.Forms.BindingSource raporBindingSource2;
        private kantarDataSet7TableAdapters.raporTableAdapter raporTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitEdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisAgirlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisAgirlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAgirlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox aramatxt;
        private System.Windows.Forms.Button btnara;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}
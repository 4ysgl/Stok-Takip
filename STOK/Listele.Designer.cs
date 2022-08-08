
namespace STOK
{
    partial class Listele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listele));
            this.eSTOKDataSet4 = new STOK.ESTOKDataSet4();
            this.uKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uKayitTableAdapter = new STOK.ESTOKDataSet4TableAdapters.UKayitTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBilgiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uKayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eSTOKDataSet5 = new STOK.ESTOKDataSet5();
            this.uKayitTableAdapter1 = new STOK.ESTOKDataSet5TableAdapters.UKayitTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOKDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uKayitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOKDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eSTOKDataSet4
            // 
            this.eSTOKDataSet4.DataSetName = "ESTOKDataSet4";
            this.eSTOKDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uKayitBindingSource
            // 
            this.uKayitBindingSource.DataMember = "UKayit";
            this.uKayitBindingSource.DataSource = this.eSTOKDataSet4;
            // 
            // uKayitTableAdapter
            // 
            this.uKayitTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKoduDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.sttDataGridViewTextBoxColumn,
            this.urunBilgiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uKayitBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // urunKoduDataGridViewTextBoxColumn
            // 
            this.urunKoduDataGridViewTextBoxColumn.DataPropertyName = "UrunKodu";
            this.urunKoduDataGridViewTextBoxColumn.HeaderText = "UrunKodu";
            this.urunKoduDataGridViewTextBoxColumn.Name = "urunKoduDataGridViewTextBoxColumn";
            this.urunKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // sttDataGridViewTextBoxColumn
            // 
            this.sttDataGridViewTextBoxColumn.DataPropertyName = "Stt";
            this.sttDataGridViewTextBoxColumn.HeaderText = "Stt";
            this.sttDataGridViewTextBoxColumn.Name = "sttDataGridViewTextBoxColumn";
            // 
            // urunBilgiDataGridViewTextBoxColumn
            // 
            this.urunBilgiDataGridViewTextBoxColumn.DataPropertyName = "UrunBilgi";
            this.urunBilgiDataGridViewTextBoxColumn.HeaderText = "UrunBilgi";
            this.urunBilgiDataGridViewTextBoxColumn.Name = "urunBilgiDataGridViewTextBoxColumn";
            // 
            // uKayitBindingSource1
            // 
            this.uKayitBindingSource1.DataMember = "UKayit";
            this.uKayitBindingSource1.DataSource = this.eSTOKDataSet5;
            // 
            // eSTOKDataSet5
            // 
            this.eSTOKDataSet5.DataSetName = "ESTOKDataSet5";
            this.eSTOKDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uKayitTableAdapter1
            // 
            this.uKayitTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(619, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listele";
            this.Text = "Listele";
            this.Load += new System.EventHandler(this.Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eSTOKDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uKayitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOKDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ESTOKDataSet4 eSTOKDataSet4;
        private System.Windows.Forms.BindingSource uKayitBindingSource;
        private ESTOKDataSet4TableAdapters.UKayitTableAdapter uKayitTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ESTOKDataSet5 eSTOKDataSet5;
        private System.Windows.Forms.BindingSource uKayitBindingSource1;
        private ESTOKDataSet5TableAdapters.UKayitTableAdapter uKayitTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBilgiDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
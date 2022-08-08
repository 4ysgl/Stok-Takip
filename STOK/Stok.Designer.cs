
namespace STOK
{
    partial class Stok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok));
            this.DtStok = new System.Windows.Forms.DataGridView();
            this.urunKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBilgiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTOKDataSet6 = new STOK.ESTOKDataSet6();
            this.uKayitTableAdapter = new STOK.ESTOKDataSet6TableAdapters.UKayitTableAdapter();
            this.btnSAz = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOKDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DtStok
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            this.DtStok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DtStok.AutoGenerateColumns = false;
            this.DtStok.BackgroundColor = System.Drawing.Color.Maroon;
            this.DtStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKoduDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.sttDataGridViewTextBoxColumn,
            this.urunBilgiDataGridViewTextBoxColumn});
            this.DtStok.DataSource = this.uKayitBindingSource;
            this.DtStok.Location = new System.Drawing.Point(12, 28);
            this.DtStok.Name = "DtStok";
            this.DtStok.Size = new System.Drawing.Size(639, 287);
            this.DtStok.TabIndex = 0;
            this.DtStok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtStok_CellContentClick);
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
            // uKayitBindingSource
            // 
            this.uKayitBindingSource.DataMember = "UKayit";
            this.uKayitBindingSource.DataSource = this.eSTOKDataSet6;
            // 
            // eSTOKDataSet6
            // 
            this.eSTOKDataSet6.DataSetName = "ESTOKDataSet6";
            this.eSTOKDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uKayitTableAdapter
            // 
            this.uKayitTableAdapter.ClearBeforeFill = true;
            // 
            // btnSAz
            // 
            this.btnSAz.BackColor = System.Drawing.Color.LightGray;
            this.btnSAz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAz.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSAz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSAz.Location = new System.Drawing.Point(12, 333);
            this.btnSAz.Name = "btnSAz";
            this.btnSAz.Size = new System.Drawing.Size(639, 49);
            this.btnSAz.TabIndex = 1;
            this.btnSAz.Text = "AZ OLAN STOK  GETIR";
            this.btnSAz.UseVisualStyleBackColor = false;
            this.btnSAz.Click += new System.EventHandler(this.btnSAz_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(652, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(680, 427);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSAz);
            this.Controls.Add(this.DtStok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stok";
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.Stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOKDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtStok;
        private ESTOKDataSet6 eSTOKDataSet6;
        private System.Windows.Forms.BindingSource uKayitBindingSource;
        private ESTOKDataSet6TableAdapters.UKayitTableAdapter uKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBilgiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSAz;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
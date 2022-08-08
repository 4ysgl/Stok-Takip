
namespace STOK
{
    partial class frmMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenü));
            this.btnÜrünİslem = new System.Windows.Forms.Button();
            this.btnStokTakip = new System.Windows.Forms.Button();
            this.btnUlas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnÜrünİslem
            // 
            this.btnÜrünİslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnÜrünİslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünİslem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜrünİslem.ForeColor = System.Drawing.Color.Silver;
            this.btnÜrünİslem.Location = new System.Drawing.Point(60, 72);
            this.btnÜrünİslem.Name = "btnÜrünİslem";
            this.btnÜrünİslem.Size = new System.Drawing.Size(345, 68);
            this.btnÜrünİslem.TabIndex = 0;
            this.btnÜrünİslem.Text = "ÜRÜN İŞLEMLERİ";
            this.btnÜrünİslem.UseVisualStyleBackColor = false;
            this.btnÜrünİslem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStokTakip
            // 
            this.btnStokTakip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStokTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokTakip.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokTakip.ForeColor = System.Drawing.Color.Silver;
            this.btnStokTakip.Location = new System.Drawing.Point(60, 167);
            this.btnStokTakip.Name = "btnStokTakip";
            this.btnStokTakip.Size = new System.Drawing.Size(345, 68);
            this.btnStokTakip.TabIndex = 0;
            this.btnStokTakip.Text = "STOK TAKİP";
            this.btnStokTakip.UseVisualStyleBackColor = false;
            this.btnStokTakip.Click += new System.EventHandler(this.btnStokTakip_Click);
            // 
            // btnUlas
            // 
            this.btnUlas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUlas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUlas.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUlas.ForeColor = System.Drawing.Color.Silver;
            this.btnUlas.Location = new System.Drawing.Point(60, 267);
            this.btnUlas.Name = "btnUlas";
            this.btnUlas.Size = new System.Drawing.Size(345, 68);
            this.btnUlas.TabIndex = 0;
            this.btnUlas.Text = "BİZE ULAŞIM";
            this.btnUlas.UseVisualStyleBackColor = false;
            this.btnUlas.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(498, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStokTakip);
            this.Controls.Add(this.btnUlas);
            this.Controls.Add(this.btnÜrünİslem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenü";
            this.Text = "frmMenü";
            this.Load += new System.EventHandler(this.frmMenü_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnÜrünİslem;
        private System.Windows.Forms.Button btnStokTakip;
        private System.Windows.Forms.Button btnUlas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
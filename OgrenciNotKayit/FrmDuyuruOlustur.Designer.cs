namespace OgrenciNotKayit
{
    partial class FrmDuyuruOlustur
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
            btnDuyuruEkle = new Button();
            btnDuyuruSil = new Button();
            btnDuyuruGuncelle = new Button();
            rchDuyuru = new RichTextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDuyuruEkle
            // 
            btnDuyuruEkle.Location = new Point(417, 213);
            btnDuyuruEkle.Name = "btnDuyuruEkle";
            btnDuyuruEkle.Size = new Size(131, 53);
            btnDuyuruEkle.TabIndex = 0;
            btnDuyuruEkle.Text = "Ekle";
            btnDuyuruEkle.UseVisualStyleBackColor = true;
            btnDuyuruEkle.Click += btnDuyuruEkle_Click;
            // 
            // btnDuyuruSil
            // 
            btnDuyuruSil.Location = new Point(654, 213);
            btnDuyuruSil.Name = "btnDuyuruSil";
            btnDuyuruSil.Size = new Size(131, 53);
            btnDuyuruSil.TabIndex = 1;
            btnDuyuruSil.Text = "Sil";
            btnDuyuruSil.UseVisualStyleBackColor = true;
            btnDuyuruSil.Click += btnDuyuruSil_Click;
            // 
            // btnDuyuruGuncelle
            // 
            btnDuyuruGuncelle.Location = new Point(899, 213);
            btnDuyuruGuncelle.Name = "btnDuyuruGuncelle";
            btnDuyuruGuncelle.Size = new Size(131, 53);
            btnDuyuruGuncelle.TabIndex = 2;
            btnDuyuruGuncelle.Text = "Güncelle";
            btnDuyuruGuncelle.UseVisualStyleBackColor = true;
            btnDuyuruGuncelle.Click += btnDuyuruGuncelle_Click;
            // 
            // rchDuyuru
            // 
            rchDuyuru.Location = new Point(417, 35);
            rchDuyuru.Name = "rchDuyuru";
            rchDuyuru.Size = new Size(613, 147);
            rchDuyuru.TabIndex = 3;
            rchDuyuru.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1003, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(27, 72);
            label1.Name = "label1";
            label1.Size = new Size(265, 54);
            label1.TabIndex = 5;
            label1.Text = "DUYURULAR";
            // 
            // FrmDuyuruOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 497);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(rchDuyuru);
            Controls.Add(btnDuyuruGuncelle);
            Controls.Add(btnDuyuruSil);
            Controls.Add(btnDuyuruEkle);
            Name = "FrmDuyuruOlustur";
            Text = "FrmDuyuruOlustur";
            Load += FrmDuyuruOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDuyuruEkle;
        private Button btnDuyuruSil;
        private Button btnDuyuruGuncelle;
        private RichTextBox rchDuyuru;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
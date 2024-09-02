namespace OgrenciNotKayit
{
    partial class FrmMesajlar
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
            tabControl = new TabControl();
            tabGelen = new TabPage();
            dgvGelen = new DataGridView();
            tabGiden = new TabPage();
            dgvGiden = new DataGridView();
            groupBox1 = new GroupBox();
            btnGonder = new Button();
            rchMesaj = new RichTextBox();
            label4 = new Label();
            txtKonu = new TextBox();
            txtAlici = new TextBox();
            txtGonderen = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl.SuspendLayout();
            tabGelen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGelen).BeginInit();
            tabGiden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiden).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabGelen);
            tabControl.Controls.Add(tabGiden);
            tabControl.Location = new Point(6, 7);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(988, 308);
            tabControl.TabIndex = 0;
            // 
            // tabGelen
            // 
            tabGelen.Controls.Add(dgvGelen);
            tabGelen.Location = new Point(4, 29);
            tabGelen.Name = "tabGelen";
            tabGelen.Padding = new Padding(3);
            tabGelen.Size = new Size(980, 275);
            tabGelen.TabIndex = 0;
            tabGelen.Text = "Gelen Kutusu";
            tabGelen.UseVisualStyleBackColor = true;
            // 
            // dgvGelen
            // 
            dgvGelen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGelen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGelen.Location = new Point(3, 6);
            dgvGelen.Name = "dgvGelen";
            dgvGelen.RowHeadersWidth = 51;
            dgvGelen.Size = new Size(971, 263);
            dgvGelen.TabIndex = 0;
            // 
            // tabGiden
            // 
            tabGiden.Controls.Add(dgvGiden);
            tabGiden.Location = new Point(4, 29);
            tabGiden.Name = "tabGiden";
            tabGiden.Padding = new Padding(3);
            tabGiden.Size = new Size(980, 275);
            tabGiden.TabIndex = 1;
            tabGiden.Text = "Giden Kutusu";
            tabGiden.UseVisualStyleBackColor = true;
            // 
            // dgvGiden
            // 
            dgvGiden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiden.Location = new Point(7, 6);
            dgvGiden.Name = "dgvGiden";
            dgvGiden.RowHeadersWidth = 51;
            dgvGiden.Size = new Size(967, 263);
            dgvGiden.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGonder);
            groupBox1.Controls.Add(rchMesaj);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtKonu);
            groupBox1.Controls.Add(txtAlici);
            groupBox1.Controls.Add(txtGonderen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 320);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(978, 164);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(858, 56);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(114, 68);
            btnGonder.TabIndex = 8;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // rchMesaj
            // 
            rchMesaj.Location = new Point(539, 32);
            rchMesaj.Name = "rchMesaj";
            rchMesaj.Size = new Size(307, 117);
            rchMesaj.TabIndex = 7;
            rchMesaj.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 32);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 6;
            label4.Text = "Mesaj";
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(108, 122);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(233, 27);
            txtKonu.TabIndex = 5;
            // 
            // txtAlici
            // 
            txtAlici.Location = new Point(108, 75);
            txtAlici.Name = "txtAlici";
            txtAlici.Size = new Size(233, 27);
            txtAlici.TabIndex = 4;
            // 
            // txtGonderen
            // 
            txtGonderen.Location = new Point(108, 31);
            txtGonderen.Name = "txtGonderen";
            txtGonderen.Size = new Size(233, 27);
            txtGonderen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 129);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Konu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 78);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Alıcı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Gönderen";
            // 
            // FrmMesajlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 496);
            Controls.Add(groupBox1);
            Controls.Add(tabControl);
            Name = "FrmMesajlar";
            Text = "FrmMesajlar";
            Load += FrmMesajlar_Load;
            tabControl.ResumeLayout(false);
            tabGelen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGelen).EndInit();
            tabGiden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGiden).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabGelen;
        private TabPage tabGiden;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvGelen;
        private Label label4;
        private TextBox txtKonu;
        private TextBox txtAlici;
        private TextBox txtGonderen;
        private Button btnGonder;
        private RichTextBox rchMesaj;
        private DataGridView dgvGiden;
    }
}
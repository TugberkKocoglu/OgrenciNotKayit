namespace OgrenciNotKayit
{
    partial class FrmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            groupBox1 = new GroupBox();
            TxtOgretmenSifre = new TextBox();
            pictureBox1 = new PictureBox();
            MskOgretmenNumara = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            BtnOgretmenGiris = new Button();
            groupBox2 = new GroupBox();
            TxtOgrenciSifre = new TextBox();
            pictureBox2 = new PictureBox();
            MskOgrenciNumara = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            BtnOgrenciGiris = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(TxtOgretmenSifre);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(MskOgretmenNumara);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnOgretmenGiris);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(31, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1146, 323);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğretmen";
            // 
            // TxtOgretmenSifre
            // 
            TxtOgretmenSifre.Location = new Point(838, 127);
            TxtOgretmenSifre.Name = "TxtOgretmenSifre";
            TxtOgretmenSifre.PasswordChar = '*';
            TxtOgretmenSifre.Size = new Size(198, 27);
            TxtOgretmenSifre.TabIndex = 6;
            TxtOgretmenSifre.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MskOgretmenNumara
            // 
            MskOgretmenNumara.Location = new Point(839, 70);
            MskOgretmenNumara.Mask = "0000";
            MskOgretmenNumara.Name = "MskOgretmenNumara";
            MskOgretmenNumara.Size = new Size(197, 27);
            MskOgretmenNumara.TabIndex = 3;
            MskOgretmenNumara.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(718, 126);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(718, 66);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 1;
            label1.Text = "Numara :";
            // 
            // BtnOgretmenGiris
            // 
            BtnOgretmenGiris.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnOgretmenGiris.Location = new Point(718, 240);
            BtnOgretmenGiris.Name = "BtnOgretmenGiris";
            BtnOgretmenGiris.Size = new Size(350, 60);
            BtnOgretmenGiris.TabIndex = 0;
            BtnOgretmenGiris.Text = "Giriş Yap";
            BtnOgretmenGiris.UseVisualStyleBackColor = true;
            BtnOgretmenGiris.Click += BtnOgretmenGiris_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(TxtOgrenciSifre);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(MskOgrenciNumara);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(BtnOgrenciGiris);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(31, 380);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1146, 323);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Öğrenci";
            // 
            // TxtOgrenciSifre
            // 
            TxtOgrenciSifre.Location = new Point(838, 130);
            TxtOgrenciSifre.Name = "TxtOgrenciSifre";
            TxtOgrenciSifre.PasswordChar = '*';
            TxtOgrenciSifre.Size = new Size(198, 27);
            TxtOgrenciSifre.TabIndex = 7;
            TxtOgrenciSifre.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(75, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(575, 247);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // MskOgrenciNumara
            // 
            MskOgrenciNumara.Location = new Point(839, 70);
            MskOgrenciNumara.Name = "MskOgrenciNumara";
            MskOgrenciNumara.Size = new Size(197, 27);
            MskOgrenciNumara.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(718, 126);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Şifre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(718, 66);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 1;
            label4.Text = "Numara :";
            // 
            // BtnOgrenciGiris
            // 
            BtnOgrenciGiris.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnOgrenciGiris.Location = new Point(718, 240);
            BtnOgrenciGiris.Name = "BtnOgrenciGiris";
            BtnOgrenciGiris.Size = new Size(350, 60);
            BtnOgrenciGiris.TabIndex = 0;
            BtnOgrenciGiris.Text = "Giriş Yap";
            BtnOgrenciGiris.UseVisualStyleBackColor = true;
            BtnOgrenciGiris.Click += BtnOgrenciGiris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 720);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Öğrenci Not Sistemi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button BtnOgretmenGiris;
        private TextBox TxtOgretmenSifre;
        private PictureBox pictureBox1;
        private MaskedTextBox MskOgretmenNumara;
        private GroupBox groupBox2;
        private TextBox TxtOgrenciSifre;
        private PictureBox pictureBox2;
        private MaskedTextBox MskOgrenciNumara;
        private Label label3;
        private Label label4;
        private Button BtnOgrenciGiris;
    }
}

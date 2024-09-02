using System.Data.SqlClient;

namespace OgrenciNotKayit
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();
        public string numara;
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {

            lblNumara.Text = numara;

            SqlCommand command = new SqlCommand("Select * From TblOgrenci where Numara=@numara", context.Connection());
            command.Parameters.AddWithValue("@numara", numara);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblIsim.Text = reader[1] + " " + reader[2];
                pictureBox1.ImageLocation = reader[5].ToString();
            }
            context.Connection().Close();

            SqlCommand secondCommand = new SqlCommand("Select * From TblNotlar where OGRID=(Select ID from TblOgrenci Where NUMARA=@numara)", context.Connection());
            secondCommand.Parameters.AddWithValue("@numara", lblNumara.Text);
            SqlDataReader secondReader = secondCommand.ExecuteReader();
            while (secondReader.Read())
            {
                lblSinav1.Text = secondReader[1].ToString();
                lblSinav2.Text = secondReader[2].ToString();
                lblSinav3.Text = secondReader[3].ToString();
                lblProje.Text = secondReader[4].ToString();
                lblOrt.Text = secondReader[5].ToString();
            }
            context.Connection().Close();

            if (Convert.ToDouble(lblOrt.Text) >= 50)
            {
                lblDurum.Text = "Geçtiniz";
            }
            else
            {
                lblDurum.Text = "Kaldınız.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = lblNumara.Text;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }
    }
}

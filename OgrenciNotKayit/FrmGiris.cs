using System.Data.SqlClient;

namespace OgrenciNotKayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }


        DBContext context = new DBContext();

        private void BtnOgretmenGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MskOgretmenNumara.Text) || string.IsNullOrEmpty(TxtOgretmenSifre.Text))
            {
                MessageBox.Show("Numara ve �ifre K�sm� Bo� B�rak�lamaz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand command = new SqlCommand("Select * from TblOgretmen where NUMARA=@numara and SIFRE=@sifre", context.Connection());
            command.Parameters.AddWithValue("@numara", MskOgretmenNumara.Text);
            command.Parameters.AddWithValue("@sifre", TxtOgretmenSifre.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                FrmOgretmen frm = new FrmOgretmen();
                frm.number = MskOgretmenNumara.Text;
                frm.Show();
                
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Hatal� Numara veya �ifre", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



            context.Connection().Close();
        }

        private void BtnOgrenciGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MskOgrenciNumara.Text) || string.IsNullOrEmpty(TxtOgrenciSifre.Text))
            {
                MessageBox.Show("Numara veya �ifre Alanlar� Bo� B�rak�lamaz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand command = new SqlCommand("Select * from TblOgrenci where NUMARA=@numara and SIFRE=@sifre", context.Connection());
            command.Parameters.AddWithValue("@numara", MskOgrenciNumara.Text);
            command.Parameters.AddWithValue("@sifre",TxtOgrenciSifre.Text);
            SqlDataReader reader=command.ExecuteReader();

            if (reader.Read())
            {
                FrmOgrenci frm = new FrmOgrenci();
                frm.numara = MskOgrenciNumara.Text;
                frm.Show();
                
                this.Hide();
                return;
            }
            MessageBox.Show("Numara veya �ifre Hatal�", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            context.Connection().Close();   
        }




    }
}

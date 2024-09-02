using System.Data;
using System.Data.SqlClient;

namespace OgrenciNotKayit
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        string studentPic = "";
        public string number = "";
        DBContext context = new DBContext();
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            GradeList();
            StudentList();
            LblNumber.Text = number;

            SqlCommand command = new SqlCommand("Select * from TblOgretmen where NUMARA=@numara", context.Connection());
            command.Parameters.AddWithValue("@numara", number);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LblTeachName.Text = reader[1] + " " + reader[2];
            }
            context.Connection().Close();
        }

        void StudentList()
        {
            SqlCommand command = new SqlCommand("Select * from TblOgrenci", context.Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        void GradeList()
        {
            SqlCommand command = new SqlCommand("Execute Ogrenciler", context.Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void BtnChoosePic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            studentPic = openFileDialog1.FileName;
            PicStudent.ImageLocation = studentPic;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TblOgrenci (ad,soyad,numara,sıfre,fotograf) values (@ad,@soyad,@numara,@sıfre,@fotograf)", context.Connection());
            command.Parameters.AddWithValue("@ad", TxtStuName.Text);
            command.Parameters.AddWithValue("@soyad", TxtStuSurname.Text);
            command.Parameters.AddWithValue("@numara", TxtStudentNum.Text);
            command.Parameters.AddWithValue("@sıfre", TxtStuPassword.Text);
            command.Parameters.AddWithValue("@fotograf", studentPic);
            command.ExecuteNonQuery();

            MessageBox.Show("Öğrenci Sisteme Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            context.Connection().Close();
            StudentList();
            GradeList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            TxtStuName.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            TxtStuSurname.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            TxtStudentNum.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            TxtStuPassword.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            PicStudent.ImageLocation = dataGridView1.Rows[choosen].Cells[5].Value.ToString();



            SqlCommand command = new SqlCommand("Select * from TblNotlar where OgrId=(select ID from TblOgrenci Where Numara=@numara)", context.Connection());
            command.Parameters.AddWithValue("@numara", TxtStudentNum.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TxtExam1.Text = reader[1].ToString();
                TxtExam2.Text = reader[2].ToString();
                TxtExam3.Text = reader[3].ToString();
                TxtProject.Text = reader[4].ToString();
                TxtAvg.Text = reader[5].ToString();
                TxtPass.Text = reader[6].ToString();
            }
            context.Connection().Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update TblOgrenci set ad=@ad,soyad=@soyad,SIFRE=@sifre,fotograf=@fotograf where numara=@numara", context.Connection());
            command.Parameters.AddWithValue("@ad", TxtStuName.Text);
            command.Parameters.AddWithValue("@soyad", TxtStuSurname.Text);
            command.Parameters.AddWithValue("@sifre", TxtStuPassword.Text);
            command.Parameters.AddWithValue("@numara", TxtStudentNum.Text);
            command.Parameters.AddWithValue("@fotograf", studentPic);
            command.ExecuteNonQuery();




            SqlCommand commandNote = new SqlCommand("Update TblNotlar set SINAV1=@sinav1,SINAV2=@sinav2,SINAV3=@sinav3,proje=@proje,ortalama=@ortalama,durum=@durum where OGRID=(select ID from TblOgrenci where numara=@numara)", context.Connection());
            commandNote.Parameters.AddWithValue("@sinav1", TxtExam1.Text);
            commandNote.Parameters.AddWithValue("@sinav2", TxtExam2.Text);
            commandNote.Parameters.AddWithValue("@sinav3", TxtExam3.Text);
            commandNote.Parameters.AddWithValue("@proje", TxtProject.Text);
            commandNote.Parameters.AddWithValue("@ortalama", Convert.ToDecimal(TxtAvg.Text));
            commandNote.Parameters.AddWithValue("@durum", TxtPass.Text);
            commandNote.Parameters.AddWithValue("@numara", TxtStudentNum.Text);
            commandNote.ExecuteNonQuery();

            MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            context.Connection().Close();
            StudentList();
            GradeList();


        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, proje, ortalama;
            sinav1 = Convert.ToDouble(TxtExam1.Text);
            sinav2 = Convert.ToDouble(TxtExam2.Text);
            sinav3 = Convert.ToDouble(TxtExam3.Text);
            proje = Convert.ToDouble(TxtProject.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            TxtAvg.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                TxtPass.Text = "True";
            }
            else
            {
                TxtPass.Text = "False";
            }
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            FrmDuyuruOlustur frm = new FrmDuyuruOlustur();
            frm.Show();
        }

        private void btnDuyuruList_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void btnMesajlar_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = LblNumber.Text;
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result==DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayit
{
    public partial class FrmDuyuruOlustur : Form
    {
        public FrmDuyuruOlustur()
        {
            InitializeComponent();
        }

        string id;
        DBContext context = new DBContext();

        void Listele()
        {
            SqlCommand command = new SqlCommand("Select * from TblDuyurular", context.Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void FrmDuyuruOlustur_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDuyuruEkle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into TblDuyurular (ICERIK) values (@icerik)", context.Connection());
            command.Parameters.AddWithValue("@icerik", rchDuyuru.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            context.Connection().Close();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            rchDuyuru.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            this.Text = id;
        }

        private void btnDuyuruSil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from TblDuyurular where ID=@id", context.Connection());
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            MessageBox.Show("Duyuru Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            context.Connection().Close();
            Listele();
        }

        private void btnDuyuruGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update TblDuyurular set ICERIK=@icerik where ID=@id", context.Connection());
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@icerik", rchDuyuru.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Duyuru Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            context.Connection().Close();
            Listele();
        }
    }
}

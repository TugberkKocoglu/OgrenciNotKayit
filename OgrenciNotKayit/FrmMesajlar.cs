using System.Data;
using System.Data.SqlClient;

namespace OgrenciNotKayit
{
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();
        public string numara;
        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            txtGonderen.Text = numara;
            GelenListesi();
            GidenListesi();
        }

        void GelenListesi()
        {
            SqlCommand command = new SqlCommand("Select * from TblMesajlar Where Alıcı=@alici", context.Connection());
            command.Parameters.AddWithValue("@alici", numara);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvGelen.DataSource = dataTable;
            dgvGelen.Columns["ID"].Visible = false;

        }

        void GidenListesi()
        {
            SqlCommand command = new SqlCommand("Select * from TblMesajlar Where Gonderen=@gonderen", context.Connection());
            command.Parameters.AddWithValue("@gonderen", numara);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvGiden.DataSource = dataTable;
            dgvGiden.Columns["ID"].Visible=false;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into TblMesajlar (GONDEREN,ALICI,BASLIK,ICERIK) values (@gonderen,@alici,@baslik,@icerik)",context.Connection());
            command.Parameters.AddWithValue("@gonderen",txtGonderen.Text);
            command.Parameters.AddWithValue("@alici", txtAlici.Text);
            command.Parameters.AddWithValue("@baslik", txtKonu.Text);
            command.Parameters.AddWithValue("@icerik", rchMesaj.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Mesajınız İletildi ... ","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            context.Connection().Close();
            GelenListesi();
            GidenListesi();

        }
    }
}

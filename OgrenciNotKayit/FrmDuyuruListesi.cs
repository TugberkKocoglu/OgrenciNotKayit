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
    public partial class FrmDuyuruListesi : Form
    {
        public FrmDuyuruListesi()
        {
            InitializeComponent();
        }

        DBContext context = new DBContext();
        private void FrmDuyuruListesi_Load(object sender, EventArgs e)
        {
            ListBox lst = new ListBox();
            Point lstKonum = new Point(10,10);
            lst.Name = "ListBox1";
            lst.Height = 250;
            lst.Width = 450;
            lst.Font = new Font("Gergia", 14, FontStyle.Regular);
            lst.Location= lstKonum;
            this.Controls.Add(lst);

            SqlCommand command = new SqlCommand("Select * from TblDuyurular",context.Connection());
            SqlDataReader reader= command.ExecuteReader();
            while (reader.Read())
            {
                lst.Items.Add(" * " + reader[1]);
            }
            context.Connection().Close();

        }
    }
}

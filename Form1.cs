using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace veterinarske_ordinacije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=ercqedby;" + "Password=GtZ43Cgtya5QVYjQLsVKUw8TUX8elf0k; Database=ercqedby;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT posta, ime FROM kraji", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string posta = reader.GetString(0);
                    string ime = reader.GetString(1);
                    listBoxKraji.Items.Add(ime + ", " + posta);
                }
                con.Close();
            }
        }
    }
}

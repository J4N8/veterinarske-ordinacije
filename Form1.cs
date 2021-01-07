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
        private string baza = "Server=rogue.db.elephantsql.com; User Id=ercqedby;" + "Password=GtZ43Cgtya5QVYjQLsVKUw8TUX8elf0k; Database=ercqedby;";
        public Form1()
        {
            InitializeComponent();
            
        }        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Displays all kraji in list box
            listBoxOrdinacije.Items.Clear();
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisKraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string posta = reader.GetString(1);
                    listBoxKraji.Items.Add(ime + ", " + posta);
                }
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lists all ordinacije in ordinacije list box
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisOrdinacije()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string naslov = reader.GetString(1);
                    string kraj = reader.GetString(2);
                    listBoxOrdinacije.Items.Add(ime + ", " + naslov + ", " + kraj);
                }
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Searches all ordinacije which are from kraj
            listBoxOrdinacije.Items.Clear();
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisOrdinacijeIzKraja('" + comboBoxKraji.Text + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string naslov = reader.GetString(1);
                    string kraj = reader.GetString(2);
                    listBoxOrdinacije.Items.Add(ime + ", " + naslov + ", " + kraj);
                }
                con.Close();
            }
        }
    }
}

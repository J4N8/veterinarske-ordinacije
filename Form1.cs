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

        private void ResetDefault()
        {
            listBoxKraji.Items.Clear();
            listBoxOrdinacije.Items.Clear();
            listBoxZaposleni.Items.Clear();
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
                    listBoxOrdinacije.Items.Add(ime + " | " + naslov + ", " + kraj);
                }
                con.Close();
            }

            //Lists all zaposleni in zaposleni list box
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisZaposleni()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string priimek = reader.GetString(1);
                    string ordinacija = reader.GetString(2);
                    string kraj = reader.GetString(3);
                    listBoxZaposleni.Items.Add(ime + ", " + priimek + " | " + ordinacija + ", " + kraj);
                }
                con.Close();
            }

            //Lists all kraji in kraji combo box
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisKraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string posta = reader.GetString(1);
                    comboBoxKraji.Items.Add(ime + ", " + posta);
                }
                con.Close();
            }

            //Displays all kraji in list box
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetDefault();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Searches all ordinacije which are from kraj
            listBoxOrdinacije.Items.Clear();
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisOrdinacijeIzKraja('" + comboBoxKraji.Text.Remove(comboBoxKraji.Text.Length - 4) + "')", con);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDefault();
        }
    }
}

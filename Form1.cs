﻿using System;
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
        public static readonly string baza = "Server=rogue.db.elephantsql.com; User Id=ercqedby;" + "Password=GtZ43Cgtya5QVYjQLsVKUw8TUX8elf0k; Database=ercqedby;";
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
                    comboBoxOrdinacija.Items.Add(ime + " | " + naslov + ", " + kraj);
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

            //Lists all kraji in kraji combo box & kraji list box
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
                    comboBoxKraj.Items.Add(ime + ", " + posta);
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
            //set font and background color from database
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM getSettings()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string backgroundColor = reader.GetString(0);
                    string fontColor = reader.GetString(1);
                    this.BackColor = Color.FromName(backgroundColor);
                    this.ForeColor = Color.FromName(fontColor);
                }
                con.Close();
            }
            ResetDefault();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Searches all ordinacije which are from kraj
            listBoxOrdinacije.Items.Clear();
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisOrdinacijeIzKraja('" + comboBoxKraji.Text.Substring(comboBoxKraji.Text.Length - 4) + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string naslov = reader.GetString(1);
                    //string kraj = reader.GetString(2);
                    listBoxOrdinacije.Items.Add(ime + ", " + naslov);// + ", " + kraj);
                }
                con.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDefault();
        }

        private void comboBoxKraji_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enables the search button when something is selected to search
            btnSearch.Enabled = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Form settingsForm = new Settings();
            settingsForm.Show();
        }

        private void btnOrdinacijeVnos_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vnosOrdinacija('" + textBoxOrdinacijaIme.Text + "', '" + textBoxOrdinacijaNaslov.Text + "', '" + comboBoxKraj.Text.Substring(comboBoxKraj.Text.Length - 4) + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnZaposleniVnos_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vnosZaposleni('" + textBoxZaposleniIme.Text + "', '" + textBoxZaposleniPriimek.Text + "', '" + dateTimePickerDatumRoj.Value.Date.ToString("yyyy-MM-dd") + "', '" + comboBoxOrdinacija.Text.Split('|')[0].Trim() + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Form LoginForm = new Login();
            LoginForm.Show();
        }

        private void KrajVnosButton_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vnosKrajDrzava('" + KrajTextBox.Text + "', '" + PostaTextBox.Text + "', '" + DrzavaTextBox.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }
        }

        private void listBoxOrdinacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fills the fields for edit
            textBoxOrdinacijaIme.Text = listBoxOrdinacije.SelectedItem.ToString().Split('|')[0].Trim();
            textBoxOrdinacijaNaslov.Text = listBoxOrdinacije.SelectedItem.ToString().Split('|')[1].Split(',')[0].Trim();
            comboBoxKraj.Text = listBoxOrdinacije.SelectedItem.ToString().Split(',')[1].Trim();
        }

        private void listBoxZaposleni_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fills the fields for edit
            textBoxZaposleniIme.Text = listBoxZaposleni.SelectedItem.ToString().Split(',')[0].Trim();
            textBoxZaposleniPriimek.Text = listBoxZaposleni.SelectedItem.ToString().Split(',')[1].Split('|')[0].Trim();
            comboBoxOrdinacija.Text = listBoxZaposleni.SelectedItem.ToString().Split('|')[1].Split(',')[0].Trim();
        }

        private void listBoxKraji_SelectedIndexChanged(object sender, EventArgs e)
        {
            KrajTextBox.Text = listBoxKraji.SelectedItem.ToString().Split(',')[0].Trim();
            PostaTextBox.Text = listBoxKraji.SelectedItem.ToString().Split(',')[1].Trim();
        }
    }
}

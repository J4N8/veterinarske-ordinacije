using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veterinarske_ordinacije
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //set font and background color from database
            using (NpgsqlConnection con = new NpgsqlConnection(Form1.baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM getSettings()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string backgroundColor = reader.GetString(0);
                    string fontColor = reader.GetString(1);
                    this.BackColor = Color.FromName(backgroundColor);
                    BackgroundColorComboBox.SelectedItem = backgroundColor;
                    this.ForeColor = Color.FromName(fontColor);
                    FontColorComboBox.SelectedItem = fontColor;
                }
                con.Close();
            }
        }
    }
}

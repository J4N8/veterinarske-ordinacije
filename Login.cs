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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool login = false;
            using (NpgsqlConnection con = new NpgsqlConnection(Form1.baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM login('" + ImeTextBox.Text + "', '" + GesloTextBox.Text + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    login = reader.GetBoolean(0);
                }
                con.Close();
            }

            if (login)
            {
                MessageBox.Show("Login successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password. Try again!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
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
                    this.ForeColor = Color.FromName(fontColor);
                }
                con.Close();
            }
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Form1.baza))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM changePassword('" + ImeTextBox.Text + "', '" + GesloTextBox.Text + "', '" + NewPassTextBox.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

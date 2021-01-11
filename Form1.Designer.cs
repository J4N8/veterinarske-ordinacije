
namespace veterinarske_ordinacije
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxKraji = new System.Windows.Forms.ListBox();
            this.listBoxOrdinacije = new System.Windows.Forms.ListBox();
            this.comboBoxKraji = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBoxZaposleni = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOrdinacije = new System.Windows.Forms.TabPage();
            this.tabPageZaposleni = new System.Windows.Forms.TabPage();
            this.comboBoxKraj = new System.Windows.Forms.ComboBox();
            this.textBoxOrdinacijaIme = new System.Windows.Forms.TextBox();
            this.textBoxOrdinacijaNaslov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrdinacijeVnos = new System.Windows.Forms.Button();
            this.btnOrdinacijeUpdate = new System.Windows.Forms.Button();
            this.btnZaposleniUpdate = new System.Windows.Forms.Button();
            this.btnZaposleniVnos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxZaposleniPriimek = new System.Windows.Forms.TextBox();
            this.textBoxZaposleniIme = new System.Windows.Forms.TextBox();
            this.comboBoxOrdinacija = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumRoj = new System.Windows.Forms.DateTimePicker();
            this.groupBoxSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageOrdinacije.SuspendLayout();
            this.tabPageZaposleni.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxKraji
            // 
            this.listBoxKraji.FormattingEnabled = true;
            this.listBoxKraji.ItemHeight = 20;
            this.listBoxKraji.Location = new System.Drawing.Point(568, 78);
            this.listBoxKraji.Name = "listBoxKraji";
            this.listBoxKraji.Size = new System.Drawing.Size(550, 404);
            this.listBoxKraji.TabIndex = 0;
            // 
            // listBoxOrdinacije
            // 
            this.listBoxOrdinacije.FormattingEnabled = true;
            this.listBoxOrdinacije.ItemHeight = 20;
            this.listBoxOrdinacije.Location = new System.Drawing.Point(12, 78);
            this.listBoxOrdinacije.Name = "listBoxOrdinacije";
            this.listBoxOrdinacije.Size = new System.Drawing.Size(550, 404);
            this.listBoxOrdinacije.TabIndex = 2;
            // 
            // comboBoxKraji
            // 
            this.comboBoxKraji.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxKraji.FormattingEnabled = true;
            this.comboBoxKraji.Location = new System.Drawing.Point(48, 19);
            this.comboBoxKraji.Name = "comboBoxKraji";
            this.comboBoxKraji.Size = new System.Drawing.Size(409, 28);
            this.comboBoxKraji.Sorted = true;
            this.comboBoxKraji.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kraj";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.comboBoxKraji);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(544, 60);
            this.groupBoxSearch.TabIndex = 5;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(463, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBoxZaposleni
            // 
            this.listBoxZaposleni.FormattingEnabled = true;
            this.listBoxZaposleni.ItemHeight = 20;
            this.listBoxZaposleni.Location = new System.Drawing.Point(12, 488);
            this.listBoxZaposleni.Name = "listBoxZaposleni";
            this.listBoxZaposleni.Size = new System.Drawing.Size(550, 404);
            this.listBoxZaposleni.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOrdinacije);
            this.tabControl1.Controls.Add(this.tabPageZaposleni);
            this.tabControl1.Location = new System.Drawing.Point(568, 488);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 404);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageOrdinacije
            // 
            this.tabPageOrdinacije.Controls.Add(this.btnOrdinacijeUpdate);
            this.tabPageOrdinacije.Controls.Add(this.btnOrdinacijeVnos);
            this.tabPageOrdinacije.Controls.Add(this.label4);
            this.tabPageOrdinacije.Controls.Add(this.label3);
            this.tabPageOrdinacije.Controls.Add(this.label2);
            this.tabPageOrdinacije.Controls.Add(this.textBoxOrdinacijaNaslov);
            this.tabPageOrdinacije.Controls.Add(this.textBoxOrdinacijaIme);
            this.tabPageOrdinacije.Controls.Add(this.comboBoxKraj);
            this.tabPageOrdinacije.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrdinacije.Name = "tabPageOrdinacije";
            this.tabPageOrdinacije.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrdinacije.Size = new System.Drawing.Size(542, 371);
            this.tabPageOrdinacije.TabIndex = 0;
            this.tabPageOrdinacije.Text = "Ordinacije";
            this.tabPageOrdinacije.UseVisualStyleBackColor = true;
            // 
            // tabPageZaposleni
            // 
            this.tabPageZaposleni.Controls.Add(this.dateTimePickerDatumRoj);
            this.tabPageZaposleni.Controls.Add(this.label8);
            this.tabPageZaposleni.Controls.Add(this.btnZaposleniUpdate);
            this.tabPageZaposleni.Controls.Add(this.btnZaposleniVnos);
            this.tabPageZaposleni.Controls.Add(this.label5);
            this.tabPageZaposleni.Controls.Add(this.label6);
            this.tabPageZaposleni.Controls.Add(this.label7);
            this.tabPageZaposleni.Controls.Add(this.textBoxZaposleniPriimek);
            this.tabPageZaposleni.Controls.Add(this.textBoxZaposleniIme);
            this.tabPageZaposleni.Controls.Add(this.comboBoxOrdinacija);
            this.tabPageZaposleni.Location = new System.Drawing.Point(4, 29);
            this.tabPageZaposleni.Name = "tabPageZaposleni";
            this.tabPageZaposleni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZaposleni.Size = new System.Drawing.Size(542, 371);
            this.tabPageZaposleni.TabIndex = 1;
            this.tabPageZaposleni.Text = "Zaposleni";
            this.tabPageZaposleni.UseVisualStyleBackColor = true;
            // 
            // comboBoxKraj
            // 
            this.comboBoxKraj.FormattingEnabled = true;
            this.comboBoxKraj.Location = new System.Drawing.Point(76, 104);
            this.comboBoxKraj.Name = "comboBoxKraj";
            this.comboBoxKraj.Size = new System.Drawing.Size(460, 28);
            this.comboBoxKraj.TabIndex = 0;
            // 
            // textBoxOrdinacijaIme
            // 
            this.textBoxOrdinacijaIme.Location = new System.Drawing.Point(76, 4);
            this.textBoxOrdinacijaIme.Name = "textBoxOrdinacijaIme";
            this.textBoxOrdinacijaIme.Size = new System.Drawing.Size(460, 26);
            this.textBoxOrdinacijaIme.TabIndex = 1;
            // 
            // textBoxOrdinacijaNaslov
            // 
            this.textBoxOrdinacijaNaslov.Location = new System.Drawing.Point(76, 50);
            this.textBoxOrdinacijaNaslov.Name = "textBoxOrdinacijaNaslov";
            this.textBoxOrdinacijaNaslov.Size = new System.Drawing.Size(460, 26);
            this.textBoxOrdinacijaNaslov.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naslov: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kraj: ";
            // 
            // btnOrdinacijeVnos
            // 
            this.btnOrdinacijeVnos.AutoSize = true;
            this.btnOrdinacijeVnos.Location = new System.Drawing.Point(76, 235);
            this.btnOrdinacijeVnos.Name = "btnOrdinacijeVnos";
            this.btnOrdinacijeVnos.Size = new System.Drawing.Size(75, 30);
            this.btnOrdinacijeVnos.TabIndex = 6;
            this.btnOrdinacijeVnos.Text = "Vnos";
            this.btnOrdinacijeVnos.UseVisualStyleBackColor = true;
            // 
            // btnOrdinacijeUpdate
            // 
            this.btnOrdinacijeUpdate.AutoSize = true;
            this.btnOrdinacijeUpdate.Location = new System.Drawing.Point(235, 235);
            this.btnOrdinacijeUpdate.Name = "btnOrdinacijeUpdate";
            this.btnOrdinacijeUpdate.Size = new System.Drawing.Size(85, 30);
            this.btnOrdinacijeUpdate.TabIndex = 7;
            this.btnOrdinacijeUpdate.Text = "Posodobi";
            this.btnOrdinacijeUpdate.UseVisualStyleBackColor = true;
            // 
            // btnZaposleniUpdate
            // 
            this.btnZaposleniUpdate.AutoSize = true;
            this.btnZaposleniUpdate.Location = new System.Drawing.Point(235, 243);
            this.btnZaposleniUpdate.Name = "btnZaposleniUpdate";
            this.btnZaposleniUpdate.Size = new System.Drawing.Size(85, 30);
            this.btnZaposleniUpdate.TabIndex = 15;
            this.btnZaposleniUpdate.Text = "Posodobi";
            this.btnZaposleniUpdate.UseVisualStyleBackColor = true;
            // 
            // btnZaposleniVnos
            // 
            this.btnZaposleniVnos.AutoSize = true;
            this.btnZaposleniVnos.Location = new System.Drawing.Point(76, 243);
            this.btnZaposleniVnos.Name = "btnZaposleniVnos";
            this.btnZaposleniVnos.Size = new System.Drawing.Size(75, 30);
            this.btnZaposleniVnos.TabIndex = 14;
            this.btnZaposleniVnos.Text = "Vnos";
            this.btnZaposleniVnos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datum rojstva: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Priimek: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ime: ";
            // 
            // textBoxZaposleniPriimek
            // 
            this.textBoxZaposleniPriimek.Location = new System.Drawing.Point(117, 55);
            this.textBoxZaposleniPriimek.Name = "textBoxZaposleniPriimek";
            this.textBoxZaposleniPriimek.Size = new System.Drawing.Size(416, 26);
            this.textBoxZaposleniPriimek.TabIndex = 10;
            // 
            // textBoxZaposleniIme
            // 
            this.textBoxZaposleniIme.Location = new System.Drawing.Point(117, 9);
            this.textBoxZaposleniIme.Name = "textBoxZaposleniIme";
            this.textBoxZaposleniIme.Size = new System.Drawing.Size(416, 26);
            this.textBoxZaposleniIme.TabIndex = 9;
            // 
            // comboBoxOrdinacija
            // 
            this.comboBoxOrdinacija.FormattingEnabled = true;
            this.comboBoxOrdinacija.Location = new System.Drawing.Point(117, 153);
            this.comboBoxOrdinacija.Name = "comboBoxOrdinacija";
            this.comboBoxOrdinacija.Size = new System.Drawing.Size(416, 28);
            this.comboBoxOrdinacija.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ordinacija: ";
            // 
            // dateTimePickerDatumRoj
            // 
            this.dateTimePickerDatumRoj.Location = new System.Drawing.Point(117, 107);
            this.dateTimePickerDatumRoj.Name = "dateTimePickerDatumRoj";
            this.dateTimePickerDatumRoj.Size = new System.Drawing.Size(416, 26);
            this.dateTimePickerDatumRoj.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1149, 915);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxZaposleni);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.listBoxOrdinacije);
            this.Controls.Add(this.listBoxKraji);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageOrdinacije.ResumeLayout(false);
            this.tabPageOrdinacije.PerformLayout();
            this.tabPageZaposleni.ResumeLayout(false);
            this.tabPageZaposleni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKraji;
        private System.Windows.Forms.ListBox listBoxOrdinacije;
        private System.Windows.Forms.ComboBox comboBoxKraji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBoxZaposleni;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOrdinacije;
        private System.Windows.Forms.TabPage tabPageZaposleni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrdinacijaNaslov;
        private System.Windows.Forms.TextBox textBoxOrdinacijaIme;
        private System.Windows.Forms.ComboBox comboBoxKraj;
        private System.Windows.Forms.Button btnOrdinacijeUpdate;
        private System.Windows.Forms.Button btnOrdinacijeVnos;
        private System.Windows.Forms.Button btnZaposleniUpdate;
        private System.Windows.Forms.Button btnZaposleniVnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxZaposleniPriimek;
        private System.Windows.Forms.TextBox textBoxZaposleniIme;
        private System.Windows.Forms.ComboBox comboBoxOrdinacija;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRoj;
    }
}


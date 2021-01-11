
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxOrdinacijaIme = new System.Windows.Forms.TextBox();
            this.textBoxOrdinacijaNaslov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrdinacijeVnos = new System.Windows.Forms.Button();
            this.btnOrdinacijeUpdate = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageOrdinacije.SuspendLayout();
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
            this.tabPageOrdinacije.Controls.Add(this.comboBox1);
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
            this.tabPageZaposleni.Location = new System.Drawing.Point(4, 29);
            this.tabPageZaposleni.Name = "tabPageZaposleni";
            this.tabPageZaposleni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZaposleni.Size = new System.Drawing.Size(536, 251);
            this.tabPageZaposleni.TabIndex = 1;
            this.tabPageZaposleni.Text = "Zaposleni";
            this.tabPageZaposleni.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // textBoxOrdinacijaIme
            // 
            this.textBoxOrdinacijaIme.Location = new System.Drawing.Point(76, 4);
            this.textBoxOrdinacijaIme.Name = "textBoxOrdinacijaIme";
            this.textBoxOrdinacijaIme.Size = new System.Drawing.Size(234, 26);
            this.textBoxOrdinacijaIme.TabIndex = 1;
            // 
            // textBoxOrdinacijaNaslov
            // 
            this.textBoxOrdinacijaNaslov.Location = new System.Drawing.Point(76, 50);
            this.textBoxOrdinacijaNaslov.Name = "textBoxOrdinacijaNaslov";
            this.textBoxOrdinacijaNaslov.Size = new System.Drawing.Size(234, 26);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOrdinacijeUpdate;
        private System.Windows.Forms.Button btnOrdinacijeVnos;
    }
}


﻿
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listBoxOrdinacije = new System.Windows.Forms.ListBox();
            this.comboBoxKraji = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxKraji
            // 
            this.listBoxKraji.FormattingEnabled = true;
            this.listBoxKraji.ItemHeight = 20;
            this.listBoxKraji.Location = new System.Drawing.Point(856, 407);
            this.listBoxKraji.Name = "listBoxKraji";
            this.listBoxKraji.Size = new System.Drawing.Size(544, 284);
            this.listBoxKraji.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(1072, 532);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listBoxOrdinacije
            // 
            this.listBoxOrdinacije.FormattingEnabled = true;
            this.listBoxOrdinacije.ItemHeight = 20;
            this.listBoxOrdinacije.Location = new System.Drawing.Point(12, 78);
            this.listBoxOrdinacije.Name = "listBoxOrdinacije";
            this.listBoxOrdinacije.Size = new System.Drawing.Size(544, 284);
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
            this.groupBoxSearch.Controls.Add(this.comboBoxKraji);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(544, 60);
            this.groupBoxSearch.TabIndex = 5;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1412, 703);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.listBoxOrdinacije);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listBoxKraji);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKraji;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox listBoxOrdinacije;
        private System.Windows.Forms.ComboBox comboBoxKraji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
    }
}


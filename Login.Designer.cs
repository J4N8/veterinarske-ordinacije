
namespace veterinarske_ordinacije
{
    partial class Login
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.ImeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GesloTextBox = new System.Windows.Forms.TextBox();
            this.NewPassTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.Location = new System.Drawing.Point(17, 77);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 30);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ImeTextBox
            // 
            this.ImeTextBox.Location = new System.Drawing.Point(78, 13);
            this.ImeTextBox.Name = "ImeTextBox";
            this.ImeTextBox.Size = new System.Drawing.Size(278, 26);
            this.ImeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geslo: ";
            // 
            // GesloTextBox
            // 
            this.GesloTextBox.Location = new System.Drawing.Point(78, 45);
            this.GesloTextBox.Name = "GesloTextBox";
            this.GesloTextBox.Size = new System.Drawing.Size(278, 26);
            this.GesloTextBox.TabIndex = 3;
            // 
            // NewPassTextBox
            // 
            this.NewPassTextBox.Location = new System.Drawing.Point(114, 123);
            this.NewPassTextBox.Name = "NewPassTextBox";
            this.NewPassTextBox.Size = new System.Drawing.Size(278, 26);
            this.NewPassTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Novo geslo: ";
            // 
            // ResetPasswordButton
            // 
            this.ResetPasswordButton.AutoSize = true;
            this.ResetPasswordButton.Location = new System.Drawing.Point(17, 159);
            this.ResetPasswordButton.Name = "ResetPasswordButton";
            this.ResetPasswordButton.Size = new System.Drawing.Size(147, 30);
            this.ResetPasswordButton.TabIndex = 7;
            this.ResetPasswordButton.Text = "Change password";
            this.ResetPasswordButton.UseVisualStyleBackColor = true;
            this.ResetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetPasswordButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPassTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GesloTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImeTextBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox ImeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GesloTextBox;
        private System.Windows.Forms.TextBox NewPassTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetPasswordButton;
    }
}

namespace veterinarske_ordinacije
{
    partial class Settings
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
            this.BackgroundColorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextColorLabel = new System.Windows.Forms.Label();
            this.TextColorComboBox = new System.Windows.Forms.ComboBox();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackgroundColorComboBox
            // 
            this.BackgroundColorComboBox.FormattingEnabled = true;
            this.BackgroundColorComboBox.Location = new System.Drawing.Point(160, 10);
            this.BackgroundColorComboBox.Name = "BackgroundColorComboBox";
            this.BackgroundColorComboBox.Size = new System.Drawing.Size(247, 28);
            this.BackgroundColorComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Background color: ";
            // 
            // TextColorLabel
            // 
            this.TextColorLabel.AutoSize = true;
            this.TextColorLabel.Location = new System.Drawing.Point(13, 51);
            this.TextColorLabel.Name = "TextColorLabel";
            this.TextColorLabel.Size = new System.Drawing.Size(85, 20);
            this.TextColorLabel.TabIndex = 3;
            this.TextColorLabel.Text = "Text color: ";
            // 
            // TextColorComboBox
            // 
            this.TextColorComboBox.FormattingEnabled = true;
            this.TextColorComboBox.Location = new System.Drawing.Point(160, 48);
            this.TextColorComboBox.Name = "TextColorComboBox";
            this.TextColorComboBox.Size = new System.Drawing.Size(247, 28);
            this.TextColorComboBox.TabIndex = 2;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.AutoSize = true;
            this.SaveSettingsButton.Location = new System.Drawing.Point(17, 99);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(75, 30);
            this.SaveSettingsButton.TabIndex = 4;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.TextColorLabel);
            this.Controls.Add(this.TextColorComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackgroundColorComboBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BackgroundColorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextColorLabel;
        private System.Windows.Forms.ComboBox TextColorComboBox;
        private System.Windows.Forms.Button SaveSettingsButton;
    }
}
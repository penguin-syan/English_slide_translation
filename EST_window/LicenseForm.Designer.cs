
namespace EST_window
{
    partial class LicenseForm
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
            this.closeLicenseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ossNameCombo = new System.Windows.Forms.ComboBox();
            this.licenseViewTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeLicenseButton
            // 
            this.closeLicenseButton.Location = new System.Drawing.Point(578, 363);
            this.closeLicenseButton.Name = "closeLicenseButton";
            this.closeLicenseButton.Size = new System.Drawing.Size(75, 23);
            this.closeLicenseButton.TabIndex = 0;
            this.closeLicenseButton.Text = "閉じる";
            this.closeLicenseButton.UseVisualStyleBackColor = true;
            this.closeLicenseButton.Click += new System.EventHandler(this.closeLicenseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "本ソフトウェアは以下のOSSを利用して作成しています．";
            // 
            // ossNameCombo
            // 
            this.ossNameCombo.FormattingEnabled = true;
            this.ossNameCombo.Items.AddRange(new object[] {
            "DeepLcom / deepl-dotnet",
            "Google Cloud Vision V1",
            "Newtonsoft.Json"});
            this.ossNameCombo.Location = new System.Drawing.Point(15, 56);
            this.ossNameCombo.Name = "ossNameCombo";
            this.ossNameCombo.Size = new System.Drawing.Size(261, 20);
            this.ossNameCombo.TabIndex = 2;
            this.ossNameCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // licenseViewTextBox
            // 
            this.licenseViewTextBox.Location = new System.Drawing.Point(15, 103);
            this.licenseViewTextBox.Name = "licenseViewTextBox";
            this.licenseViewTextBox.Size = new System.Drawing.Size(638, 254);
            this.licenseViewTextBox.TabIndex = 3;
            this.licenseViewTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ライセンス";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "ソフトウェア名";
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.licenseViewTextBox);
            this.Controls.Add(this.ossNameCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeLicenseButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseForm";
            this.Text = "ライセンス";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeLicenseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ossNameCombo;
        private System.Windows.Forms.RichTextBox licenseViewTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

namespace EST_window
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.apiKey_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GCkey_reference = new System.Windows.Forms.Button();
            this.GCkey_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Google Cloud JSON Key File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "DeepL API Key";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(292, 120);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "閉じる";
            this.close_button.UseVisualStyleBackColor = true;
            // 
            // apiKey_textBox
            // 
            this.apiKey_textBox.Location = new System.Drawing.Point(32, 71);
            this.apiKey_textBox.Name = "apiKey_textBox";
            this.apiKey_textBox.Size = new System.Drawing.Size(244, 19);
            this.apiKey_textBox.TabIndex = 3;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(210, 120);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "保存";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "DeepL API Key type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DeepL API Free",
            "DeepL API Pro"});
            this.comboBox1.Location = new System.Drawing.Point(32, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GCkey_reference
            // 
            this.GCkey_reference.Location = new System.Drawing.Point(292, 22);
            this.GCkey_reference.Name = "GCkey_reference";
            this.GCkey_reference.Size = new System.Drawing.Size(75, 23);
            this.GCkey_reference.TabIndex = 9;
            this.GCkey_reference.Text = "参照";
            this.GCkey_reference.UseVisualStyleBackColor = true;
            this.GCkey_reference.Click += new System.EventHandler(this.GCkey_reference_Click);
            // 
            // GCkey_textBox
            // 
            this.GCkey_textBox.Location = new System.Drawing.Point(32, 24);
            this.GCkey_textBox.Name = "GCkey_textBox";
            this.GCkey_textBox.Size = new System.Drawing.Size(244, 19);
            this.GCkey_textBox.TabIndex = 10;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 153);
            this.Controls.Add(this.GCkey_textBox);
            this.Controls.Add(this.GCkey_reference);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.apiKey_textBox);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.TextBox apiKey_textBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button GCkey_reference;
        private System.Windows.Forms.TextBox GCkey_textBox;
    }
}
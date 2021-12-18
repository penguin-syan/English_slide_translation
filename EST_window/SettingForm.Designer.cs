
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
            this.deeplKey_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GCkey_reference = new System.Windows.Forms.Button();
            this.GCkey_textBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.deepl = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.autoTranslateCheckbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sourceLangBox = new System.Windows.Forms.ComboBox();
            this.targetLangBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.APIkey = new System.Windows.Forms.TabPage();
            this.deepl_usageLabel = new System.Windows.Forms.Label();
            this.deepl_usageBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.network = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.proxy_port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proxy_url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.proxy_enabled = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.deepl.SuspendLayout();
            this.APIkey.SuspendLayout();
            this.network.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Google Cloud JSON Key File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "DeepL API Key";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(496, 288);
            this.close_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(112, 34);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "キャンセル";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // deeplKey_textBox
            // 
            this.deeplKey_textBox.Location = new System.Drawing.Point(45, 104);
            this.deeplKey_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deeplKey_textBox.Name = "deeplKey_textBox";
            this.deeplKey_textBox.Size = new System.Drawing.Size(364, 25);
            this.deeplKey_textBox.TabIndex = 3;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(374, 288);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(112, 34);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "保存";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GCkey_reference
            // 
            this.GCkey_reference.Location = new System.Drawing.Point(435, 30);
            this.GCkey_reference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GCkey_reference.Name = "GCkey_reference";
            this.GCkey_reference.Size = new System.Drawing.Size(112, 34);
            this.GCkey_reference.TabIndex = 9;
            this.GCkey_reference.Text = "参照";
            this.GCkey_reference.UseVisualStyleBackColor = true;
            this.GCkey_reference.Click += new System.EventHandler(this.GCkey_reference_Click);
            // 
            // GCkey_textBox
            // 
            this.GCkey_textBox.Location = new System.Drawing.Point(45, 33);
            this.GCkey_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GCkey_textBox.Name = "GCkey_textBox";
            this.GCkey_textBox.Size = new System.Drawing.Size(364, 25);
            this.GCkey_textBox.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.deepl);
            this.tabControl1.Controls.Add(this.APIkey);
            this.tabControl1.Controls.Add(this.network);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 261);
            this.tabControl1.TabIndex = 11;
            // 
            // deepl
            // 
            this.deepl.Controls.Add(this.label9);
            this.deepl.Controls.Add(this.autoTranslateCheckbox);
            this.deepl.Controls.Add(this.label8);
            this.deepl.Controls.Add(this.sourceLangBox);
            this.deepl.Controls.Add(this.targetLangBox);
            this.deepl.Controls.Add(this.label6);
            this.deepl.Location = new System.Drawing.Point(4, 28);
            this.deepl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deepl.Name = "deepl";
            this.deepl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deepl.Size = new System.Drawing.Size(583, 229);
            this.deepl.TabIndex = 2;
            this.deepl.Text = "翻訳設定";
            this.deepl.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "翻訳元言語";
            // 
            // autoTranslateCheckbox
            // 
            this.autoTranslateCheckbox.AutoSize = true;
            this.autoTranslateCheckbox.Location = new System.Drawing.Point(46, 176);
            this.autoTranslateCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autoTranslateCheckbox.Name = "autoTranslateCheckbox";
            this.autoTranslateCheckbox.Size = new System.Drawing.Size(271, 22);
            this.autoTranslateCheckbox.TabIndex = 3;
            this.autoTranslateCheckbox.Text = "自動翻訳を有効にする（非推奨）";
            this.autoTranslateCheckbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "自動翻訳";
            // 
            // sourceLangBox
            // 
            this.sourceLangBox.FormattingEnabled = true;
            this.sourceLangBox.Items.AddRange(new object[] {
            "自動（Auto）",
            "英語（EN）",
            "日本語（JP）"});
            this.sourceLangBox.Location = new System.Drawing.Point(46, 33);
            this.sourceLangBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sourceLangBox.Name = "sourceLangBox";
            this.sourceLangBox.Size = new System.Drawing.Size(180, 26);
            this.sourceLangBox.TabIndex = 1;
            // 
            // targetLangBox
            // 
            this.targetLangBox.FormattingEnabled = true;
            this.targetLangBox.Items.AddRange(new object[] {
            "英語（EN）",
            "日本語（JP）"});
            this.targetLangBox.Location = new System.Drawing.Point(46, 102);
            this.targetLangBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.targetLangBox.Name = "targetLangBox";
            this.targetLangBox.Size = new System.Drawing.Size(180, 26);
            this.targetLangBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "翻訳先言語";
            // 
            // APIkey
            // 
            this.APIkey.Controls.Add(this.deepl_usageLabel);
            this.APIkey.Controls.Add(this.deepl_usageBar);
            this.APIkey.Controls.Add(this.label3);
            this.APIkey.Controls.Add(this.GCkey_textBox);
            this.APIkey.Controls.Add(this.label1);
            this.APIkey.Controls.Add(this.GCkey_reference);
            this.APIkey.Controls.Add(this.label2);
            this.APIkey.Controls.Add(this.deeplKey_textBox);
            this.APIkey.Location = new System.Drawing.Point(4, 28);
            this.APIkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.APIkey.Name = "APIkey";
            this.APIkey.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.APIkey.Size = new System.Drawing.Size(583, 229);
            this.APIkey.TabIndex = 0;
            this.APIkey.Text = "APIキー設定";
            this.APIkey.UseVisualStyleBackColor = true;
            // 
            // deepl_usageLabel
            // 
            this.deepl_usageLabel.AutoSize = true;
            this.deepl_usageLabel.Location = new System.Drawing.Point(422, 177);
            this.deepl_usageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deepl_usageLabel.Name = "deepl_usageLabel";
            this.deepl_usageLabel.Size = new System.Drawing.Size(129, 18);
            this.deepl_usageLabel.TabIndex = 13;
            this.deepl_usageLabel.Text = "******/500,000";
            // 
            // deepl_usageBar
            // 
            this.deepl_usageBar.Location = new System.Drawing.Point(45, 177);
            this.deepl_usageBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deepl_usageBar.Maximum = 500000;
            this.deepl_usageBar.Name = "deepl_usageBar";
            this.deepl_usageBar.Size = new System.Drawing.Size(366, 21);
            this.deepl_usageBar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "DeepL API 使用状況";
            // 
            // network
            // 
            this.network.Controls.Add(this.label7);
            this.network.Controls.Add(this.proxy_port);
            this.network.Controls.Add(this.label5);
            this.network.Controls.Add(this.proxy_url);
            this.network.Controls.Add(this.label4);
            this.network.Controls.Add(this.proxy_enabled);
            this.network.Location = new System.Drawing.Point(4, 28);
            this.network.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.network.Name = "network";
            this.network.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.network.Size = new System.Drawing.Size(583, 229);
            this.network.TabIndex = 1;
            this.network.Text = "ネットワーク設定";
            this.network.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "プロキシの使用";
            // 
            // proxy_port
            // 
            this.proxy_port.Location = new System.Drawing.Point(36, 172);
            this.proxy_port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proxy_port.Name = "proxy_port";
            this.proxy_port.Size = new System.Drawing.Size(148, 25);
            this.proxy_port.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "ポート番号";
            // 
            // proxy_url
            // 
            this.proxy_url.Location = new System.Drawing.Point(36, 102);
            this.proxy_url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proxy_url.Name = "proxy_url";
            this.proxy_url.Size = new System.Drawing.Size(462, 25);
            this.proxy_url.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "プロキシサーバURL";
            // 
            // proxy_enabled
            // 
            this.proxy_enabled.AutoSize = true;
            this.proxy_enabled.Enabled = false;
            this.proxy_enabled.Location = new System.Drawing.Point(36, 33);
            this.proxy_enabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proxy_enabled.Name = "proxy_enabled";
            this.proxy_enabled.Size = new System.Drawing.Size(215, 22);
            this.proxy_enabled.TabIndex = 0;
            this.proxy_enabled.Text = "プロキシサーバを使用する";
            this.proxy_enabled.UseVisualStyleBackColor = true;
            this.proxy_enabled.CheckedChanged += new System.EventHandler(this.proxy_enabled_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(632, 339);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.save_button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "オプション";
            this.tabControl1.ResumeLayout(false);
            this.deepl.ResumeLayout(false);
            this.deepl.PerformLayout();
            this.APIkey.ResumeLayout(false);
            this.APIkey.PerformLayout();
            this.network.ResumeLayout(false);
            this.network.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.TextBox deeplKey_textBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button GCkey_reference;
        private System.Windows.Forms.TextBox GCkey_textBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage APIkey;
        private System.Windows.Forms.TabPage network;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox proxy_url;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox proxy_enabled;
        private System.Windows.Forms.TextBox proxy_port;
        private System.Windows.Forms.TabPage deepl;
        private System.Windows.Forms.ComboBox targetLangBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox autoTranslateCheckbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sourceLangBox;
        private System.Windows.Forms.Label deepl_usageLabel;
        private System.Windows.Forms.ProgressBar deepl_usageBar;
        private System.Windows.Forms.Label label3;
    }
}
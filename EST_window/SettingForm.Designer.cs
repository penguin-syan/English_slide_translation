
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
            this.label11 = new System.Windows.Forms.Label();
            this.translateToolBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.autoTranslateCheckbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sourceLangBox = new System.Windows.Forms.ComboBox();
            this.targetLangBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.API = new System.Windows.Forms.TabPage();
            this.gas_translate_url = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.API.SuspendLayout();
            this.network.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Google Cloud JSON Key File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "DeepL API Key";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(329, 197);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "キャンセル";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // deeplKey_textBox
            // 
            this.deeplKey_textBox.Location = new System.Drawing.Point(30, 99);
            this.deeplKey_textBox.Name = "deeplKey_textBox";
            this.deeplKey_textBox.Size = new System.Drawing.Size(244, 19);
            this.deeplKey_textBox.TabIndex = 3;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(248, 197);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
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
            this.GCkey_reference.Location = new System.Drawing.Point(290, 20);
            this.GCkey_reference.Name = "GCkey_reference";
            this.GCkey_reference.Size = new System.Drawing.Size(75, 23);
            this.GCkey_reference.TabIndex = 9;
            this.GCkey_reference.Text = "参照";
            this.GCkey_reference.UseVisualStyleBackColor = true;
            this.GCkey_reference.Click += new System.EventHandler(this.GCkey_reference_Click);
            // 
            // GCkey_textBox
            // 
            this.GCkey_textBox.Location = new System.Drawing.Point(30, 22);
            this.GCkey_textBox.Name = "GCkey_textBox";
            this.GCkey_textBox.Size = new System.Drawing.Size(244, 19);
            this.GCkey_textBox.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.deepl);
            this.tabControl1.Controls.Add(this.API);
            this.tabControl1.Controls.Add(this.network);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 184);
            this.tabControl1.TabIndex = 11;
            // 
            // deepl
            // 
            this.deepl.Controls.Add(this.label11);
            this.deepl.Controls.Add(this.translateToolBox);
            this.deepl.Controls.Add(this.label10);
            this.deepl.Controls.Add(this.label9);
            this.deepl.Controls.Add(this.autoTranslateCheckbox);
            this.deepl.Controls.Add(this.label8);
            this.deepl.Controls.Add(this.sourceLangBox);
            this.deepl.Controls.Add(this.targetLangBox);
            this.deepl.Controls.Add(this.label6);
            this.deepl.Location = new System.Drawing.Point(4, 22);
            this.deepl.Name = "deepl";
            this.deepl.Padding = new System.Windows.Forms.Padding(3);
            this.deepl.Size = new System.Drawing.Size(386, 158);
            this.deepl.TabIndex = 2;
            this.deepl.Text = "翻訳設定";
            this.deepl.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "→";
            // 
            // translateToolBox
            // 
            this.translateToolBox.Enabled = false;
            this.translateToolBox.FormattingEnabled = true;
            this.translateToolBox.Items.AddRange(new object[] {
            "DeepL 翻訳",
            "Google 翻訳"});
            this.translateToolBox.Location = new System.Drawing.Point(31, 20);
            this.translateToolBox.Margin = new System.Windows.Forms.Padding(2);
            this.translateToolBox.Name = "translateToolBox";
            this.translateToolBox.Size = new System.Drawing.Size(121, 20);
            this.translateToolBox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "翻訳方法";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "翻訳元言語";
            // 
            // autoTranslateCheckbox
            // 
            this.autoTranslateCheckbox.AutoSize = true;
            this.autoTranslateCheckbox.Enabled = false;
            this.autoTranslateCheckbox.Location = new System.Drawing.Point(31, 117);
            this.autoTranslateCheckbox.Name = "autoTranslateCheckbox";
            this.autoTranslateCheckbox.Size = new System.Drawing.Size(181, 16);
            this.autoTranslateCheckbox.TabIndex = 3;
            this.autoTranslateCheckbox.Text = "自動翻訳を有効にする（非推奨）";
            this.autoTranslateCheckbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "自動翻訳";
            // 
            // sourceLangBox
            // 
            this.sourceLangBox.Enabled = false;
            this.sourceLangBox.FormattingEnabled = true;
            this.sourceLangBox.Items.AddRange(new object[] {
            "自動（Auto）",
            "英語（EN）",
            "日本語（JP）"});
            this.sourceLangBox.Location = new System.Drawing.Point(29, 69);
            this.sourceLangBox.Name = "sourceLangBox";
            this.sourceLangBox.Size = new System.Drawing.Size(121, 20);
            this.sourceLangBox.TabIndex = 1;
            // 
            // targetLangBox
            // 
            this.targetLangBox.Enabled = false;
            this.targetLangBox.FormattingEnabled = true;
            this.targetLangBox.Items.AddRange(new object[] {
            "英語（EN）",
            "日本語（JP）"});
            this.targetLangBox.Location = new System.Drawing.Point(241, 68);
            this.targetLangBox.Name = "targetLangBox";
            this.targetLangBox.Size = new System.Drawing.Size(121, 20);
            this.targetLangBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "翻訳先言語";
            // 
            // API
            // 
            this.API.Controls.Add(this.gas_translate_url);
            this.API.Controls.Add(this.label12);
            this.API.Controls.Add(this.deepl_usageLabel);
            this.API.Controls.Add(this.deepl_usageBar);
            this.API.Controls.Add(this.label3);
            this.API.Controls.Add(this.GCkey_textBox);
            this.API.Controls.Add(this.label1);
            this.API.Controls.Add(this.GCkey_reference);
            this.API.Controls.Add(this.label2);
            this.API.Controls.Add(this.deeplKey_textBox);
            this.API.Location = new System.Drawing.Point(4, 22);
            this.API.Name = "API";
            this.API.Padding = new System.Windows.Forms.Padding(3);
            this.API.Size = new System.Drawing.Size(386, 158);
            this.API.TabIndex = 0;
            this.API.Text = "API設定";
            this.API.UseVisualStyleBackColor = true;
            // 
            // gas_translate_url
            // 
            this.gas_translate_url.Enabled = false;
            this.gas_translate_url.Location = new System.Drawing.Point(30, 61);
            this.gas_translate_url.Margin = new System.Windows.Forms.Padding(2);
            this.gas_translate_url.Name = "gas_translate_url";
            this.gas_translate_url.Size = new System.Drawing.Size(244, 19);
            this.gas_translate_url.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "GAS 翻訳API URL";
            // 
            // deepl_usageLabel
            // 
            this.deepl_usageLabel.AutoSize = true;
            this.deepl_usageLabel.Location = new System.Drawing.Point(281, 140);
            this.deepl_usageLabel.Name = "deepl_usageLabel";
            this.deepl_usageLabel.Size = new System.Drawing.Size(85, 12);
            this.deepl_usageLabel.TabIndex = 13;
            this.deepl_usageLabel.Text = "******/500,000";
            // 
            // deepl_usageBar
            // 
            this.deepl_usageBar.Location = new System.Drawing.Point(30, 139);
            this.deepl_usageBar.Maximum = 500000;
            this.deepl_usageBar.Name = "deepl_usageBar";
            this.deepl_usageBar.Size = new System.Drawing.Size(244, 14);
            this.deepl_usageBar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 12);
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
            this.network.Location = new System.Drawing.Point(4, 22);
            this.network.Name = "network";
            this.network.Padding = new System.Windows.Forms.Padding(3);
            this.network.Size = new System.Drawing.Size(386, 158);
            this.network.TabIndex = 1;
            this.network.Text = "ネットワーク設定";
            this.network.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "プロキシの使用";
            // 
            // proxy_port
            // 
            this.proxy_port.Location = new System.Drawing.Point(24, 115);
            this.proxy_port.Name = "proxy_port";
            this.proxy_port.Size = new System.Drawing.Size(100, 19);
            this.proxy_port.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "ポート番号";
            // 
            // proxy_url
            // 
            this.proxy_url.Location = new System.Drawing.Point(24, 68);
            this.proxy_url.Name = "proxy_url";
            this.proxy_url.Size = new System.Drawing.Size(309, 19);
            this.proxy_url.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "プロキシサーバURL";
            // 
            // proxy_enabled
            // 
            this.proxy_enabled.AutoSize = true;
            this.proxy_enabled.Enabled = false;
            this.proxy_enabled.Location = new System.Drawing.Point(24, 22);
            this.proxy_enabled.Name = "proxy_enabled";
            this.proxy_enabled.Size = new System.Drawing.Size(144, 16);
            this.proxy_enabled.TabIndex = 0;
            this.proxy_enabled.Text = "プロキシサーバを使用する";
            this.proxy_enabled.UseVisualStyleBackColor = true;
            this.proxy_enabled.CheckedChanged += new System.EventHandler(this.proxy_enabled_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(421, 226);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.save_button);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "オプション";
            this.tabControl1.ResumeLayout(false);
            this.deepl.ResumeLayout(false);
            this.deepl.PerformLayout();
            this.API.ResumeLayout(false);
            this.API.PerformLayout();
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
        private System.Windows.Forms.TabPage API;
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
        private System.Windows.Forms.ComboBox translateToolBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox gas_translate_url;
        private System.Windows.Forms.Label label12;
    }
}
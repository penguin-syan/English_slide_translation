﻿
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
            this.targetLangBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.APIkey = new System.Windows.Forms.TabPage();
            this.network = new System.Windows.Forms.TabPage();
            this.proxy_port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proxy_url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.proxy_enabled = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.autoTranslateCheckbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sourceLangBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.deepl.SuspendLayout();
            this.APIkey.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "DeepL API Key";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(331, 192);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "キャンセル";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // deeplKey_textBox
            // 
            this.deeplKey_textBox.Location = new System.Drawing.Point(30, 69);
            this.deeplKey_textBox.Name = "deeplKey_textBox";
            this.deeplKey_textBox.Size = new System.Drawing.Size(244, 19);
            this.deeplKey_textBox.TabIndex = 3;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(249, 192);
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
            this.tabControl1.Controls.Add(this.APIkey);
            this.tabControl1.Controls.Add(this.network);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 174);
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
            this.deepl.Location = new System.Drawing.Point(4, 22);
            this.deepl.Name = "deepl";
            this.deepl.Padding = new System.Windows.Forms.Padding(3);
            this.deepl.Size = new System.Drawing.Size(386, 148);
            this.deepl.TabIndex = 2;
            this.deepl.Text = "翻訳設定";
            this.deepl.UseVisualStyleBackColor = true;
            // 
            // targetLangBox
            // 
            this.targetLangBox.FormattingEnabled = true;
            this.targetLangBox.Items.AddRange(new object[] {
            "英語（EN）",
            "日本語（JP）"});
            this.targetLangBox.Location = new System.Drawing.Point(31, 68);
            this.targetLangBox.Name = "targetLangBox";
            this.targetLangBox.Size = new System.Drawing.Size(121, 20);
            this.targetLangBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "翻訳先言語";
            // 
            // APIkey
            // 
            this.APIkey.Controls.Add(this.GCkey_textBox);
            this.APIkey.Controls.Add(this.label1);
            this.APIkey.Controls.Add(this.GCkey_reference);
            this.APIkey.Controls.Add(this.label2);
            this.APIkey.Controls.Add(this.deeplKey_textBox);
            this.APIkey.Location = new System.Drawing.Point(4, 22);
            this.APIkey.Name = "APIkey";
            this.APIkey.Padding = new System.Windows.Forms.Padding(3);
            this.APIkey.Size = new System.Drawing.Size(386, 148);
            this.APIkey.TabIndex = 0;
            this.APIkey.Text = "APIキー設定";
            this.APIkey.UseVisualStyleBackColor = true;
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
            this.network.Size = new System.Drawing.Size(386, 148);
            this.network.TabIndex = 1;
            this.network.Text = "ネットワーク設定";
            this.network.UseVisualStyleBackColor = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "プロキシの使用";
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
            // autoTranslateCheckbox
            // 
            this.autoTranslateCheckbox.AutoSize = true;
            this.autoTranslateCheckbox.Location = new System.Drawing.Point(31, 117);
            this.autoTranslateCheckbox.Name = "autoTranslateCheckbox";
            this.autoTranslateCheckbox.Size = new System.Drawing.Size(181, 16);
            this.autoTranslateCheckbox.TabIndex = 3;
            this.autoTranslateCheckbox.Text = "自動翻訳を有効にする（非推奨）";
            this.autoTranslateCheckbox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "翻訳元言語";
            // 
            // sourceLangBox
            // 
            this.sourceLangBox.FormattingEnabled = true;
            this.sourceLangBox.Items.AddRange(new object[] {
            "自動（Auto）",
            "英語（EN）",
            "日本語（JP）"});
            this.sourceLangBox.Location = new System.Drawing.Point(31, 22);
            this.sourceLangBox.Name = "sourceLangBox";
            this.sourceLangBox.Size = new System.Drawing.Size(121, 20);
            this.sourceLangBox.TabIndex = 1;
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
    }
}
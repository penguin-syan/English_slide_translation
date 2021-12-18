
namespace EST_window
{
    partial class AppForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.setAreaButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setAreaTimer = new System.Windows.Forms.Timer(this.components);
            this.startTranslation = new System.Windows.Forms.Button();
            this.LTposLabel = new System.Windows.Forms.Label();
            this.RBposLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初期設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプの表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新の確認ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitリポジトリToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTranslation = new System.Windows.Forms.Button();
            this.translatedTextBox = new System.Windows.Forms.RichTextBox();
            this.sourceTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.retranslateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setAreaButton
            // 
            this.setAreaButton.Location = new System.Drawing.Point(696, 336);
            this.setAreaButton.Name = "setAreaButton";
            this.setAreaButton.Size = new System.Drawing.Size(75, 23);
            this.setAreaButton.TabIndex = 0;
            this.setAreaButton.Text = "領域指定";
            this.setAreaButton.UseVisualStyleBackColor = true;
            this.setAreaButton.Click += new System.EventHandler(this.setAreaBusson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // setAreaTimer
            // 
            this.setAreaTimer.Interval = 10;
            this.setAreaTimer.Tick += new System.EventHandler(this.setAreaTimer_Tick);
            // 
            // startTranslation
            // 
            this.startTranslation.Location = new System.Drawing.Point(696, 365);
            this.startTranslation.Name = "startTranslation";
            this.startTranslation.Size = new System.Drawing.Size(75, 23);
            this.startTranslation.TabIndex = 2;
            this.startTranslation.Text = "翻訳";
            this.startTranslation.UseVisualStyleBackColor = true;
            this.startTranslation.Click += new System.EventHandler(this.startTranslation_Click);
            // 
            // LTposLabel
            // 
            this.LTposLabel.AutoSize = true;
            this.LTposLabel.Location = new System.Drawing.Point(668, 34);
            this.LTposLabel.Name = "LTposLabel";
            this.LTposLabel.Size = new System.Drawing.Size(35, 12);
            this.LTposLabel.TabIndex = 3;
            this.LTposLabel.Text = "label1";
            // 
            // RBposLabel
            // 
            this.RBposLabel.AutoSize = true;
            this.RBposLabel.Location = new System.Drawing.Point(668, 46);
            this.RBposLabel.Name = "RBposLabel";
            this.RBposLabel.Size = new System.Drawing.Size(35, 12);
            this.RBposLabel.TabIndex = 4;
            this.RBposLabel.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くOToolStripMenuItem,
            this.保存SToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くOToolStripMenuItem
            // 
            this.開くOToolStripMenuItem.Enabled = false;
            this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            this.開くOToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.開くOToolStripMenuItem.Text = "開く(&O)";
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Enabled = false;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.終了ToolStripMenuItem.Text = "終了(&X)";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初期設定ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.設定ToolStripMenuItem.Text = "設定(&S)";
            // 
            // 初期設定ToolStripMenuItem
            // 
            this.初期設定ToolStripMenuItem.Name = "初期設定ToolStripMenuItem";
            this.初期設定ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.初期設定ToolStripMenuItem.Text = "環境設定(&O)";
            this.初期設定ToolStripMenuItem.Click += new System.EventHandler(this.初期設定ToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプの表示ToolStripMenuItem,
            this.更新の確認ToolStripMenuItem,
            this.gitリポジトリToolStripMenuItem,
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // ヘルプの表示ToolStripMenuItem
            // 
            this.ヘルプの表示ToolStripMenuItem.Name = "ヘルプの表示ToolStripMenuItem";
            this.ヘルプの表示ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ヘルプの表示ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ヘルプの表示ToolStripMenuItem.Text = "ヘルプの表示(&V)";
            this.ヘルプの表示ToolStripMenuItem.Click += new System.EventHandler(this.ヘルプの表示ToolStripMenuItem_Click);
            // 
            // 更新の確認ToolStripMenuItem
            // 
            this.更新の確認ToolStripMenuItem.Name = "更新の確認ToolStripMenuItem";
            this.更新の確認ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.更新の確認ToolStripMenuItem.Text = "更新の確認(&U)";
            this.更新の確認ToolStripMenuItem.Click += new System.EventHandler(this.更新の確認ToolStripMenuItem_Click);
            // 
            // gitリポジトリToolStripMenuItem
            // 
            this.gitリポジトリToolStripMenuItem.Name = "gitリポジトリToolStripMenuItem";
            this.gitリポジトリToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.gitリポジトリToolStripMenuItem.Text = "GitHubリポジトリ(&G)";
            this.gitリポジトリToolStripMenuItem.Click += new System.EventHandler(this.gitリポジトリToolStripMenuItem_Click);
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報(&A)";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem_Click);
            // 
            // saveTranslation
            // 
            this.saveTranslation.Enabled = false;
            this.saveTranslation.Location = new System.Drawing.Point(696, 395);
            this.saveTranslation.Name = "saveTranslation";
            this.saveTranslation.Size = new System.Drawing.Size(75, 23);
            this.saveTranslation.TabIndex = 8;
            this.saveTranslation.Text = "保存";
            this.saveTranslation.UseVisualStyleBackColor = true;
            // 
            // translatedTextBox
            // 
            this.translatedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.translatedTextBox.Location = new System.Drawing.Point(420, 456);
            this.translatedTextBox.Name = "translatedTextBox";
            this.translatedTextBox.ReadOnly = true;
            this.translatedTextBox.Size = new System.Drawing.Size(368, 111);
            this.translatedTextBox.TabIndex = 9;
            this.translatedTextBox.Text = "";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sourceTextBox.Location = new System.Drawing.Point(12, 456);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(368, 111);
            this.sourceTextBox.TabIndex = 10;
            this.sourceTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "原文";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "翻訳文";
            // 
            // retranslateButton
            // 
            this.retranslateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.retranslateButton.Location = new System.Drawing.Point(385, 501);
            this.retranslateButton.Name = "retranslateButton";
            this.retranslateButton.Size = new System.Drawing.Size(28, 23);
            this.retranslateButton.TabIndex = 13;
            this.retranslateButton.Text = "→";
            this.retranslateButton.UseVisualStyleBackColor = true;
            this.retranslateButton.Click += new System.EventHandler(this.retranslateButton_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.retranslateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.translatedTextBox);
            this.Controls.Add(this.saveTranslation);
            this.Controls.Add(this.RBposLabel);
            this.Controls.Add(this.LTposLabel);
            this.Controls.Add(this.startTranslation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.setAreaButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AppForm";
            this.Text = "[EST] English Slide Translation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setAreaButton;
        private System.Windows.Forms.Timer setAreaTimer;
        private System.Windows.Forms.Button startTranslation;
        private System.Windows.Forms.Label LTposLabel;
        private System.Windows.Forms.Label RBposLabel;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 初期設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプの表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新の確認ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitリポジトリToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button saveTranslation;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RichTextBox translatedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button retranslateButton;
        public System.Windows.Forms.RichTextBox sourceTextBox;
    }
}


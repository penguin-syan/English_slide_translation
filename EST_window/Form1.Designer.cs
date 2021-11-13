
namespace EST_window
{
    partial class Form1
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
            this.Text = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // setAreaButton
            // 
            this.setAreaButton.Location = new System.Drawing.Point(713, 357);
            this.setAreaButton.Name = "setAreaButton";
            this.setAreaButton.Size = new System.Drawing.Size(75, 23);
            this.setAreaButton.TabIndex = 0;
            this.setAreaButton.Text = "領域指定";
            this.setAreaButton.UseVisualStyleBackColor = true;
            this.setAreaButton.Click += new System.EventHandler(this.setAreaBusson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 426);
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
            this.startTranslation.Location = new System.Drawing.Point(713, 386);
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
            this.RBposLabel.Location = new System.Drawing.Point(669, 50);
            this.RBposLabel.Name = "RBposLabel";
            this.RBposLabel.Size = new System.Drawing.Size(35, 12);
            this.RBposLabel.TabIndex = 4;
            this.RBposLabel.Text = "label1";
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(713, 415);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(75, 23);
            this.Text.TabIndex = 5;
            this.Text.Text = "Test";
            this.Text.UseVisualStyleBackColor = true;
            this.Text.Click += new System.EventHandler(this.Text_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.RBposLabel);
            this.Controls.Add(this.LTposLabel);
            this.Controls.Add(this.startTranslation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.setAreaButton);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setAreaButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer setAreaTimer;
        private System.Windows.Forms.Button startTranslation;
        private System.Windows.Forms.Label LTposLabel;
        private System.Windows.Forms.Label RBposLabel;
        private System.Windows.Forms.Button Text;
    }
}


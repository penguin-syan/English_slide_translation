﻿
namespace EST_window
{
    partial class VersionForm
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
            this.versionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vframe_close = new System.Windows.Forms.Button();
            this.vframe_license = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Slide Translation";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(11, 27);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(44, 12);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "© penguin_syan";
            // 
            // vframe_close
            // 
            this.vframe_close.Location = new System.Drawing.Point(166, 74);
            this.vframe_close.Name = "vframe_close";
            this.vframe_close.Size = new System.Drawing.Size(75, 23);
            this.vframe_close.TabIndex = 3;
            this.vframe_close.Text = "OK";
            this.vframe_close.UseVisualStyleBackColor = true;
            this.vframe_close.Click += new System.EventHandler(this.vframe_close_Click);
            // 
            // vframe_license
            // 
            this.vframe_license.Location = new System.Drawing.Point(11, 74);
            this.vframe_license.Name = "vframe_license";
            this.vframe_license.Size = new System.Drawing.Size(113, 23);
            this.vframe_license.TabIndex = 4;
            this.vframe_license.Text = "ライセンス情報";
            this.vframe_license.UseVisualStyleBackColor = true;
            this.vframe_license.Click += new System.EventHandler(this.vframe_license_Click);
            // 
            // VersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(248, 105);
            this.Controls.Add(this.vframe_license);
            this.Controls.Add(this.vframe_close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VersionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "バージョン情報";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button vframe_close;
        private System.Windows.Forms.Button vframe_license;
    }
}

namespace EST_window
{
    partial class AreaSelectForm
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
            this.selectArea_pBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectArea_pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectArea_pBox
            // 
            this.selectArea_pBox.BackColor = System.Drawing.Color.Transparent;
            this.selectArea_pBox.Location = new System.Drawing.Point(0, 0);
            this.selectArea_pBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectArea_pBox.Name = "selectArea_pBox";
            this.selectArea_pBox.Size = new System.Drawing.Size(782, 432);
            this.selectArea_pBox.TabIndex = 0;
            this.selectArea_pBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(228, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "領域選択のキャンセル時はEscキーを入力";
            // 
            // AreaSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectArea_pBox);
            this.Name = "AreaSelectForm";
            this.TransparencyKey = System.Drawing.Color.LawnGreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AreaSelectForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.selectArea_pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox selectArea_pBox;
        private System.Windows.Forms.Label label1;
    }
}
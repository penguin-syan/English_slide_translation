
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
            // AreaSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.selectArea_pBox);
            this.Name = "AreaSelectForm";
            this.TransparencyKey = System.Drawing.Color.LawnGreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.selectArea_pBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox selectArea_pBox;
    }
}
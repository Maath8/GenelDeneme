namespace htemurtas
{
    partial class Form1
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
            this.PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(80, 61);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(509, 308);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            this.PicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBox_Paint);
            this.PicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseDown);
            this.PicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseMove);
            this.PicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 443);
            this.Controls.Add(this.PicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox;
    }
}


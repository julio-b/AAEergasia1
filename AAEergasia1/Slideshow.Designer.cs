namespace AAEergasia1
{
    partial class Slideshow
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slidePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slidePictureBox
            // 
            this.slidePictureBox.Location = new System.Drawing.Point(100, 62);
            this.slidePictureBox.Name = "slidePictureBox";
            this.slidePictureBox.Size = new System.Drawing.Size(190, 130);
            this.slidePictureBox.TabIndex = 0;
            this.slidePictureBox.TabStop = false;
            this.slidePictureBox.Click += new System.EventHandler(this.slidePictureBox_Click);
            // 
            // Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 325);
            this.Controls.Add(this.slidePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Slideshow";
            this.Text = "Slideshow";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Slideshow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox slidePictureBox;
    }
}
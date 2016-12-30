using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAEergasia1
{
    public partial class Slideshow : Form
    {
        Random rnd = new Random();
        private List<Image> picList;
        public Slideshow(List<Image> pics)
        {
            InitializeComponent();
            picList = pics;
            timer1_Tick(null, null);
        }
        
        private void resize()
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            slidePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            slidePictureBox.Location = new Point(w / 2 - slidePictureBox.Width / 2, h / 2 - slidePictureBox.Height / 2);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            slidePictureBox.Image = picList[rnd.Next(0, picList.Count)];
            resize();
        }

        

        private void Slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Dispose();
        }

        private void slidePictureBox_Click(object sender, EventArgs e)
        {
            slidePictureBox.Image = picList[rnd.Next(0, picList.Count)];
            resize();
        }
    }
}

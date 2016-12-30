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
        int prevIm=-1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int curIm = rnd.Next(0, picList.Count);
            while (curIm == prevIm && picList.Count>1) curIm = rnd.Next(0, picList.Count);
            prevIm = curIm;
            BackgroundImage = picList[curIm];
            
        }
        
        private void Slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Dispose();
        }

        private void Slideshow_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1_Tick(null, null);
            timer1.Start();
        }
    }
}

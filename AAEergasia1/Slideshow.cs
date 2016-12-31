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
        private bool randomOrder = false;
        public Slideshow(List<Image> pics, bool random)
        {
            InitializeComponent();
            picList = pics;
            randomOrder = random;
            timer1_Tick(null, null);
        }
        int position=int.MaxValue-1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            position++;
            if (position >= picList.Count) {
                if(randomOrder) shufflePics();
                position = 0;
            }
            BackgroundImage = picList[position];
            
        }

        private void shufflePics() {
            for (int i = 0; i < picList.Count; i++) {
                int j = rnd.Next(i, picList.Count);
                Image tmp = picList[i];
                picList[i] = picList[j];
                picList[j] = tmp;
            } 
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

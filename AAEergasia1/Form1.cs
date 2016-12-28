using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAEergasia1 {
    public partial class Form1 : Form {
        private sidePanelPics side;
        public Form1() {
            InitializeComponent();
            side = new sidePanelPics(splitContainer1.Panel1);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            side.loadPics(openFileDialog1.FileNames);
            foreach(var p in side.pics) {
                p.MouseClick += openSidePic;
            }
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e) {
            if(side!=null) side.update();
            splitContainer1.Panel1.PerformLayout();
        }

        private void openSidePic(object sender, MouseEventArgs e) {
            var p = sender as Pics;
            mainPicture.Image = p.Image;
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            mainPicture.Image.Save(saveFileDialog1.FileName);
            StreamWriter fo = new StreamWriter(saveFileDialog1.FileName + ".txt");
            fo.Write(richTextBox1.Text);
            fo.Flush();
            fo.Close();
        }
    }

    class sidePanelPics {
        public List<Pics> pics; 
        private Panel sidePanel;
        public sidePanelPics(Panel pan, string[] picNames = null) {
            sidePanel = pan;
            pics = new List<Pics>(); 
        }

        public void loadPics(string[] picNames) {
            foreach(string s in picNames) {
                pics.Add(new AAEergasia1.Pics(s));
                sidePanel.Controls.Add(pics.Last());
            }
            update();
        }

        public void update() {
            int Width = sidePanel.Size.Width - 35;
            int Height = Width;
            for (int i = 0; i < pics.Count; i++) {
                pics[i].Size = new Size(Width, Width);
                pics[i].Top = 10 + (Height + 10) * i;
                pics[i].Left = 10;
            }
        }

    }

    class Pics : PictureBox {
        public Pics(string str) : base() {
            Image = new Bitmap(str);
            SizeMode = PictureBoxSizeMode.StretchImage;
        } 
    }
}

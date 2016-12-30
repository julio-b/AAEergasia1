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
        private SidePanel side;
        public Form1() {
            InitializeComponent();
            side = new SidePanel(splitContainer1.Panel1);
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e) {
            if(side!=null)
                side.update();
            resizeImage(null, null);
        }

        private void openSidePic(object sender, MouseEventArgs e) {
            var p = sender as Pic;
            mainPicture.Image = p.Image;
            richTextBox1.Text = p.description;
            resizeImage(null, null);
            side.selected = p;
        }


        private void nextPic(object sender, EventArgs e) {//change func name
            if (side.selected == null || side.panel.Controls.Count == 0) return; 
            int selectedPos = side.panel.Controls.IndexOf(side.selected);
            var btn = sender as Button;
            selectedPos += btn.Name == "nextBtn" ? 1 : -1;
            selectedPos = selectedPos < 0 ? side.panel.Controls.Count - 1 : selectedPos >= side.panel.Controls.Count ? 0 : selectedPos;//circle
            side.selected = side.panel.Controls[selectedPos] as Pic;
            openSidePic(side.selected, null);
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        { //TODO
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                mainPicture.Image.Save(saveFileDialog1.FileName);
                //StreamWriter fo = new StreamWriter(saveFileDialog1.FileName + ".txt");
                //fo.Flush();
                //fo.Close();
                File.WriteAllText(saveFileDialog1.FileName + ".txt", richTextBox1.Text);
            }
        }

        private void openImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                side.loadPics(openFileDialog1.FileNames);
                foreach (Pic p in side.panel.Controls)
                    p.MouseClick += openSidePic;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void resizeImage(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                mainPicture.Size = new Size(500, 400);
                mainPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                mainPicture.Location = new Point(splitContainer1.Panel2.Width / 2 - mainPicture.Width / 2, splitContainer1.Panel2.Height / 2 - mainPicture.Height / 2);
            }
            else if (radioButton2.Checked)
            {
                mainPicture.SizeMode = PictureBoxSizeMode.AutoSize;
                mainPicture.Location = new Point(splitContainer1.Panel2.Width / 2 - mainPicture.Width / 2, splitContainer1.Panel2.Height / 2 - mainPicture.Height / 2);
            }
        }

        private void switchSidePanelBtn_Click(object sender, EventArgs e) {
            side.panel.Visible = !side.panel.Visible;
            splitContainer1.Panel1Collapsed = !side.panel.Visible;
            switchSidePanelBtn.Text = side.panel.Visible ? "<" : ">";
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e) {
            richTextBox1.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Slideshow slide = new Slideshow(side.GetImages());
            slide.Show();
            slide.Focus();
        }
    }

    ////..add highlight for selected pic
    class SidePanel {
        public Panel panel;
        public Pic selected=null;
        public SidePanel(Panel panel) {
            this.panel = panel;
        }

        public List<Image> GetImages()
        {
            List<Image> pics = new List<Image>();
            foreach(Pic p in panel.Controls)
            {
                pics.Add(p.Image);
            }
            return pics;
        }

        public void loadPics(string[] picNames) {
            foreach(string s in picNames) {
                Pic pic = new Pic(s, File.Exists(s+".txt")? File.ReadAllText(s+".txt"):"No description.");
                panel.Controls.Add(pic);
            }
            update();
        }

        public void update() {
            int Width = panel.Size.Width - 20;
            int Height = Width;///
            for (int i = 0; i < panel.Controls.Count; i++) {
                Pic pic = (Pic)panel.Controls[i];
                pic.Size = new Size(Width, Height);
                pic.Top = 10 + (Height + 10) * i;///bugged when panel is "scrolled" down
                pic.Left = 10;
            }
            panel.PerformLayout();
        }

    }

    public class Pic : PictureBox {
        public string description = "";
        public Pic(string str,string desc) : base() {
            Image = new Bitmap(str);
            SizeMode = PictureBoxSizeMode.StretchImage;
            Cursor = Cursors.Hand;
            description = desc;
        }
    }
}

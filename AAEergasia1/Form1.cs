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
using System.Drawing.Text;

namespace AAEergasia1 {
    public partial class Form1 : Form {
        private SidePanel side;
        bool description = false;

        public Form1() {
            InitializeComponent();
            side = new SidePanel(splitContainer1.Panel1);
            loadFonts();            
        }

        private void loadFonts()
        {
            PrivateFontCollection icons = new PrivateFontCollection();
            icons.AddFontFile(@"../../Resources/icons.ttf");
            Font small = new Font(icons.Families[0], 10);
            previousBtn.Font = small;
            nextBtn.Font = small;
            switchSidePanelBtn.Font = small;
            Font medium = new Font(icons.Families[0], 20);
            rotateLeft.Font = medium;
            rotateRight.Font = medium;
            descBtn.Font = medium;
            Font big = new Font(icons.Families[0], 30);
            slideShowBtn.Font = big;
            addBtn.Font = big;
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
            if(side.selected != null) //an den einai to prwto,mono tote exei prohgoumeno
                side.selected.BorderStyle = BorderStyle.None;
            side.selected = p;
            side.selected.BorderStyle = BorderStyle.Fixed3D;
        }


        private void nextPic(object sender, EventArgs e) {
            if (side.selected == null || side.panel.Controls.Count == 0) return; 
            int selectedPos = side.panel.Controls.IndexOf(side.selected);
            var btn = sender as Button;
            selectedPos += btn.Name == "nextBtn" ? 1 : -1;
            selectedPos = selectedPos < 0 ? side.panel.Controls.Count - 1 : selectedPos >= side.panel.Controls.Count ? 0 : selectedPos;//circle
            Pic selected = side.panel.Controls[selectedPos] as Pic;
            side.panel.ScrollControlIntoView(selected);
            openSidePic(selected, null);
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                mainPicture.Image.Save(saveFileDialog1.FileName + ".png");
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
                mainPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                zoomBar.Value = 0;
                if(mainPicture.Image != null)
                    zoomBar_Scroll(null, null);
                label1.Visible = true;
                label2.Visible = true;
                zoomBar.Visible = true;
            }
            else if (radioButton2.Checked)
            {
                mainPicture.SizeMode = PictureBoxSizeMode.AutoSize;
                mainPicture.Location = new Point(splitContainer1.Panel2.Width / 2 - mainPicture.Width / 2, splitContainer1.Panel2.Height / 2 - mainPicture.Height / 2);
                //hide zoom
                label1.Visible = false;
                label2.Visible = false;
                zoomBar.Visible = false;
            }
        }

        private void switchSidePanelBtn_Click(object sender, EventArgs e) {
            side.panel.Visible = !side.panel.Visible;
            splitContainer1.Panel1Collapsed = !side.panel.Visible;
            switchSidePanelBtn.Text = side.panel.Visible ? "\uf101" : "\uf100";
        }

        private void slideShowBtn_Click(object sender, EventArgs e)
        {
            List<Image> pics = side.GetImages();
            if (pics.Count != 0)
            {
                Slideshow slide = new Slideshow(pics, randomSlideShowToolStripMenuItem.Checked);
                slide.Show();
                slide.Focus();
            }
            else
                MessageBox.Show("Please load images first!");
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            float ratio = zoomBar.Value / 100f; //(-70,+70)%
            float w = mainPicture.Image.Width * (1 + ratio);
            float h = mainPicture.Image.Height * (1 + ratio);
            mainPicture.Size = new Size((int)w, (int)h);
            mainPicture.Location = new Point(splitContainer1.Panel2.Width / 2 - mainPicture.Width / 2, splitContainer1.Panel2.Height / 2 - mainPicture.Height / 2);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Created by:\n";
            about += "\tΓιώργος\n";
            about += "\tΘεοφάνης\n";
            about += "\tΤζούλιο\n";
            MessageBox.Show(about, "About");
        }

        private void oneColorOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            Color c = colorDialog1.Color;
            colorFilter(delegate(Color pixel) {
                float avg = (pixel.R + pixel.G + pixel.B) / 3f;
                float r = (avg / 255) * c.R;
                float g = (avg / 255) * c.G;
                float b = (avg / 255) * c.B;
                return Color.FromArgb((int)r, (int)g, (int)b);
            });
        }

        private void negativeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorFilter(delegate(Color pixel) {
                return Color.FromArgb(255-pixel.R, 255-pixel.G, 255-pixel.B);
            });
        }

        //efarmozei to filtro se ola ta pixel ths eikonas
        private void colorFilter(ColorOperation filter)
        {
            Bitmap img = new Bitmap(mainPicture.Image);
            for (int y = 0; y < img.Height; y++)
                for (int x = 0; x < img.Width; x++)
                    img.SetPixel(x, y, filter(img.GetPixel(x, y))); //apply given filter
            mainPicture.Image = img;
        }

        private delegate Color ColorOperation(Color pixel);

        private void randomSlideShowToolStripMenuItem_Click(object sender, EventArgs e) {
            var s = sender as ToolStripMenuItem;
            s.Checked = !s.Checked;
        }

        private void rotateMainPic(object sender, EventArgs e) {
            var s = sender as Button;
            Bitmap img = new Bitmap(mainPicture.Image);
            img.RotateFlip(s == rotateRight ? RotateFlipType.Rotate90FlipNone : RotateFlipType.Rotate270FlipNone);
            mainPicture.Image = img;
            resizeImage(null, null);
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if(richTextBox1.ForeColor == Color.Gray)
            {
                richTextBox1.Clear();
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "")
            {
                richTextBox1.Text = "Describe image here...";
                richTextBox1.ForeColor = Color.Gray;
            }
        }

        private void descBtn_Click(object sender, EventArgs e)
        {
            description = !description;
            if (description) descBtn.ForeColor = Color.Green;
            else descBtn.ForeColor = Color.Black;
            richTextBox1.Visible = description;
        }
    }

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
            int margin = 10;
            int Width = panel.Size.Width - 2*margin - (panel.VerticalScroll.Visible?SystemInformation.VerticalScrollBarWidth:0);
            int Height = Width;///
            for (int i = 0; i < panel.Controls.Count; i++) {
                Pic pic = (Pic)panel.Controls[i];
                pic.Size = new Size(Width, Height);
                pic.Top = margin + (Height + margin) * i - panel.VerticalScroll.Value;
                panel.HorizontalScroll.Value = 0;
                pic.Left = margin;
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

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
            realSizeToolStripMenuItem.SelectedIndex = 0;
            prevSize = mainPicture.Image.Size;
            splitContainer1.Panel2.MouseWheel += Panel2_MouseWheel;
        }

        private void Panel2_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && zoomBar.Value + zoomBar.LargeChange <= zoomBar.Maximum)
                zoomBar.Value += zoomBar.LargeChange;
            if (e.Delta < 0 && zoomBar.Value - zoomBar.LargeChange >= zoomBar.Minimum)
                zoomBar.Value -= zoomBar.LargeChange;
            zoomBar_Scroll(null, null);
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
            mainPicture.Location = new Point(splitContainer1.Panel2.Width / 2 - mainPicture.Width / 2, splitContainer1.Panel2.Height / 2 - mainPicture.Height / 2);
        }

        private void openSidePic(object sender, MouseEventArgs e) {
            var p = sender as Pic;
            mainPicture.Image = p.Image;
            richTextBox1.Text = p.description;
            if (customSize) oKToolStripMenuItem_Click(null, null); else realSizeToolStripMenuItem_SelectedIndexChanged(null, null);
            if (side.selected != null) //an den einai to prwto,mono tote exei prohgoumeno
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
            if (side != null) side.update();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
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

        private Size prevSize; //gia to bug tou zoom ama allazei diastaseis h eikona
        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            Size oldSize = mainPicture.Size;
            float ratio = zoomBar.Value / 100f; //(-70,+70)%
            float w = prevSize.Width * (1 + ratio);
            float h = prevSize.Height * (1 + ratio);
            mainPicture.Size = new Size((int)w, (int)h);
            mainPicture.Left += (oldSize.Width - mainPicture.Size.Width) / 2; 
            mainPicture.Top += (oldSize.Height - mainPicture.Size.Height) / 2;
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
            Point center = new Point(mainPicture.Left + mainPicture.Size.Width / 2, mainPicture.Top + mainPicture.Size.Height / 2);
            mainPicture.Size = new Size(prevSize.Height, prevSize.Width);
            prevSize = mainPicture.Size;
            zoomBar_Scroll(null, null);
            mainPicture.Left += center.X - (mainPicture.Left + mainPicture.Size.Width / 2);
            mainPicture.Top += center.Y - (mainPicture.Top + mainPicture.Size.Height / 2);
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

        bool customSize = false;
        private void realSizeToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e) {
            string s = realSizeToolStripMenuItem.SelectedItem.ToString();
            mainPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            if (s.Equals("") || s.Equals("RealSize")) {
                mainPicture.Size = mainPicture.Image.Size;
            } else if (s.Equals("16:9")) {
                mainPicture.Size = new Size(1600, 900);
            } else if (s.Equals("4:3")) {
                mainPicture.Size = new Size(400, 300);
            } else if (s.Equals("1024x576")) {
                mainPicture.Size = new Size(1024, 576);
            }
            mainPicture.Location = new Point(splitContainer1.Panel2.Width / 2 - mainPicture.Width / 2, splitContainer1.Panel2.Height / 2 - mainPicture.Height / 2);
            prevSize = mainPicture.Size;
            zoomBar.Value = 0; //reset zoom
            customSize = false;
            mainpicSizeLabel.Text = s;
        }

        private void oKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                int w = int.Parse(toolStripTextBox1.Text);
                int h = int.Parse(toolStripTextBox2.Text);
                mainPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                mainPicture.Size = new Size(w, h);
                mainPicture.Location = new Point(splitContainer1.Panel2.Width / 2 - mainPicture.Width / 2, splitContainer1.Panel2.Height / 2 - mainPicture.Height / 2);
                prevSize = mainPicture.Size;
                zoomBar.Value = 0; //reset zoom
                customSize = true;
                mainpicSizeLabel.Text = w.ToString() + "x" + h.ToString();
            } catch (Exception) {
                realSizeToolStripMenuItem_SelectedIndexChanged(null, null);
            }
        }

        bool mousePressed = false;
        Point prevPos;
        private void mainPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mousePressed = true;
            prevPos = e.Location;
        }

        private void mainPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mousePressed) return;
            mainPicture.Top += e.Y - prevPos.Y;
            mainPicture.Left += e.X - prevPos.X;
        }

        private void mainPicture_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
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

namespace AAEergasia1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.mainpicSizeLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.descBtn = new System.Windows.Forms.Button();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rotateRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.slideShowBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneColorOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomSlideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realSizeToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.heightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.oKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.switchSidePanelBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.controlPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 77);
            this.panel1.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlPanel.Controls.Add(this.mainpicSizeLabel);
            this.controlPanel.Controls.Add(this.addBtn);
            this.controlPanel.Controls.Add(this.descBtn);
            this.controlPanel.Controls.Add(this.rotateLeft);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.rotateRight);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.zoomBar);
            this.controlPanel.Controls.Add(this.slideShowBtn);
            this.controlPanel.Controls.Add(this.previousBtn);
            this.controlPanel.Controls.Add(this.nextBtn);
            this.controlPanel.Location = new System.Drawing.Point(153, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(708, 65);
            this.controlPanel.TabIndex = 4;
            // 
            // mainpicSizeLabel
            // 
            this.mainpicSizeLabel.AutoSize = true;
            this.mainpicSizeLabel.Location = new System.Drawing.Point(488, 43);
            this.mainpicSizeLabel.Name = "mainpicSizeLabel";
            this.mainpicSizeLabel.Size = new System.Drawing.Size(52, 13);
            this.mainpicSizeLabel.TabIndex = 9;
            this.mainpicSizeLabel.Text = "Real Size";
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.SlateBlue;
            this.addBtn.Location = new System.Drawing.Point(3, 8);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(53, 52);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.openImagesToolStripMenuItem_Click);
            // 
            // descBtn
            // 
            this.descBtn.FlatAppearance.BorderSize = 0;
            this.descBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descBtn.ForeColor = System.Drawing.Color.Black;
            this.descBtn.Location = new System.Drawing.Point(657, 17);
            this.descBtn.Name = "descBtn";
            this.descBtn.Size = new System.Drawing.Size(38, 35);
            this.descBtn.TabIndex = 7;
            this.descBtn.Text = "";
            this.descBtn.UseVisualStyleBackColor = true;
            this.descBtn.Click += new System.EventHandler(this.descBtn_Click);
            // 
            // rotateLeft
            // 
            this.rotateLeft.BackColor = System.Drawing.Color.LightGray;
            this.rotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateLeft.FlatAppearance.BorderSize = 0;
            this.rotateLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateLeft.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rotateLeft.Location = new System.Drawing.Point(142, 10);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(48, 49);
            this.rotateLeft.TabIndex = 6;
            this.rotateLeft.Text = "";
            this.rotateLeft.UseVisualStyleBackColor = false;
            this.rotateLeft.Click += new System.EventHandler(this.rotateMainPic);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(613, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rotateRight
            // 
            this.rotateRight.BackColor = System.Drawing.Color.LightGray;
            this.rotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateRight.FlatAppearance.BorderSize = 0;
            this.rotateRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateRight.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rotateRight.Location = new System.Drawing.Point(207, 10);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(49, 49);
            this.rotateRight.TabIndex = 5;
            this.rotateRight.Text = "";
            this.rotateRight.UseVisualStyleBackColor = false;
            this.rotateRight.Click += new System.EventHandler(this.rotateMainPic);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(454, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoomBar
            // 
            this.zoomBar.AutoSize = false;
            this.zoomBar.BackColor = System.Drawing.Color.LightGray;
            this.zoomBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomBar.Location = new System.Drawing.Point(481, 12);
            this.zoomBar.Maximum = 90;
            this.zoomBar.Minimum = -90;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(126, 22);
            this.zoomBar.TabIndex = 6;
            this.zoomBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // slideShowBtn
            // 
            this.slideShowBtn.FlatAppearance.BorderSize = 0;
            this.slideShowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.slideShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slideShowBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.slideShowBtn.Location = new System.Drawing.Point(325, 10);
            this.slideShowBtn.Name = "slideShowBtn";
            this.slideShowBtn.Size = new System.Drawing.Size(55, 49);
            this.slideShowBtn.TabIndex = 5;
            this.slideShowBtn.Text = "";
            this.slideShowBtn.UseVisualStyleBackColor = true;
            this.slideShowBtn.Click += new System.EventHandler(this.slideShowBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.FlatAppearance.BorderSize = 0;
            this.previousBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.previousBtn.Location = new System.Drawing.Point(293, 19);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(26, 31);
            this.previousBtn.TabIndex = 1;
            this.previousBtn.Text = "";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.nextPic);
            // 
            // nextBtn
            // 
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nextBtn.Location = new System.Drawing.Point(386, 19);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(28, 31);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextPic);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageFiltersToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImagesToolStripMenuItem,
            this.saveAsToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImagesToolStripMenuItem
            // 
            this.openImagesToolStripMenuItem.Name = "openImagesToolStripMenuItem";
            this.openImagesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openImagesToolStripMenuItem.Text = "Open Images..";
            this.openImagesToolStripMenuItem.Click += new System.EventHandler(this.openImagesToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As..";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageFiltersToolStripMenuItem
            // 
            this.imageFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneColorOnlyToolStripMenuItem,
            this.negativeColorToolStripMenuItem});
            this.imageFiltersToolStripMenuItem.Name = "imageFiltersToolStripMenuItem";
            this.imageFiltersToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.imageFiltersToolStripMenuItem.Text = "Image Filters";
            // 
            // oneColorOnlyToolStripMenuItem
            // 
            this.oneColorOnlyToolStripMenuItem.Name = "oneColorOnlyToolStripMenuItem";
            this.oneColorOnlyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.oneColorOnlyToolStripMenuItem.Text = "One Color Only";
            this.oneColorOnlyToolStripMenuItem.Click += new System.EventHandler(this.oneColorOnlyToolStripMenuItem_Click);
            // 
            // negativeColorToolStripMenuItem
            // 
            this.negativeColorToolStripMenuItem.Name = "negativeColorToolStripMenuItem";
            this.negativeColorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.negativeColorToolStripMenuItem.Text = "Negative Color";
            this.negativeColorToolStripMenuItem.Click += new System.EventHandler(this.negativeColorToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomSlideShowToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // randomSlideShowToolStripMenuItem
            // 
            this.randomSlideShowToolStripMenuItem.Name = "randomSlideShowToolStripMenuItem";
            this.randomSlideShowToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.randomSlideShowToolStripMenuItem.Text = "Random Slide Show";
            this.randomSlideShowToolStripMenuItem.Click += new System.EventHandler(this.randomSlideShowToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realSizeToolStripMenuItem,
            this.customToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // realSizeToolStripMenuItem
            // 
            this.realSizeToolStripMenuItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.realSizeToolStripMenuItem.Items.AddRange(new object[] {
            "RealSize",
            "16:9",
            "4:3",
            "1024x576"});
            this.realSizeToolStripMenuItem.Name = "realSizeToolStripMenuItem";
            this.realSizeToolStripMenuItem.Size = new System.Drawing.Size(152, 23);
            this.realSizeToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.realSizeToolStripMenuItem_SelectedIndexChanged);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.widthToolStripMenuItem,
            this.toolStripTextBox1,
            this.heightToolStripMenuItem,
            this.toolStripTextBox2,
            this.toolStripSeparator1,
            this.oKToolStripMenuItem});
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.Enabled = false;
            this.widthToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "600";
            // 
            // heightToolStripMenuItem
            // 
            this.heightToolStripMenuItem.Enabled = false;
            this.heightToolStripMenuItem.Name = "heightToolStripMenuItem";
            this.heightToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.heightToolStripMenuItem.Text = "Height";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "400";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // oKToolStripMenuItem
            // 
            this.oKToolStripMenuItem.Name = "oKToolStripMenuItem";
            this.oKToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.oKToolStripMenuItem.Text = "OK";
            this.oKToolStripMenuItem.Click += new System.EventHandler(this.oKToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.splitContainer1.Panel2.Controls.Add(this.switchSidePanelBtn);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.mainPicture);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 464);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 2;
            // 
            // switchSidePanelBtn
            // 
            this.switchSidePanelBtn.FlatAppearance.BorderSize = 0;
            this.switchSidePanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchSidePanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchSidePanelBtn.Location = new System.Drawing.Point(3, 3);
            this.switchSidePanelBtn.Name = "switchSidePanelBtn";
            this.switchSidePanelBtn.Size = new System.Drawing.Size(33, 34);
            this.switchSidePanelBtn.TabIndex = 2;
            this.switchSidePanelBtn.Text = "";
            this.switchSidePanelBtn.UseVisualStyleBackColor = true;
            this.switchSidePanelBtn.Click += new System.EventHandler(this.switchSidePanelBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox1.Location = new System.Drawing.Point(191, 366);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(478, 91);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Describe image here...";
            this.richTextBox1.Visible = false;
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // mainPicture
            // 
            this.mainPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPicture.Image = global::AAEergasia1.Properties.Resources.no_image;
            this.mainPicture.Location = new System.Drawing.Point(172, 16);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(519, 331);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicture.TabIndex = 0;
            this.mainPicture.TabStop = false;
            this.mainPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPicture_MouseDown);
            this.mainPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPicture_MouseMove);
            this.mainPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPicture_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files (*.jpg , *.png) | *.jpg; *.png";
            this.openFileDialog1.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "image";
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            this.saveFileDialog1.Title = "Save as..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 565);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(740, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Viewer";
            this.panel1.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button switchSidePanelBtn;
        private System.Windows.Forms.Button slideShowBtn;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem imageFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneColorOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomSlideShowToolStripMenuItem;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.Button rotateLeft;
        private System.Windows.Forms.Button descBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox realSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem heightToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label mainpicSizeLabel;
    }
}


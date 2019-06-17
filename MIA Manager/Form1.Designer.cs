namespace MIA_Manager
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.pbTexture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableAlphaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom75 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom125 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom150 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom200 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom300 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxZoom = new System.Windows.Forms.ToolStripTextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbTextures = new System.Windows.Forms.ListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fdExport = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.exportAll = new System.Windows.Forms.FolderBrowserDialog();
            this.lblMIADetail = new System.Windows.Forms.Label();
            this.importImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbTexture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTexture
            // 
            this.pbTexture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTexture.Location = new System.Drawing.Point(0, 24);
            this.pbTexture.Name = "pbTexture";
            this.pbTexture.Size = new System.Drawing.Size(128, 128);
            this.pbTexture.TabIndex = 0;
            this.pbTexture.TabStop = false;
            this.pbTexture.Click += new System.EventHandler(this.pbTexture_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToolStripMenuItem,
            this.exportAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportAllToolStripMenuItem
            // 
            this.exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
            this.exportAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.exportAllToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportAllToolStripMenuItem.Text = "Export All";
            this.exportAllToolStripMenuItem.Click += new System.EventHandler(this.exportAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableAlphaToolStripMenuItem,
            this.replaceTextureToolStripMenuItem,
            this.addTextureToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // disableAlphaToolStripMenuItem
            // 
            this.disableAlphaToolStripMenuItem.CheckOnClick = true;
            this.disableAlphaToolStripMenuItem.Name = "disableAlphaToolStripMenuItem";
            this.disableAlphaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.disableAlphaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.disableAlphaToolStripMenuItem.Text = "Disable Alpha";
            this.disableAlphaToolStripMenuItem.Click += new System.EventHandler(this.disableAlphaToolStripMenuItem_Click);
            // 
            // replaceTextureToolStripMenuItem
            // 
            this.replaceTextureToolStripMenuItem.Name = "replaceTextureToolStripMenuItem";
            this.replaceTextureToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.replaceTextureToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.replaceTextureToolStripMenuItem.Text = "Replace Texture";
            this.replaceTextureToolStripMenuItem.Click += new System.EventHandler(this.replaceTextureToolStripMenuItem_Click);
            // 
            // addTextureToolStripMenuItem
            // 
            this.addTextureToolStripMenuItem.Name = "addTextureToolStripMenuItem";
            this.addTextureToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.addTextureToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.addTextureToolStripMenuItem.Text = "Add Texture";
            this.addTextureToolStripMenuItem.Click += new System.EventHandler(this.addTextureToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemZoom50,
            this.toolStripMenuItemZoom75,
            this.toolStripMenuItemZoom100,
            this.toolStripMenuItemZoom125,
            this.toolStripMenuItemZoom150,
            this.toolStripMenuItemZoom200,
            this.toolStripMenuItemZoom300,
            this.toolStripTextBoxZoom});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItemZoom50
            // 
            this.toolStripMenuItemZoom50.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemZoom50.Name = "toolStripMenuItemZoom50";
            this.toolStripMenuItemZoom50.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad1)));
            this.toolStripMenuItemZoom50.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemZoom50.Text = "50%";
            this.toolStripMenuItemZoom50.Click += new System.EventHandler(this.toolStripMenuItemZoom50_Click);
            // 
            // toolStripMenuItemZoom75
            // 
            this.toolStripMenuItemZoom75.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemZoom75.Name = "toolStripMenuItemZoom75";
            this.toolStripMenuItemZoom75.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad2)));
            this.toolStripMenuItemZoom75.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemZoom75.Text = "75%";
            this.toolStripMenuItemZoom75.Click += new System.EventHandler(this.toolStripMenuItemZoom75_Click);
            // 
            // toolStripMenuItemZoom100
            // 
            this.toolStripMenuItemZoom100.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemZoom100.Name = "toolStripMenuItemZoom100";
            this.toolStripMenuItemZoom100.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad0)));
            this.toolStripMenuItemZoom100.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemZoom100.Text = "100%";
            this.toolStripMenuItemZoom100.Click += new System.EventHandler(this.toolStripMenuItemZoom100_Click);
            // 
            // toolStripMenuItemZoom125
            // 
            this.toolStripMenuItemZoom125.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemZoom125.Name = "toolStripMenuItemZoom125";
            this.toolStripMenuItemZoom125.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad3)));
            this.toolStripMenuItemZoom125.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemZoom125.Text = "125%";
            this.toolStripMenuItemZoom125.Click += new System.EventHandler(this.toolStripMenuItemZoom125_Click);
            // 
            // toolStripMenuItemZoom150
            // 
            this.toolStripMenuItemZoom150.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemZoom150.Name = "toolStripMenuItemZoom150";
            this.toolStripMenuItemZoom150.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad4)));
            this.toolStripMenuItemZoom150.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemZoom150.Text = "150%";
            this.toolStripMenuItemZoom150.Click += new System.EventHandler(this.toolStripMenuItemZoom150_Click);
            // 
            // toolStripMenuItemZoom200
            // 
            this.toolStripMenuItemZoom200.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemZoom200.Name = "toolStripMenuItemZoom200";
            this.toolStripMenuItemZoom200.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad5)));
            this.toolStripMenuItemZoom200.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemZoom200.Text = "200%";
            this.toolStripMenuItemZoom200.Click += new System.EventHandler(this.toolStripMenuItemZoom200_Click);
            // 
            // toolStripMenuItemZoom300
            // 
            this.toolStripMenuItemZoom300.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemZoom300.Name = "toolStripMenuItemZoom300";
            this.toolStripMenuItemZoom300.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad6)));
            this.toolStripMenuItemZoom300.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItemZoom300.Text = "300%";
            this.toolStripMenuItemZoom300.Click += new System.EventHandler(this.toolStripMenuItemZoom300_Click);
            // 
            // toolStripTextBoxZoom
            // 
            this.toolStripTextBoxZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxZoom.MaxLength = 5;
            this.toolStripTextBoxZoom.Name = "toolStripTextBoxZoom";
            this.toolStripTextBoxZoom.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxZoom.Tag = "";
            this.toolStripTextBoxZoom.ToolTipText = "Custom Zoom";
            this.toolStripTextBoxZoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxZoom_KeyPress);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "mia";
            this.openFileDialog.Filter = "MIA file|*.mia|All files|*.*";
            // 
            // lbTextures
            // 
            this.lbTextures.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTextures.FormattingEnabled = true;
            this.lbTextures.Location = new System.Drawing.Point(424, 24);
            this.lbTextures.Name = "lbTextures";
            this.lbTextures.Size = new System.Drawing.Size(200, 417);
            this.lbTextures.TabIndex = 2;
            this.lbTextures.SelectedIndexChanged += new System.EventHandler(this.lbTextures_SelectedIndexChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "MIA Texture|*.mia";
            // 
            // fdExport
            // 
            this.fdExport.Filter = "PNG Image|*.png";
            // 
            // lblMIADetail
            // 
            this.lblMIADetail.AutoSize = true;
            this.lblMIADetail.BackColor = System.Drawing.Color.Transparent;
            this.lblMIADetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMIADetail.Location = new System.Drawing.Point(0, 376);
            this.lblMIADetail.Name = "lblMIADetail";
            this.lblMIADetail.Size = new System.Drawing.Size(90, 65);
            this.lblMIADetail.TabIndex = 3;
            this.lblMIADetail.Text = "File: None loaded\r\nTextures: 0\r\nResolution: 0 x 0\r\nID: 0\r\nSize: 0 Bytes";
            // 
            // importImage
            // 
            this.importImage.DefaultExt = "png";
            this.importImage.Filter = "PNG Images|*.png|BMP Images|*.bmp|JPEG Images|*.JPEG;*.JPG";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblMIADetail);
            this.Controls.Add(this.lbTextures);
            this.Controls.Add(this.pbTexture);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(540, 320);
            this.Name = "formMain";
            this.Text = "MIA Manager";
            this.Resize += new System.EventHandler(this.formMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbTexture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTexture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox lbTextures;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog fdExport;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FolderBrowserDialog exportAll;
        private System.Windows.Forms.Label lblMIADetail;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableAlphaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom50;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom75;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom125;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom150;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom200;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom300;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxZoom;
        private System.Windows.Forms.OpenFileDialog importImage;
    }
}


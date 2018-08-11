using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace MIA_Manager
{
    public partial class formMain : Form
    {
        private List<UInt32> texturePointers;
        private Byte[] buffer;
        private DataTable textureDataTable = new DataTable("Textures");
        private bool disableAlpha;
        private String fileName;
        private float zoom;
        Bitmap texture;
        public formMain()
        {
            InitializeComponent();
            try
            {
                if (ConfigurationManager.AppSettings["backcolor"] == null)
                {
                    Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    conf.AppSettings.Settings.Add("backcolor", "#404040");
                    conf.Save();
                    ConfigurationManager.RefreshSection("AppSettings");
                }
                pbTexture.BackColor = System.Drawing.ColorTranslator.FromHtml(ConfigurationManager.AppSettings["backcolor"]);
            }
            catch(Exception ex) { }
            textureDataTable.Columns.Add("Name", typeof(String));
            textureDataTable.Columns.Add("Width", typeof(UInt16));
            textureDataTable.Columns.Add("Height", typeof(UInt16));
            textureDataTable.Columns.Add("EntryCount", typeof(UInt32));
            textureDataTable.Columns.Add("ID", typeof(UInt32));
            textureDataTable.Columns.Add("Format", typeof(UInt32));
            textureDataTable.Columns.Add("PixelData", typeof(Byte[]));
            disableAlpha = false;
            saveAsToolStripMenuItem.Enabled = false;
            exportToolStripMenuItem.Enabled = false;
            exportAllToolStripMenuItem.Enabled = false;
            addTextureToolStripMenuItem.Enabled = false;
            replaceTextureToolStripMenuItem.Enabled = false;
            zoom = 1.0f;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = openFileDialog.FileName;
                    FileStream inFile = File.Open(fileName, System.IO.FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    long fileSize = inFile.Length;
                    textureDataTable.Clear();
                    buffer = new Byte[fileSize];
                    inFile.Read(buffer, 0, (int)fileSize);
                    inFile.Close();
                    UInt16 textureCount = BitConverter.ToUInt16(buffer, 0);
                    if (textureCount > 0)
                    {
                        lbTextures.Items.Clear();
                        texturePointers = new List<UInt32>();
                        for (int i = 0; i < textureCount; i++)
                        {
                            texturePointers.Add(BitConverter.ToUInt32(buffer, (i * 4) + 4));
                        }
                        texturePointers.Add((UInt32)fileSize);
                        for(int i = 0; i < texturePointers.Count; i++)
                        {
                            if (texturePointers[i] < fileSize)
                            {
                                UInt32 _ID = BitConverter.ToUInt32(buffer, (Int32)texturePointers[i]);
                                String _name = Encoding.UTF8.GetString(buffer, (Int32)(texturePointers[i] + 0x04), 32);
                                _name = _name.TrimEnd('\0');
                                UInt32 _format = BitConverter.ToUInt32(buffer, (Int32)texturePointers[i] + 0x28);
                                UInt16 _width = BitConverter.ToUInt16(buffer, (Int32)texturePointers[i] + 0x2C);
                                UInt16 _height = BitConverter.ToUInt16(buffer, (Int32)texturePointers[i] + 0x2E);
                                UInt32 _arraySize = ((texturePointers[i + 1] - texturePointers[i]) - 0x30) / 5;
                                UInt32 _currPixel = texturePointers[i] + 0x30;
                                Byte[] _pixelData = new Byte[_arraySize * 5];
                                Buffer.BlockCopy(buffer, (Int32)_currPixel, _pixelData, 0, (Int32)_arraySize * 5);
                                textureDataTable.Rows.Add(_name, _width, _height, _arraySize, _ID, _format, _pixelData);
                                lbTextures.Items.Add(textureDataTable.Rows[i]["Name"]);
                            }
                        }
                        lbTextures.SelectedIndex = 0;
                        lbTextures.Focus();

                        saveAsToolStripMenuItem.Enabled = true;
                        exportToolStripMenuItem.Enabled = true;
                        exportAllToolStripMenuItem.Enabled = true;
                        addTextureToolStripMenuItem.Enabled = true;
                        replaceTextureToolStripMenuItem.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbTextures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(texturePointers.Count > 0)
            {
                loadTexture(lbTextures.SelectedIndex);
            }
        }

        private void loadTexture(Int32 index)
        {
            if (index < 0) return;
            UInt16 width = (UInt16)textureDataTable.Rows[index]["Width"];
            UInt16 height = (UInt16)textureDataTable.Rows[index]["Height"];
            UInt32 arraySize = (UInt32)textureDataTable.Rows[index]["EntryCount"];
            UInt32 ID = (UInt32)textureDataTable.Rows[index]["ID"];
            Byte[] _textureBuffer = new Byte[arraySize * 5];
            Buffer.BlockCopy((Byte[])textureDataTable.Rows[index]["PixelData"], 0, _textureBuffer, 0, (Int32)(arraySize * 5));
            texture = new Bitmap(width, height);
            
            UInt32 pixelOffset = 0;
            UInt32 pixelCount = 0;
            for (int i = 0; i < arraySize; i++)
            {
                UInt32 pixelEntryCount = (UInt32)(_textureBuffer[(i * 5)] + 1);
                pixelCount += pixelEntryCount;
                while (pixelEntryCount > 0)
                {
                    if ((pixelOffset / width) >= height)
                        break;
                    Byte _A = _textureBuffer[(i * 5) + 4];
                    if (disableAlpha == true)
                    {
                        if (_A != 0) _A = 255;
                    }
                    Byte _R = _textureBuffer[(i * 5) + 3];
                    Byte _G = _textureBuffer[(i * 5) + 2];
                    Byte _B = _textureBuffer[(i * 5) + 1];
                    Int32 _X = (Int32)(pixelOffset % width);
                    Int32 _Y = (Int32)(height  - (pixelOffset / width)) - 1;
                    texture.SetPixel(_X, _Y, Color.FromArgb(_A, _R, _G, _B));
                    pixelEntryCount--;
                    pixelOffset++;
                }
            }

            this.lblMIADetail.Text =
                "File: " + fileName + "\n" +
                "Textures: " + textureDataTable.Rows.Count + "\n" +
                "Resolution: " + width + " x " + height + "\n" +
                "ID: " + ID + "\n" +
                "Size: " + arraySize * 5 + " Bytes (" + pixelCount + " Pixels)";

            zoomTexture(zoom);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    String _fileName = saveFileDialog.FileName;
                    if (textureDataTable.Rows.Count == 0) return;
                    using (BinaryWriter output = new BinaryWriter(File.Open(_fileName, FileMode.Create)))
                    {
                        UInt32 ptrValue = (UInt32)(textureDataTable.Rows.Count * 4) + 4;
                        output.Write((UInt16)textureDataTable.Rows.Count);
                        output.Write((UInt16)1);
                        for (int i = 0; i < textureDataTable.Rows.Count; i++)
                        {
                            output.Write(ptrValue);
                            ptrValue += ((UInt32)textureDataTable.Rows[i]["EntryCount"] * 5) + 0x30;
                        }
                        for (int i = 0; i < textureDataTable.Rows.Count; i++)
                        {
                            output.Write((UInt32)textureDataTable.Rows[i]["ID"]);
                            Byte[] _name = new Byte[0x24];
                            Buffer.BlockCopy(System.Text.Encoding.ASCII.GetBytes((String)textureDataTable.Rows[i]["Name"]), 0, _name, 0, ((String)textureDataTable.Rows[i]["Name"]).Length);
                            output.Write(_name);
                            output.Write((UInt32)textureDataTable.Rows[i]["Format"]);
                            output.Write((UInt16)textureDataTable.Rows[i]["Width"]);
                            output.Write((UInt16)textureDataTable.Rows[i]["Height"]);
                            output.Write((Byte[])textureDataTable.Rows[i]["PixelData"], 0, (Int32)((UInt32)textureDataTable.Rows[i]["EntryCount"] * 5));
                        }
                        output.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdExport.ShowDialog() == DialogResult.OK)
            {
                texture.Save(fdExport.FileName);
            }
        }

        private void pbTexture_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                pbTexture.BackColor = colorDialog.Color;
                Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                conf.AppSettings.Settings.Remove("backcolor");
                conf.AppSettings.Settings.Add("backcolor",System.Drawing.ColorTranslator.ToHtml(colorDialog.Color));
                conf.Save();
            }
        }

        private void exportAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox exporter = new PictureBox();
            exporter.Visible = false;

            if (exportAll.ShowDialog() == DialogResult.OK)
            {
                for (int index = 0; index < textureDataTable.Rows.Count; index++)
                {
                    UInt16 width = (UInt16)textureDataTable.Rows[index]["Width"];
                    UInt16 height = (UInt16)textureDataTable.Rows[index]["Height"];
                    UInt32 arraySize = (UInt32)textureDataTable.Rows[index]["EntryCount"];
                    String textureName = (String)textureDataTable.Rows[index]["Name"];
                    Byte[] _textureBuffer = new Byte[arraySize * 5];
                    Buffer.BlockCopy((Byte[])textureDataTable.Rows[index]["PixelData"], 0, _textureBuffer, 0, (Int32)(arraySize * 5));
                    exporter.Width = width;
                    exporter.Height = height;
                    exporter.Image = new Bitmap(width, height);
                    UInt32 pixelOffset = 0;
                    for (int i = 0; i < arraySize; i++)
                    {
                        UInt32 pixelCount = (UInt32)(_textureBuffer[(i * 5)] + 1);
                        while (pixelCount > 0)
                        {
                            if ((pixelOffset / width) >= height)
                                break;
                            
                            Byte _A = _textureBuffer[(i * 5) + 4];
                            Byte _R = _textureBuffer[(i * 5) + 3];
                            Byte _G = _textureBuffer[(i * 5) + 2];
                            Byte _B = _textureBuffer[(i * 5) + 1];
                            Int32 _X = (Int32)(pixelOffset % width);
                            Int32 _Y = (Int32)((height - 1) - (pixelOffset / width));

                            if (disableAlpha == true)
                            {
                                if (_A != 0) _A = 255;
                            }

                            ((Bitmap)exporter.Image).SetPixel(_X, _Y, Color.FromArgb(_A, _R, _G, _B));
                            pixelCount--;
                            pixelOffset++;
                        }
                    }
                    string exportFile = exportAll.SelectedPath + @"\" + textureName + ".png";
                    exporter.Image.Save(exportFile);
                }
            }
            exporter = null;
        }

        private void disableAlphaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableAlpha = disableAlphaToolStripMenuItem.Checked;
            loadTexture(lbTextures.SelectedIndex);
        }

        private void formMain_Resize(object sender, EventArgs e)
        {
            lblMIADetail.BackColor = Color.Transparent;
            lblMIADetail.Update();
            lblMIADetail.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MIAAboutBox about = new MIAAboutBox();
            about.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void replaceTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(importImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String[] _textureName = importImage.FileName.Split('\\');
                    _textureName = _textureName.Last().Split('.');

                    Bitmap image = getImage(importImage.FileName);
                    if (image == null) throw new Exception("Unable to load image");
                    Int32 _pixels = image.Width * image.Height;
                    Int32 _pixelEntryCount = 0;
                    Byte[] imageBuffer = new Byte[_pixels * 5];
                    Int32 _lastColor = 0;
                    Int32 _instanceCount = 0;
                    for(int i = 0; i < _pixels; i++)
                    {
                        Int32 thisColor = image.GetPixel(i % image.Width, ((image.Height) - (i / image.Width)) - 1).ToArgb();
                        if (i == 0) _lastColor = thisColor;
                        else if (_lastColor != thisColor)
                        {
                            _instanceCount = 0;
                            _pixelEntryCount++;
                            _lastColor = thisColor;
                        }
                        else
                        {
                            _instanceCount++;
                            if (_instanceCount > ((image.Width - 1) - ((image.Width - 1) - (i % image.Width))))
                            {
                                _instanceCount = 0;
                                _pixelEntryCount++;
                            }
                        }
                        Buffer.BlockCopy(BitConverter.GetBytes(thisColor), 0, imageBuffer, (_pixelEntryCount * 5) + 1, 4);
                        imageBuffer[_pixelEntryCount * 5] = (Byte)_instanceCount;
                    }

                    Byte[] _pixelData = new Byte[(_pixelEntryCount + 1) * 5];
                    Buffer.BlockCopy(imageBuffer, 0, _pixelData, 0, _pixelData.Length);

                    imageBuffer = null;

                    if (lbTextures.SelectedIndex < 0) lbTextures.SelectedIndex = 0;
                    Int32 _selection = lbTextures.SelectedIndex;
                    textureDataTable.Rows[_selection]["Width"] = image.Width;
                    textureDataTable.Rows[_selection]["Height"] = image.Height;
                    textureDataTable.Rows[_selection]["EntryCount"] = _pixelEntryCount + 1;
                    textureDataTable.Rows[_selection]["PixelData"] = _pixelData;
                    
                    loadTexture(_selection);
                    lbTextures.SelectedIndex = _selection;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripTextBoxZoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                int customZoom;
                if (int.TryParse(toolStripTextBoxZoom.Text, out customZoom) == false)
                    customZoom = 100;
                if (customZoom < 1) customZoom = 100;

                zoom = (float)customZoom / 100.0f;
                toolsToolStripMenuItem.HideDropDown();
                zoomTexture(zoom);
            }
        }

        private void toolStripMenuItemZoom50_Click(object sender, EventArgs e)
        {
            zoom = 0.5f;
            zoomTexture(zoom);
        }

        private void toolStripMenuItemZoom75_Click(object sender, EventArgs e)
        {
            zoom = 0.75f;
            zoomTexture(zoom);
        }

        private void toolStripMenuItemZoom100_Click(object sender, EventArgs e)
        {
            zoom = 1.0f;
            zoomTexture(zoom);
        }

        private void toolStripMenuItemZoom125_Click(object sender, EventArgs e)
        {
            zoom = 1.25f;
            zoomTexture(zoom);
        }

        private void toolStripMenuItemZoom150_Click(object sender, EventArgs e)
        {
            zoom = 1.5f;
            zoomTexture(zoom);
        }

        private void toolStripMenuItemZoom200_Click(object sender, EventArgs e)
        {
            zoom = 2.0f;
            zoomTexture(zoom);
        }

        private void toolStripMenuItemZoom300_Click(object sender, EventArgs e)
        {
            zoom = 3.0f;
            zoomTexture(zoom);
        }

        private void zoomTexture(float _zoom)
        {
            if (texture != null)
            {
                Size size = new Size(
                (int)((float)texture.Width * zoom),
                (int)((float)texture.Height * zoom)
                );
                pbTexture.Width = (int)((float)texture.Width * zoom);
                pbTexture.Height = (int)((float)texture.Height * zoom);
                pbTexture.Image = new Bitmap(texture, size);
            }
        }

        private Bitmap getImage(String fileName)
        {
            return new Bitmap(fileName);
        }

        private void addTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (importImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String[] _textureName = importImage.FileName.Split('\\');
                    _textureName = _textureName.Last().Split('.');

                    Bitmap image = getImage(importImage.FileName);
                    if (image == null) throw new Exception("Unable to load image");
                    Int32 _pixels = image.Width * image.Height;
                    Int32 _pixelEntryCount = 0;
                    Byte[] imageBuffer = new Byte[_pixels * 5];
                    Int32 _lastColor = 0;
                    Int32 _instanceCount = 0;
                    for (int i = 0; i < _pixels; i++)
                    {
                        Int32 thisColor = image.GetPixel(i % image.Width, ((image.Height) - (i / image.Width)) - 1).ToArgb();
                        if (i == 0) _lastColor = thisColor;
                        else if (_lastColor != thisColor)
                        {
                            _instanceCount = 0;
                            _pixelEntryCount++;
                            _lastColor = thisColor;
                        }
                        else
                        {
                            _instanceCount++;
                            if (_instanceCount > ((image.Width - 1) - ((image.Width - 1) - (i % image.Width))))
                            {
                                _instanceCount = 0;
                                _pixelEntryCount++;
                            }
                        }
                        Buffer.BlockCopy(BitConverter.GetBytes(thisColor), 0, imageBuffer, (_pixelEntryCount * 5) + 1, 4);
                        imageBuffer[_pixelEntryCount * 5] = (Byte)_instanceCount;
                    }

                    Byte[] _pixelData = new Byte[(_pixelEntryCount + 1) * 5];
                    Buffer.BlockCopy(imageBuffer, 0, _pixelData, 0, _pixelData.Length);

                    imageBuffer = null;

                    lbTextures.Items.Add(_textureName[0]);
                    Int32 _selection = lbTextures.Items.Count - 1;
                    textureDataTable.Rows.Add(_textureName[0], image.Width, image.Height, _pixelEntryCount + 1, 0x55464F54, 0x04000000, _pixelData);
                    loadTexture(_selection);
                    lbTextures.SelectedIndex = _selection;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

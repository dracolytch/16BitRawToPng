using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace RawToRGConverter
{
    public partial class Form1 : Form
    {
        public byte[] rawBuffer;
        public Bitmap pngBuffer;
        public Dictionary<long, int> TextureSizes;

        public Form1()
        {
            InitializeComponent();
            TextureSizes = new Dictionary<long, int>();

            TextureSizes.Add(513 * 513 * 2, 513);
            TextureSizes.Add(1025 * 1025 * 2, 1025);
            TextureSizes.Add(2049 * 2049 * 2, 2049);
        }

        private string GetResolutionText(long fileSize)
        {
            if (TextureSizes.ContainsKey(fileSize) == true) return TextureSizes[fileSize].ToString() + "x" + TextureSizes[fileSize].ToString();
            else return "Unknown";
        }

        private void RawBtn_Click(object sender, EventArgs e)
        {
            OpenRaw();
        }

        private void OpenRaw()
        {
            var ofd = new OpenFileDialog();
            ofd.FileName = RawTbx.Text;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RawTbx.Text = ofd.FileName;
                OpenRaw(RawTbx.Text);
            }
        }

        private void OpenRaw(string filename)
        {
            var f = new FileInfo(filename);
            FileSizeLbl.Text = f.Length.ToString();
            ResolutionLbl.Text = GetResolutionText(f.Length);
            PngTbx.Text = PngFilenameFromRawFilename(filename);

            rawBuffer = File.ReadAllBytes(filename); // BOOM! Headshot!
            RawToPng();
        }

        private void RawToPng()
        {
            if (TextureSizes.ContainsKey(rawBuffer.Length) == false) return;

            var d = TextureSizes[rawBuffer.Length];
            pngBuffer = new Bitmap(d, d);

            // Loop over every pixel
            for (var y = 0; y < d; y++)
            {
                for (var x = 0; x < d; x++)
                {
                    var pos = (x + (y * d)) * 2;
                    pngBuffer.SetPixel(x, y, Color.FromArgb(255, rawBuffer[pos], rawBuffer[pos+1], 0));
                }
            }

            DisplayData();
        }

        private void DisplayData()
        {
            DisplayPbx.Image = pngBuffer;
            DisplayPbx.Refresh();
        }

        private void PngToRaw()
        {
            var size = pngBuffer.Width * pngBuffer.Height * 2;
            if (TextureSizes.ContainsKey(size) == false) return;

            rawBuffer = new byte[size];
            var d = TextureSizes[rawBuffer.Length];

            // Loop over every pixel
            for (var y = 0; y < d; y++)
            {
                for (var x = 0; x < d; x++)
                {
                    var pos = (x + (y * d)) * 2;
                    rawBuffer[pos] = pngBuffer.GetPixel(x, y).R;
                    rawBuffer[pos+1] = pngBuffer.GetPixel(x, y).G;
                }
            }

            DisplayData();
        }

        private void SaveRaw()
        {
            if (RawTbx.Text == "")
            {
                MessageBox.Show("Need a filename");
                return;
            }

            File.WriteAllBytes(RawTbx.Text, rawBuffer);
        }

        private string RawFilenameFromPngFilename(string pngFilename)
        {
            return pngFilename.Replace("-rg.png", ".raw");
        }

        private string PngFilenameFromRawFilename(string rawFilename)
        {
            return rawFilename.Replace(".raw", "-rg.png");
        }

        private void OpenPng()
        {
            var ofd = new OpenFileDialog();
            ofd.FileName = PngTbx.Text;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PngTbx.Text = ofd.FileName;
                OpenPng(PngTbx.Text);
            }
        }

        private void OpenPng(string filename)
        {
            pngBuffer = new Bitmap(filename);
            var dataLength = pngBuffer.Width * pngBuffer.Height * 2;
            FileSizeLbl.Text = dataLength.ToString();
            ResolutionLbl.Text = GetResolutionText(dataLength);
            RawTbx.Text = RawFilenameFromPngFilename(filename);

            PngToRaw();
        }

        private void SavePng()
        {
            if (PngTbx.Text == "")
            {
                MessageBox.Show("Can't save, no filename");
                return;
            }

            if (pngBuffer == null)
            {
                MessageBox.Show("Can't save, no png image");
                return;
            }

            pngBuffer.Save(PngTbx.Text); // Well, that was easy
        }

        private void PngBtn_Click(object sender, EventArgs e)
        {
            OpenPng();
        }

        private void SaveRawBtn_Click(object sender, EventArgs e)
        {
            SaveRaw();
        }

        private void SavePngBtn_Click(object sender, EventArgs e)
        {
            SavePng();
        }
    }
}

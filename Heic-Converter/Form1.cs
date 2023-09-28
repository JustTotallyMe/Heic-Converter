using ImageMagick;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heic_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            
            string ext = rBtn_bmp.Checked ? "bmp" : rBtn_png.Checked ? "png" : rBtn_jpg.Checked ? "jpg" : null;
            if (ext == null)
            {
                MessageBox.Show("Bitte waehlen Sie ein Format", "Format fehlt!");
            }
            else
            {
                if (txt_path.Text == "")
                {
                    MessageBox.Show("Bitte waehlen Sie zuerst einen Pfad", "Pfad fehlt!");
                }
                else
                {
                    DirectoryInfo directoryInfo_Root = new DirectoryInfo(txt_path.Text);
                    
                    if (!Directory.Exists(directoryInfo_Root.FullName + "\\" + ext.ToUpper()))
                    {
                        Directory.CreateDirectory(directoryInfo_Root.FullName + "\\" + ext.ToUpper());
                    }

                    DirectoryInfo directoryInfo_ext = new DirectoryInfo(directoryInfo_Root.FullName + "\\" + ext.ToUpper());

                    //Multithreading
                    Parallel.ForEach(directoryInfo_Root.GetFiles(), item =>
                    {
                        if (item.Extension.ToLower() == ".heic" || item.Extension.ToLower() == ".heif")
                        {
                            using (var image = new MagickImage(item.FullName))
                            {
                                switch (ext)
                                {
                                    case "jpg": image.Format = MagickFormat.Jpg; break;
                                    case "bmp": image.Format = MagickFormat.Bmp; break;
                                    case "png": image.Format = MagickFormat.Png; break;
                                }
                                
                                image.Write(directoryInfo_ext.FullName + "\\" + item.Name.Substring(0, item.Name.LastIndexOf(item.Extension)) + "." + ext);
                            }
                        }
                    });
                    MessageBox.Show("Bilder wurden konvertiert und liegen unter:\n\n" + directoryInfo_ext.FullName, "Konvertierung fertig");
                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Andreas Bergner", "Created by:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

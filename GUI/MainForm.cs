using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SteganographyLib;

namespace GUI
{
    public partial class MainForm : Form
    {
        private Bitmap loadedImage;
        private FileInfo imageInfo;
        private double maxTextKB;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblImageToEncrypt.Text = "Image to Encrypt:";
            pbSelectedImage.SizeMode = PictureBoxSizeMode.StretchImage;

            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
        }

        private void openImageToEncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string path = string.Empty;

            using (OpenFileDialog openImage = new OpenFileDialog())
            {
                result = openImage.ShowDialog(this);

                path = openImage.FileName;

                if (!string.IsNullOrEmpty(path))
                {
                    loadedImage = new Bitmap(Image.FromFile(path));
                    imageInfo = new FileInfo(path);

                    maxTextKB = (8.0 * ((loadedImage.Height * (loadedImage.Width / 3) * 3) / 3 - 1)) / 1024;
                    tbMaxMessageSize.Text = $"{Math.Floor(maxTextKB)} KB";

                    lblImageToEncrypt.Text = "Image to Encrypt:";
                    tbEncryptImagePath.Text = path;

                    pbSelectedImage.ImageLocation = path;
                    pbSelectedImage.Load();

                    btnEncrypt.Enabled = true;
                    btnDecrypt.Enabled = false;
                }
            }
        }

        private void openImageToDecryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string path = string.Empty;

            using (OpenFileDialog openImage = new OpenFileDialog())
            {
                result = openImage.ShowDialog(this);

                path = openImage.FileName;

                if (!string.IsNullOrEmpty(path))
                {
                    loadedImage = new Bitmap(Image.FromFile(path));
                    imageInfo = new FileInfo(path);

                    lblImageToEncrypt.Text = "Image to Decrypt:";
                    tbEncryptImagePath.Text = path;

                    maxTextKB = (8.0 * ((loadedImage.Height * (loadedImage.Width / 3) * 3) / 3 - 1)) / 1024;
                    tbMaxMessageSize.Text = $"{Math.Floor(maxTextKB)} KB";

                    pbSelectedImage.ImageLocation = path;
                    pbSelectedImage.Load();

                    btnEncrypt.Enabled = false;
                    btnDecrypt.Enabled = true;
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string path = string.Empty;

            if (!string.IsNullOrEmpty(tbMessage.Text))
            {
                try
                {
                    Bitmap encrypted = Steganography.Encode(tbMessage.Text, maxTextKB, loadedImage);

                    if (encrypted != null)
                    {
                        MessageBox.Show("Select a save location", "Save Encrypted Image", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        using (SaveFileDialog saveEncrypted = new SaveFileDialog())
                        {
                            saveEncrypted.ShowDialog(this);

                            path = saveEncrypted.FileName;

                            encrypted.Save(path);

                            if (!string.IsNullOrEmpty(path))
                            {
                                loadedImage = new Bitmap(Image.FromFile(path));
                                imageInfo = new FileInfo(path);

                                pbSelectedImage.ImageLocation = path;
                                pbSelectedImage.Load();

                                lblImageToEncrypt.Text = "Image Path:";

                                btnEncrypt.Enabled = false;
                                btnDecrypt.Enabled = true;

                                MessageBox.Show("Encryption and file save was successful.", "Encryption Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (loadedImage != null &&
                !string.IsNullOrEmpty(tbEncryptImagePath.Text))
            {
                try
                {
                    tbMessage.Text = Steganography.Decode(loadedImage);

                    pbSelectedImage.ImageLocation = imageInfo.FullName;
                    pbSelectedImage.Load();

                    btnEncrypt.Enabled = true;
                    btnDecrypt.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
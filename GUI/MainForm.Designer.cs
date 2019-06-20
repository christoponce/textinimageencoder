namespace GUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToEncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToDecryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblImageToEncrypt = new System.Windows.Forms.Label();
            this.tbEncryptImagePath = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lblImagePreview = new System.Windows.Forms.Label();
            this.pbSelectedImage = new System.Windows.Forms.PictureBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblMaxMessageSize = new System.Windows.Forms.Label();
            this.tbMaxMessageSize = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToEncryptToolStripMenuItem,
            this.openImageToDecryptToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToEncryptToolStripMenuItem
            // 
            this.openImageToEncryptToolStripMenuItem.Name = "openImageToEncryptToolStripMenuItem";
            this.openImageToEncryptToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openImageToEncryptToolStripMenuItem.Text = "Open Image to Encrypt";
            this.openImageToEncryptToolStripMenuItem.Click += new System.EventHandler(this.openImageToEncryptToolStripMenuItem_Click);
            // 
            // openImageToDecryptToolStripMenuItem
            // 
            this.openImageToDecryptToolStripMenuItem.Name = "openImageToDecryptToolStripMenuItem";
            this.openImageToDecryptToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openImageToDecryptToolStripMenuItem.Text = "Open Image to Decrypt";
            this.openImageToDecryptToolStripMenuItem.Click += new System.EventHandler(this.openImageToDecryptToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblImageToEncrypt
            // 
            this.lblImageToEncrypt.AutoSize = true;
            this.lblImageToEncrypt.BackColor = System.Drawing.Color.White;
            this.lblImageToEncrypt.Location = new System.Drawing.Point(13, 28);
            this.lblImageToEncrypt.Name = "lblImageToEncrypt";
            this.lblImageToEncrypt.Size = new System.Drawing.Size(90, 13);
            this.lblImageToEncrypt.TabIndex = 1;
            this.lblImageToEncrypt.Text = "Image to Encrypt:";
            // 
            // tbEncryptImagePath
            // 
            this.tbEncryptImagePath.BackColor = System.Drawing.Color.White;
            this.tbEncryptImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEncryptImagePath.Location = new System.Drawing.Point(117, 25);
            this.tbEncryptImagePath.Name = "tbEncryptImagePath";
            this.tbEncryptImagePath.ReadOnly = true;
            this.tbEncryptImagePath.Size = new System.Drawing.Size(250, 20);
            this.tbEncryptImagePath.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(13, 66);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message:";
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.Color.White;
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMessage.Location = new System.Drawing.Point(117, 63);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(250, 170);
            this.tbMessage.TabIndex = 4;
            // 
            // lblImagePreview
            // 
            this.lblImagePreview.AutoSize = true;
            this.lblImagePreview.BackColor = System.Drawing.Color.White;
            this.lblImagePreview.Location = new System.Drawing.Point(410, 28);
            this.lblImagePreview.Name = "lblImagePreview";
            this.lblImagePreview.Size = new System.Drawing.Size(80, 13);
            this.lblImagePreview.TabIndex = 5;
            this.lblImagePreview.Text = "Image Preview:";
            // 
            // pbSelectedImage
            // 
            this.pbSelectedImage.BackColor = System.Drawing.Color.White;
            this.pbSelectedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSelectedImage.Location = new System.Drawing.Point(413, 63);
            this.pbSelectedImage.Name = "pbSelectedImage";
            this.pbSelectedImage.Size = new System.Drawing.Size(225, 225);
            this.pbSelectedImage.TabIndex = 6;
            this.pbSelectedImage.TabStop = false;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.White;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Location = new System.Drawing.Point(117, 265);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(87, 23);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.White;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecrypt.Location = new System.Drawing.Point(280, 265);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(87, 23);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblMaxMessageSize
            // 
            this.lblMaxMessageSize.AutoSize = true;
            this.lblMaxMessageSize.BackColor = System.Drawing.Color.White;
            this.lblMaxMessageSize.Location = new System.Drawing.Point(12, 242);
            this.lblMaxMessageSize.Name = "lblMaxMessageSize";
            this.lblMaxMessageSize.Size = new System.Drawing.Size(99, 13);
            this.lblMaxMessageSize.TabIndex = 9;
            this.lblMaxMessageSize.Text = "Max Message Size:";
            // 
            // tbMaxMessageSize
            // 
            this.tbMaxMessageSize.BackColor = System.Drawing.Color.White;
            this.tbMaxMessageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaxMessageSize.Location = new System.Drawing.Point(117, 239);
            this.tbMaxMessageSize.Name = "tbMaxMessageSize";
            this.tbMaxMessageSize.ReadOnly = true;
            this.tbMaxMessageSize.Size = new System.Drawing.Size(250, 20);
            this.tbMaxMessageSize.TabIndex = 10;
            this.tbMaxMessageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 298);
            this.Controls.Add(this.tbMaxMessageSize);
            this.Controls.Add(this.lblMaxMessageSize);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.pbSelectedImage);
            this.Controls.Add(this.lblImagePreview);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbEncryptImagePath);
            this.Controls.Add(this.lblImageToEncrypt);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Text-in-Image Encoder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToEncryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToDecryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblImageToEncrypt;
        private System.Windows.Forms.TextBox tbEncryptImagePath;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lblImagePreview;
        private System.Windows.Forms.PictureBox pbSelectedImage;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblMaxMessageSize;
        private System.Windows.Forms.TextBox tbMaxMessageSize;
    }
}


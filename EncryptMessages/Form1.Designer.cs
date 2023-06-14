namespace EncryptMessages
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picCadeado = new PictureBox();
            btnEncrypt = new Button();
            txtKey = new TextBox();
            txtToEncrypt = new TextBox();
            txtEncrypted = new TextBox();
            lbKey = new Label();
            lbToEncrypt = new Label();
            lbEncrypted = new Label();
            txtDecrypted = new TextBox();
            lbDecrypted = new Label();
            btnDecrypt = new Button();
            btnCopy = new Button();
            ((System.ComponentModel.ISupportInitialize)picCadeado).BeginInit();
            SuspendLayout();
            // 
            // picCadeado
            // 
            picCadeado.Dock = DockStyle.Fill;
            picCadeado.Image = Properties.Resources.cadeado;
            picCadeado.Location = new Point(0, 0);
            picCadeado.Name = "picCadeado";
            picCadeado.Size = new Size(310, 287);
            picCadeado.SizeMode = PictureBoxSizeMode.StretchImage;
            picCadeado.TabIndex = 0;
            picCadeado.TabStop = false;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEncrypt.AutoEllipsis = true;
            btnEncrypt.Location = new Point(42, 12);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(214, 37);
            btnEncrypt.TabIndex = 1;
            btnEncrypt.TabStop = false;
            btnEncrypt.Text = "> Encrypt Message <";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(76, 55);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(69, 23);
            txtKey.TabIndex = 2;
            txtKey.TabStop = false;
            txtKey.TextChanged += txtKey_TextChanged;
            // 
            // txtToEncrypt
            // 
            txtToEncrypt.Location = new Point(76, 84);
            txtToEncrypt.Multiline = true;
            txtToEncrypt.Name = "txtToEncrypt";
            txtToEncrypt.Size = new Size(204, 44);
            txtToEncrypt.TabIndex = 2;
            txtToEncrypt.TabStop = false;
            txtToEncrypt.TextChanged += txtToEncrypt_TextChanged;
            // 
            // txtEncrypted
            // 
            txtEncrypted.Location = new Point(76, 136);
            txtEncrypted.Multiline = true;
            txtEncrypted.Name = "txtEncrypted";
            txtEncrypted.Size = new Size(180, 43);
            txtEncrypted.TabIndex = 2;
            txtEncrypted.TabStop = false;
            txtEncrypted.TextChanged += txtEncrypted_TextChanged;
            // 
            // lbKey
            // 
            lbKey.AutoSize = true;
            lbKey.BackColor = Color.Transparent;
            lbKey.Location = new Point(30, 63);
            lbKey.Name = "lbKey";
            lbKey.Size = new Size(29, 15);
            lbKey.TabIndex = 3;
            lbKey.Text = "Key:";
            lbKey.Click += lbKey_Click;
            // 
            // lbToEncrypt
            // 
            lbToEncrypt.AutoSize = true;
            lbToEncrypt.BackColor = Color.Transparent;
            lbToEncrypt.Location = new Point(7, 98);
            lbToEncrypt.Name = "lbToEncrypt";
            lbToEncrypt.Size = new Size(65, 15);
            lbToEncrypt.TabIndex = 3;
            lbToEncrypt.Text = "To Encrypt:";
            lbToEncrypt.Click += lbToEncrypt_Click;
            // 
            // lbEncrypted
            // 
            lbEncrypted.AutoSize = true;
            lbEncrypted.BackColor = Color.Transparent;
            lbEncrypted.Location = new Point(8, 139);
            lbEncrypted.Name = "lbEncrypted";
            lbEncrypted.Size = new Size(63, 15);
            lbEncrypted.TabIndex = 3;
            lbEncrypted.Text = "Encrypted:";
            lbEncrypted.Click += lbEncrypted_Click;
            // 
            // txtDecrypted
            // 
            txtDecrypted.Location = new Point(76, 238);
            txtDecrypted.Multiline = true;
            txtDecrypted.Name = "txtDecrypted";
            txtDecrypted.Size = new Size(204, 49);
            txtDecrypted.TabIndex = 2;
            txtDecrypted.TabStop = false;
            txtDecrypted.TextChanged += txtEncrypted_TextChanged;
            // 
            // lbDecrypted
            // 
            lbDecrypted.AutoSize = true;
            lbDecrypted.BackColor = Color.Transparent;
            lbDecrypted.Location = new Point(8, 251);
            lbDecrypted.Name = "lbDecrypted";
            lbDecrypted.Size = new Size(64, 15);
            lbDecrypted.TabIndex = 3;
            lbDecrypted.Text = "Decrypted:";
            lbDecrypted.Click += lbEncrypted_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDecrypt.Location = new Point(42, 185);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(214, 35);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.TabStop = false;
            btnDecrypt.Text = "Decrypt Message";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(255, 157);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(43, 22);
            btnCopy.TabIndex = 5;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 287);
            Controls.Add(btnCopy);
            Controls.Add(btnDecrypt);
            Controls.Add(lbDecrypted);
            Controls.Add(lbEncrypted);
            Controls.Add(lbToEncrypt);
            Controls.Add(lbKey);
            Controls.Add(txtDecrypted);
            Controls.Add(txtEncrypted);
            Controls.Add(txtToEncrypt);
            Controls.Add(txtKey);
            Controls.Add(btnEncrypt);
            Controls.Add(picCadeado);
            MaximizeBox = false;
            MaximumSize = new Size(326, 326);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(326, 326);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encrypt Messages";
            ((System.ComponentModel.ISupportInitialize)picCadeado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCadeado;
        private Button btnEncrypt;
        private TextBox txtKey;
        private TextBox txtToEncrypt;
        private TextBox txtEncrypted;
        private Label lbKey;
        private Label lbToEncrypt;
        private Label lbEncrypted;
        private TextBox txtDecrypted;
        private Label lbDecrypted;
        private Button btnDecrypt;
        private Button btnCopy;
    }
}
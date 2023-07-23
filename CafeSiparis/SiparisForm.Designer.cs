namespace CafeSiparis
{
    partial class SiparisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisForm));
            this.siparisGroupBox = new System.Windows.Forms.GroupBox();
            this.siparisiTamamlaButton = new System.Windows.Forms.Button();
            this.sifirlaButton = new System.Windows.Forms.Button();
            this.kolaEksiButton = new System.Windows.Forms.Button();
            this.kolaArtiButton = new System.Windows.Forms.Button();
            this.kolaSayisiLabel = new System.Windows.Forms.Label();
            this.kolaLabel = new System.Windows.Forms.Label();
            this.kahveEksiButton = new System.Windows.Forms.Button();
            this.kahveArtiButton = new System.Windows.Forms.Button();
            this.kahveSayisiLabel = new System.Windows.Forms.Label();
            this.kahveLabel = new System.Windows.Forms.Label();
            this.cayEksiButton = new System.Windows.Forms.Button();
            this.cayArtiButton = new System.Windows.Forms.Button();
            this.caySayisiLabel = new System.Windows.Forms.Label();
            this.cayLabel = new System.Windows.Forms.Label();
            this.siparisGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // siparisGroupBox
            // 
            this.siparisGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siparisGroupBox.Controls.Add(this.siparisiTamamlaButton);
            this.siparisGroupBox.Controls.Add(this.sifirlaButton);
            this.siparisGroupBox.Controls.Add(this.kolaEksiButton);
            this.siparisGroupBox.Controls.Add(this.kolaArtiButton);
            this.siparisGroupBox.Controls.Add(this.kolaSayisiLabel);
            this.siparisGroupBox.Controls.Add(this.kolaLabel);
            this.siparisGroupBox.Controls.Add(this.kahveEksiButton);
            this.siparisGroupBox.Controls.Add(this.kahveArtiButton);
            this.siparisGroupBox.Controls.Add(this.kahveSayisiLabel);
            this.siparisGroupBox.Controls.Add(this.kahveLabel);
            this.siparisGroupBox.Controls.Add(this.cayEksiButton);
            this.siparisGroupBox.Controls.Add(this.cayArtiButton);
            this.siparisGroupBox.Controls.Add(this.caySayisiLabel);
            this.siparisGroupBox.Controls.Add(this.cayLabel);
            this.siparisGroupBox.Location = new System.Drawing.Point(12, 12);
            this.siparisGroupBox.Name = "siparisGroupBox";
            this.siparisGroupBox.Size = new System.Drawing.Size(205, 180);
            this.siparisGroupBox.TabIndex = 0;
            this.siparisGroupBox.TabStop = false;
            this.siparisGroupBox.Text = "SİPARİŞ";
            this.siparisGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // siparisiTamamlaButton
            // 
            this.siparisiTamamlaButton.Location = new System.Drawing.Point(78, 137);
            this.siparisiTamamlaButton.Name = "siparisiTamamlaButton";
            this.siparisiTamamlaButton.Size = new System.Drawing.Size(121, 23);
            this.siparisiTamamlaButton.TabIndex = 13;
            this.siparisiTamamlaButton.Text = "SİPARİŞİ TAMAMLA";
            this.siparisiTamamlaButton.UseVisualStyleBackColor = true;
            this.siparisiTamamlaButton.Click += new System.EventHandler(this.siparisiTamamlaButton_Click);
            // 
            // sifirlaButton
            // 
            this.sifirlaButton.Location = new System.Drawing.Point(9, 137);
            this.sifirlaButton.Name = "sifirlaButton";
            this.sifirlaButton.Size = new System.Drawing.Size(63, 23);
            this.sifirlaButton.TabIndex = 12;
            this.sifirlaButton.Text = "SIFIRLA";
            this.sifirlaButton.UseVisualStyleBackColor = true;
            this.sifirlaButton.Click += new System.EventHandler(this.sifirlaButton_Click);
            // 
            // kolaEksiButton
            // 
            this.kolaEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaEksiButton.Location = new System.Drawing.Point(152, 92);
            this.kolaEksiButton.Name = "kolaEksiButton";
            this.kolaEksiButton.Size = new System.Drawing.Size(30, 23);
            this.kolaEksiButton.TabIndex = 11;
            this.kolaEksiButton.Text = "-";
            this.kolaEksiButton.UseVisualStyleBackColor = true;
            this.kolaEksiButton.Click += new System.EventHandler(this.kolaEksiButton_Click);
            // 
            // kolaArtiButton
            // 
            this.kolaArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaArtiButton.Location = new System.Drawing.Point(104, 92);
            this.kolaArtiButton.Name = "kolaArtiButton";
            this.kolaArtiButton.Size = new System.Drawing.Size(30, 23);
            this.kolaArtiButton.TabIndex = 10;
            this.kolaArtiButton.Text = "+";
            this.kolaArtiButton.UseVisualStyleBackColor = true;
            this.kolaArtiButton.Click += new System.EventHandler(this.kolaArtiButton_Click);
            // 
            // kolaSayisiLabel
            // 
            this.kolaSayisiLabel.AutoSize = true;
            this.kolaSayisiLabel.Location = new System.Drawing.Point(59, 97);
            this.kolaSayisiLabel.Name = "kolaSayisiLabel";
            this.kolaSayisiLabel.Size = new System.Drawing.Size(13, 13);
            this.kolaSayisiLabel.TabIndex = 9;
            this.kolaSayisiLabel.Text = "0";
            // 
            // kolaLabel
            // 
            this.kolaLabel.AutoSize = true;
            this.kolaLabel.Location = new System.Drawing.Point(6, 97);
            this.kolaLabel.Name = "kolaLabel";
            this.kolaLabel.Size = new System.Drawing.Size(35, 13);
            this.kolaLabel.TabIndex = 8;
            this.kolaLabel.Text = "KOLA";
            // 
            // kahveEksiButton
            // 
            this.kahveEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveEksiButton.Location = new System.Drawing.Point(152, 63);
            this.kahveEksiButton.Name = "kahveEksiButton";
            this.kahveEksiButton.Size = new System.Drawing.Size(30, 23);
            this.kahveEksiButton.TabIndex = 7;
            this.kahveEksiButton.Text = "-";
            this.kahveEksiButton.UseVisualStyleBackColor = true;
            this.kahveEksiButton.Click += new System.EventHandler(this.kahveEksiButton_Click);
            // 
            // kahveArtiButton
            // 
            this.kahveArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveArtiButton.Location = new System.Drawing.Point(104, 63);
            this.kahveArtiButton.Name = "kahveArtiButton";
            this.kahveArtiButton.Size = new System.Drawing.Size(30, 23);
            this.kahveArtiButton.TabIndex = 6;
            this.kahveArtiButton.Text = "+";
            this.kahveArtiButton.UseVisualStyleBackColor = true;
            this.kahveArtiButton.Click += new System.EventHandler(this.kahveArtiButton_Click);
            // 
            // kahveSayisiLabel
            // 
            this.kahveSayisiLabel.AutoSize = true;
            this.kahveSayisiLabel.Location = new System.Drawing.Point(59, 68);
            this.kahveSayisiLabel.Name = "kahveSayisiLabel";
            this.kahveSayisiLabel.Size = new System.Drawing.Size(13, 13);
            this.kahveSayisiLabel.TabIndex = 5;
            this.kahveSayisiLabel.Text = "0";
            // 
            // kahveLabel
            // 
            this.kahveLabel.AutoSize = true;
            this.kahveLabel.Location = new System.Drawing.Point(6, 68);
            this.kahveLabel.Name = "kahveLabel";
            this.kahveLabel.Size = new System.Drawing.Size(43, 13);
            this.kahveLabel.TabIndex = 4;
            this.kahveLabel.Text = "KAHVE";
            // 
            // cayEksiButton
            // 
            this.cayEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayEksiButton.Location = new System.Drawing.Point(152, 34);
            this.cayEksiButton.Name = "cayEksiButton";
            this.cayEksiButton.Size = new System.Drawing.Size(30, 23);
            this.cayEksiButton.TabIndex = 3;
            this.cayEksiButton.Text = "-";
            this.cayEksiButton.UseVisualStyleBackColor = true;
            this.cayEksiButton.Click += new System.EventHandler(this.cayEksiButton_Click);
            // 
            // cayArtiButton
            // 
            this.cayArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayArtiButton.Location = new System.Drawing.Point(104, 34);
            this.cayArtiButton.Name = "cayArtiButton";
            this.cayArtiButton.Size = new System.Drawing.Size(30, 23);
            this.cayArtiButton.TabIndex = 2;
            this.cayArtiButton.Text = "+";
            this.cayArtiButton.UseVisualStyleBackColor = true;
            this.cayArtiButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // caySayisiLabel
            // 
            this.caySayisiLabel.AutoSize = true;
            this.caySayisiLabel.Location = new System.Drawing.Point(59, 39);
            this.caySayisiLabel.Name = "caySayisiLabel";
            this.caySayisiLabel.Size = new System.Drawing.Size(13, 13);
            this.caySayisiLabel.TabIndex = 1;
            this.caySayisiLabel.Text = "0";
            // 
            // cayLabel
            // 
            this.cayLabel.AutoSize = true;
            this.cayLabel.Location = new System.Drawing.Point(6, 39);
            this.cayLabel.Name = "cayLabel";
            this.cayLabel.Size = new System.Drawing.Size(28, 13);
            this.cayLabel.TabIndex = 0;
            this.cayLabel.Text = "ÇAY";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 202);
            this.Controls.Add(this.siparisGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xCafe";
            this.siparisGroupBox.ResumeLayout(false);
            this.siparisGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox siparisGroupBox;
        private System.Windows.Forms.Button cayArtiButton;
        private System.Windows.Forms.Label caySayisiLabel;
        private System.Windows.Forms.Label cayLabel;
        private System.Windows.Forms.Button kolaEksiButton;
        private System.Windows.Forms.Button kolaArtiButton;
        private System.Windows.Forms.Label kolaSayisiLabel;
        private System.Windows.Forms.Label kolaLabel;
        private System.Windows.Forms.Button kahveEksiButton;
        private System.Windows.Forms.Button kahveArtiButton;
        private System.Windows.Forms.Label kahveSayisiLabel;
        private System.Windows.Forms.Label kahveLabel;
        private System.Windows.Forms.Button cayEksiButton;
        private System.Windows.Forms.Button siparisiTamamlaButton;
        private System.Windows.Forms.Button sifirlaButton;
    }
}



namespace WindowsFormsApp3
{
    partial class anaForm
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
            this.btnBilgi = new System.Windows.Forms.Button();
            this.btnKoltukSeç = new System.Windows.Forms.Button();
            this.btnTarihSeç = new System.Windows.Forms.Button();
            this.btnYolcuBilgi = new System.Windows.Forms.Button();
            this.btnSeferBilgi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBilgi
            // 
            this.btnBilgi.Location = new System.Drawing.Point(23, 54);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(148, 90);
            this.btnBilgi.TabIndex = 0;
            this.btnBilgi.Text = "firma hakkında bilgi";
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKoltukSeç
            // 
            this.btnKoltukSeç.Location = new System.Drawing.Point(94, 173);
            this.btnKoltukSeç.Name = "btnKoltukSeç";
            this.btnKoltukSeç.Size = new System.Drawing.Size(148, 90);
            this.btnKoltukSeç.TabIndex = 1;
            this.btnKoltukSeç.Text = "otobüs koltuğu seçiniz";
            this.btnKoltukSeç.UseVisualStyleBackColor = true;
            this.btnKoltukSeç.Click += new System.EventHandler(this.btnKoltukSeç_Click);
            // 
            // btnTarihSeç
            // 
            this.btnTarihSeç.Location = new System.Drawing.Point(294, 173);
            this.btnTarihSeç.Name = "btnTarihSeç";
            this.btnTarihSeç.Size = new System.Drawing.Size(148, 90);
            this.btnTarihSeç.TabIndex = 2;
            this.btnTarihSeç.Text = "tarih seçiniz";
            this.btnTarihSeç.UseVisualStyleBackColor = true;
            this.btnTarihSeç.Click += new System.EventHandler(this.btnTarihSeç_Click);
            // 
            // btnYolcuBilgi
            // 
            this.btnYolcuBilgi.Location = new System.Drawing.Point(211, 54);
            this.btnYolcuBilgi.Name = "btnYolcuBilgi";
            this.btnYolcuBilgi.Size = new System.Drawing.Size(148, 90);
            this.btnYolcuBilgi.TabIndex = 3;
            this.btnYolcuBilgi.Text = "Yolcu bilgileri";
            this.btnYolcuBilgi.UseVisualStyleBackColor = true;
            this.btnYolcuBilgi.Click += new System.EventHandler(this.btnYolcuBilgi_Click);
            // 
            // btnSeferBilgi
            // 
            this.btnSeferBilgi.Location = new System.Drawing.Point(386, 54);
            this.btnSeferBilgi.Name = "btnSeferBilgi";
            this.btnSeferBilgi.Size = new System.Drawing.Size(148, 90);
            this.btnSeferBilgi.TabIndex = 4;
            this.btnSeferBilgi.Text = "Sefer Bilgileri";
            this.btnSeferBilgi.UseVisualStyleBackColor = true;
            this.btnSeferBilgi.Click += new System.EventHandler(this.btnSeferBilgi_Click);
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(560, 289);
            this.Controls.Add(this.btnSeferBilgi);
            this.Controls.Add(this.btnYolcuBilgi);
            this.Controls.Add(this.btnTarihSeç);
            this.Controls.Add(this.btnKoltukSeç);
            this.Controls.Add(this.btnBilgi);
            this.Name = "anaForm";
            this.Text = "pamukkale otobüs bileti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Button btnKoltukSeç;
        private System.Windows.Forms.Button btnTarihSeç;
        private System.Windows.Forms.Button btnYolcuBilgi;
        private System.Windows.Forms.Button btnSeferBilgi;
    }
}


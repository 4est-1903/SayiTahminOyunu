namespace stajornek14
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblsecilen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttahmin = new System.Windows.Forms.TextBox();
            this.btntahmin = new System.Windows.Forms.Button();
            this.lblrandom = new System.Windows.Forms.Label();
            this.lblyanlis1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lblhata1 = new System.Windows.Forms.Label();
            this.lblhata2 = new System.Windows.Forms.Label();
            this.lblhata3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(155, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seçilen Sayı:";
            // 
            // lblsecilen
            // 
            this.lblsecilen.AutoSize = true;
            this.lblsecilen.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsecilen.ForeColor = System.Drawing.Color.Red;
            this.lblsecilen.Location = new System.Drawing.Point(403, 132);
            this.lblsecilen.Name = "lblsecilen";
            this.lblsecilen.Size = new System.Drawing.Size(34, 39);
            this.lblsecilen.TabIndex = 1;
            this.lblsecilen.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahmin:";
            // 
            // txttahmin
            // 
            this.txttahmin.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttahmin.ForeColor = System.Drawing.Color.Red;
            this.txttahmin.Location = new System.Drawing.Point(343, 213);
            this.txttahmin.Name = "txttahmin";
            this.txttahmin.Size = new System.Drawing.Size(161, 47);
            this.txttahmin.TabIndex = 3;
            this.txttahmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btntahmin
            // 
            this.btntahmin.BackColor = System.Drawing.Color.Black;
            this.btntahmin.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntahmin.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btntahmin.Location = new System.Drawing.Point(235, 316);
            this.btntahmin.Name = "btntahmin";
            this.btntahmin.Size = new System.Drawing.Size(219, 50);
            this.btntahmin.TabIndex = 4;
            this.btntahmin.Text = "Tahmin Et";
            this.btntahmin.UseVisualStyleBackColor = false;
            this.btntahmin.Click += new System.EventHandler(this.btntahmin_Click);
            // 
            // lblrandom
            // 
            this.lblrandom.AutoSize = true;
            this.lblrandom.Enabled = false;
            this.lblrandom.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrandom.ForeColor = System.Drawing.Color.Red;
            this.lblrandom.Location = new System.Drawing.Point(386, 67);
            this.lblrandom.Name = "lblrandom";
            this.lblrandom.Size = new System.Drawing.Size(68, 39);
            this.lblrandom.TabIndex = 8;
            this.lblrandom.Text = "???";
            this.lblrandom.Visible = false;
            // 
            // lblyanlis1
            // 
            this.lblyanlis1.AutoSize = true;
            this.lblyanlis1.Enabled = false;
            this.lblyanlis1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyanlis1.ForeColor = System.Drawing.Color.Red;
            this.lblyanlis1.Location = new System.Drawing.Point(12, 554);
            this.lblyanlis1.Name = "lblyanlis1";
            this.lblyanlis1.Size = new System.Drawing.Size(34, 39);
            this.lblyanlis1.TabIndex = 9;
            this.lblyanlis1.Text = "0";
            this.lblyanlis1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(228, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Puan:";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.ForeColor = System.Drawing.Color.Red;
            this.lblpuan.Location = new System.Drawing.Point(403, 473);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(34, 39);
            this.lblpuan.TabIndex = 13;
            this.lblpuan.Text = "0";
            // 
            // lblhata1
            // 
            this.lblhata1.AutoSize = true;
            this.lblhata1.Enabled = false;
            this.lblhata1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhata1.ForeColor = System.Drawing.Color.Red;
            this.lblhata1.Location = new System.Drawing.Point(283, 382);
            this.lblhata1.Name = "lblhata1";
            this.lblhata1.Size = new System.Drawing.Size(34, 39);
            this.lblhata1.TabIndex = 15;
            this.lblhata1.Text = "0";
            this.lblhata1.Visible = false;
            // 
            // lblhata2
            // 
            this.lblhata2.AutoSize = true;
            this.lblhata2.Enabled = false;
            this.lblhata2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhata2.ForeColor = System.Drawing.Color.Red;
            this.lblhata2.Location = new System.Drawing.Point(323, 382);
            this.lblhata2.Name = "lblhata2";
            this.lblhata2.Size = new System.Drawing.Size(34, 39);
            this.lblhata2.TabIndex = 16;
            this.lblhata2.Text = "0";
            this.lblhata2.Visible = false;
            // 
            // lblhata3
            // 
            this.lblhata3.AutoSize = true;
            this.lblhata3.Enabled = false;
            this.lblhata3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhata3.ForeColor = System.Drawing.Color.Red;
            this.lblhata3.Location = new System.Drawing.Point(363, 382);
            this.lblhata3.Name = "lblhata3";
            this.lblhata3.Size = new System.Drawing.Size(34, 39);
            this.lblhata3.TabIndex = 17;
            this.lblhata3.Text = "0";
            this.lblhata3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(686, 602);
            this.Controls.Add(this.lblhata3);
            this.Controls.Add(this.lblhata2);
            this.Controls.Add(this.lblhata1);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblyanlis1);
            this.Controls.Add(this.lblrandom);
            this.Controls.Add(this.btntahmin);
            this.Controls.Add(this.txttahmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsecilen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsecilen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttahmin;
        private System.Windows.Forms.Button btntahmin;
        private System.Windows.Forms.Label lblrandom;
        private System.Windows.Forms.Label lblyanlis1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblhata1;
        private System.Windows.Forms.Label lblhata2;
        private System.Windows.Forms.Label lblhata3;
    }
}


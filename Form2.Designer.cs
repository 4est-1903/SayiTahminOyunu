namespace stajornek14
{
    partial class Form2
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
            this.btntekrar = new System.Windows.Forms.Button();
            this.lblbasarmadin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntekrar
            // 
            this.btntekrar.BackColor = System.Drawing.Color.Black;
            this.btntekrar.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntekrar.ForeColor = System.Drawing.Color.IndianRed;
            this.btntekrar.Location = new System.Drawing.Point(329, 236);
            this.btntekrar.Name = "btntekrar";
            this.btntekrar.Size = new System.Drawing.Size(219, 50);
            this.btntekrar.TabIndex = 8;
            this.btntekrar.Text = "Tekrar Dene";
            this.btntekrar.UseVisualStyleBackColor = false;
            this.btntekrar.Click += new System.EventHandler(this.btntekrar_Click);
            // 
            // lblbasarmadin
            // 
            this.lblbasarmadin.AutoSize = true;
            this.lblbasarmadin.Font = new System.Drawing.Font("Impact", 36F);
            this.lblbasarmadin.Location = new System.Drawing.Point(289, 139);
            this.lblbasarmadin.Name = "lblbasarmadin";
            this.lblbasarmadin.Size = new System.Drawing.Size(300, 60);
            this.lblbasarmadin.TabIndex = 15;
            this.lblbasarmadin.Text = "BAŞARAMADIN";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 455);
            this.Controls.Add(this.lblbasarmadin);
            this.Controls.Add(this.btntekrar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntekrar;
        private System.Windows.Forms.Label lblbasarmadin;
    }
}
namespace ThreadFormUygulama
{
    partial class Form1
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
            this.btnSari = new System.Windows.Forms.Button();
            this.btnYesil = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSari
            // 
            this.btnSari.Location = new System.Drawing.Point(142, 165);
            this.btnSari.Name = "btnSari";
            this.btnSari.Size = new System.Drawing.Size(75, 23);
            this.btnSari.TabIndex = 0;
            this.btnSari.Text = "Sarı";
            this.btnSari.UseVisualStyleBackColor = true;
            this.btnSari.Click += new System.EventHandler(this.btnSari_Click);
            // 
            // btnYesil
            // 
            this.btnYesil.Location = new System.Drawing.Point(278, 164);
            this.btnYesil.Name = "btnYesil";
            this.btnYesil.Size = new System.Drawing.Size(75, 23);
            this.btnYesil.TabIndex = 1;
            this.btnYesil.Text = "Yeşil";
            this.btnYesil.UseVisualStyleBackColor = true;
            this.btnYesil.Click += new System.EventHandler(this.btnYesil_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(413, 164);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "Kırmızı";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnYesil);
            this.Controls.Add(this.btnSari);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSari;
        private System.Windows.Forms.Button btnYesil;
        private System.Windows.Forms.Button btnRed;
    }
}


namespace Project
{
    partial class fme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fme));
            this.about = new System.Windows.Forms.Label();
            this.backme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Font = new System.Drawing.Font("Impact", 16F);
            this.about.ForeColor = System.Drawing.Color.Navy;
            this.about.Location = new System.Drawing.Point(23, 9);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(305, 189);
            this.about.TabIndex = 0;
            this.about.Text = "Код программы \"Морской бой\"\r\nнаписал ученик k0224 группы\r\nКапралов Егор\r\n\r\nПрогра" +
    "мма написана для\r\nзащиты моего проекта\r\nпо программированию на C#\r\n";
            this.about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backme
            // 
            this.backme.Font = new System.Drawing.Font("Impact", 16F);
            this.backme.Location = new System.Drawing.Point(128, 209);
            this.backme.Name = "backme";
            this.backme.Size = new System.Drawing.Size(88, 37);
            this.backme.TabIndex = 1;
            this.backme.Text = "Назад";
            this.backme.UseVisualStyleBackColor = true;
            this.backme.Click += new System.EventHandler(this.backme_Click);
            // 
            // fme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(350, 258);
            this.Controls.Add(this.backme);
            this.Controls.Add(this.about);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Об авторе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Button backme;
    }
}
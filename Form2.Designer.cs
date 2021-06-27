namespace Project
{
    partial class fhelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fhelp));
            this.phelp = new System.Windows.Forms.PictureBox();
            this.lhelp = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.elhelp = new System.Windows.Forms.Label();
            this.yhelp = new System.Windows.Forms.Label();
            this.hl1 = new System.Windows.Forms.Label();
            this.hl2 = new System.Windows.Forms.Label();
            this.hl3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phelp)).BeginInit();
            this.SuspendLayout();
            // 
            // phelp
            // 
            this.phelp.Image = global::Project.Properties.Resources.help1;
            this.phelp.Location = new System.Drawing.Point(55, 159);
            this.phelp.Name = "phelp";
            this.phelp.Size = new System.Drawing.Size(700, 333);
            this.phelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.phelp.TabIndex = 0;
            this.phelp.TabStop = false;
            // 
            // lhelp
            // 
            this.lhelp.AutoSize = true;
            this.lhelp.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lhelp.ForeColor = System.Drawing.Color.Navy;
            this.lhelp.Location = new System.Drawing.Point(114, 48);
            this.lhelp.Name = "lhelp";
            this.lhelp.Size = new System.Drawing.Size(526, 78);
            this.lhelp.TabIndex = 1;
            this.lhelp.Text = "Сразу же после начала игры вам требуется расставить\r\nкорабли на вашем поле. Делае" +
    "тся это нажатием левой\r\nкнопки мыши по ячейке вашего поля\r\n";
            this.lhelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Impact", 15.75F);
            this.back.Location = new System.Drawing.Point(12, 563);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(79, 36);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Impact", 15.75F);
            this.next.Location = new System.Drawing.Point(350, 541);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(124, 58);
            this.next.TabIndex = 3;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // elhelp
            // 
            this.elhelp.AutoSize = true;
            this.elhelp.Font = new System.Drawing.Font("Impact", 15.75F);
            this.elhelp.ForeColor = System.Drawing.Color.Navy;
            this.elhelp.Location = new System.Drawing.Point(153, 507);
            this.elhelp.Name = "elhelp";
            this.elhelp.Size = new System.Drawing.Size(172, 26);
            this.elhelp.TabIndex = 4;
            this.elhelp.Text = "Поле противника";
            this.elhelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yhelp
            // 
            this.yhelp.AutoSize = true;
            this.yhelp.Font = new System.Drawing.Font("Impact", 15.75F);
            this.yhelp.ForeColor = System.Drawing.Color.Navy;
            this.yhelp.Location = new System.Drawing.Point(528, 507);
            this.yhelp.Name = "yhelp";
            this.yhelp.Size = new System.Drawing.Size(112, 26);
            this.yhelp.TabIndex = 5;
            this.yhelp.Text = "Ваше поле";
            // 
            // hl1
            // 
            this.hl1.AutoSize = true;
            this.hl1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.hl1.Font = new System.Drawing.Font("Impact", 28F);
            this.hl1.ForeColor = System.Drawing.Color.Navy;
            this.hl1.Location = new System.Drawing.Point(481, 195);
            this.hl1.Name = "hl1";
            this.hl1.Size = new System.Drawing.Size(159, 46);
            this.hl1.TabIndex = 6;
            this.hl1.Text = "Корабль";
            this.hl1.Visible = false;
            // 
            // hl2
            // 
            this.hl2.AutoSize = true;
            this.hl2.Font = new System.Drawing.Font("Impact", 28F);
            this.hl2.ForeColor = System.Drawing.Color.Navy;
            this.hl2.Location = new System.Drawing.Point(481, 295);
            this.hl2.Name = "hl2";
            this.hl2.Size = new System.Drawing.Size(141, 46);
            this.hl2.TabIndex = 7;
            this.hl2.Text = "Промах";
            this.hl2.Visible = false;
            // 
            // hl3
            // 
            this.hl3.AutoSize = true;
            this.hl3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.hl3.Font = new System.Drawing.Font("Impact", 28F);
            this.hl3.ForeColor = System.Drawing.Color.Navy;
            this.hl3.Location = new System.Drawing.Point(481, 405);
            this.hl3.Name = "hl3";
            this.hl3.Size = new System.Drawing.Size(202, 46);
            this.hl3.TabIndex = 8;
            this.hl3.Text = "Попадание";
            this.hl3.Visible = false;
            // 
            // fhelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(828, 611);
            this.Controls.Add(this.hl3);
            this.Controls.Add(this.hl2);
            this.Controls.Add(this.hl1);
            this.Controls.Add(this.yhelp);
            this.Controls.Add(this.elhelp);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lhelp);
            this.Controls.Add(this.phelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fhelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Правила";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fhelp_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.phelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox phelp;
        private System.Windows.Forms.Label lhelp;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label elhelp;
        private System.Windows.Forms.Label yhelp;
        private System.Windows.Forms.Label hl1;
        private System.Windows.Forms.Label hl2;
        private System.Windows.Forms.Label hl3;
    }
}
namespace Project
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.start = new System.Windows.Forms.Button();
            this.pole1 = new System.Windows.Forms.Panel();
            this.pole2 = new System.Windows.Forms.Panel();
            this.lscore = new System.Windows.Forms.Label();
            this.lshot = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.sound = new System.Windows.Forms.ToolStripMenuItem();
            this.bcolor = new System.Windows.Forms.ToolStripMenuItem();
            this.skyblue = new System.Windows.Forms.ToolStripMenuItem();
            this.white = new System.Windows.Forms.ToolStripMenuItem();
            this.black = new System.Windows.Forms.ToolStripMenuItem();
            this.barv = new System.Windows.Forms.ToolStripMenuItem();
            this.darkblue = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.rules = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutme = new System.Windows.Forms.ToolStripMenuItem();
            this.res = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Impact", 15.75F);
            this.start.Location = new System.Drawing.Point(345, 405);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(78, 31);
            this.start.TabIndex = 53;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pole1
            // 
            this.pole1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.pole1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pole1.Location = new System.Drawing.Point(400, 79);
            this.pole1.Name = "pole1";
            this.pole1.Size = new System.Drawing.Size(300, 300);
            this.pole1.TabIndex = 54;
            // 
            // pole2
            // 
            this.pole2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.pole2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pole2.Location = new System.Drawing.Point(60, 79);
            this.pole2.Name = "pole2";
            this.pole2.Size = new System.Drawing.Size(300, 300);
            this.pole2.TabIndex = 55;
            // 
            // lscore
            // 
            this.lscore.AutoSize = true;
            this.lscore.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lscore.ForeColor = System.Drawing.Color.Navy;
            this.lscore.Location = new System.Drawing.Point(625, 407);
            this.lscore.Name = "lscore";
            this.lscore.Size = new System.Drawing.Size(0, 26);
            this.lscore.TabIndex = 56;
            this.lscore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lshot
            // 
            this.lshot.AutoSize = true;
            this.lshot.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lshot.ForeColor = System.Drawing.Color.Navy;
            this.lshot.Location = new System.Drawing.Point(55, 410);
            this.lshot.Name = "lshot";
            this.lshot.Size = new System.Drawing.Size(0, 26);
            this.lshot.TabIndex = 57;
            this.lshot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Impact", 15.75F);
            this.status.ForeColor = System.Drawing.Color.Navy;
            this.status.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.status.Location = new System.Drawing.Point(188, 24);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(390, 26);
            this.status.TabIndex = 58;
            this.status.Text = "Нажмите кнопку \'Старт\' для начала игры";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings,
            this.help});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 59;
            // 
            // settings
            // 
            this.settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sound,
            this.bcolor});
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(79, 20);
            this.settings.Text = "Настройки";
            // 
            // sound
            // 
            this.sound.Checked = true;
            this.sound.CheckOnClick = true;
            this.sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(132, 22);
            this.sound.Text = "Звук";
            this.sound.CheckedChanged += new System.EventHandler(this.sound_CheckedChange);
            // 
            // bcolor
            // 
            this.bcolor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skyblue,
            this.white,
            this.black,
            this.barv,
            this.darkblue});
            this.bcolor.Name = "bcolor";
            this.bcolor.Size = new System.Drawing.Size(132, 22);
            this.bcolor.Text = "Цвет фона";
            this.bcolor.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bcolor_DropDownItemClicked);
            // 
            // skyblue
            // 
            this.skyblue.Checked = true;
            this.skyblue.CheckOnClick = true;
            this.skyblue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skyblue.Name = "skyblue";
            this.skyblue.Size = new System.Drawing.Size(173, 22);
            this.skyblue.Text = "Небесно-голубой";
            // 
            // white
            // 
            this.white.CheckOnClick = true;
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(173, 22);
            this.white.Text = "Белый";
            // 
            // black
            // 
            this.black.CheckOnClick = true;
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(173, 22);
            this.black.Text = "Чёрный";
            // 
            // barv
            // 
            this.barv.CheckOnClick = true;
            this.barv.Name = "barv";
            this.barv.Size = new System.Drawing.Size(173, 22);
            this.barv.Text = "Барвинок";
            // 
            // darkblue
            // 
            this.darkblue.CheckOnClick = true;
            this.darkblue.Name = "darkblue";
            this.darkblue.Size = new System.Drawing.Size(173, 22);
            this.darkblue.Text = "Тёмно-синий";
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rules,
            this.aboutme});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(65, 20);
            this.help.Text = "Справка";
            // 
            // rules
            // 
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(180, 22);
            this.rules.Text = "Правила";
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // aboutme
            // 
            this.aboutme.Name = "aboutme";
            this.aboutme.Size = new System.Drawing.Size(180, 22);
            this.aboutme.Text = "Об авторе";
            this.aboutme.Click += new System.EventHandler(this.aboutme_Click);
            // 
            // res
            // 
            this.res.Enabled = false;
            this.res.Font = new System.Drawing.Font("Impact", 15.75F);
            this.res.Location = new System.Drawing.Point(336, 405);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(97, 33);
            this.res.TabIndex = 60;
            this.res.Text = "Сдаться";
            this.res.UseVisualStyleBackColor = true;
            this.res.Visible = false;
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.res);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lshot);
            this.Controls.Add(this.lscore);
            this.Controls.Add(this.pole2);
            this.Controls.Add(this.pole1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской бой";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel pole1;
        private System.Windows.Forms.Panel pole2;
        private System.Windows.Forms.Label lscore;
        private System.Windows.Forms.Label lshot;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem sound;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem bcolor;
        private System.Windows.Forms.ToolStripMenuItem skyblue;
        private System.Windows.Forms.ToolStripMenuItem white;
        private System.Windows.Forms.ToolStripMenuItem black;
        private System.Windows.Forms.ToolStripMenuItem barv;
        private System.Windows.Forms.ToolStripMenuItem darkblue;
        private System.Windows.Forms.ToolStripMenuItem rules;
        private System.Windows.Forms.ToolStripMenuItem aboutme;
        private System.Windows.Forms.Button res;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Project
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }
        int s, score, scorev, shot, kln, q;
        int sd = 1;
        Random myRnd = new Random();
        SoundPlayer popal = new SoundPlayer(Properties.Resources.explosion);
        SoundPlayer promah = new SoundPlayer(Properties.Resources.mimo);
        //объявляю все переменные
        private void Form1_Load(object sender, EventArgs e)
        {
            pole2.Enabled = false;
        }
        private void klv_Click(object sender, EventArgs e)
        {
            PictureBox klv = (PictureBox)sender;
            //проверка на то куда мы стреляем
            if (klv.BackgroundImage == null)
            {
                status.Text = "Идёт игра";
                shot++;
                lshot.Text = "Выстрелов: " + Convert.ToInt32(shot);
                //если в ячейке был корабль то засчитывается очко и он становится подбитым
                if (Convert.ToInt32(klv.Tag) == 2)
                {
                    klv.BackgroundImage = Properties.Resources.popadanie;
                    score++;
                    klv.Tag = 3;
                    //воспроизведение звука если он включен
                    if (sd == 1)
                    {
                        popal.Play();
                    }
                }
                //если корабля не было то появляется крестик
                else
                {
                    klv.BackgroundImage = Properties.Resources.krest;
                    //воспроизведение звука
                    if (sd==1)
                    {
                        promah.Play();
                    }
                }
                //если мы достигаем 10 очков то игра завершается
                if (score == 10)
                {
                    pole2.Enabled = false;
                    start.Enabled = true;
                    status.Text = "Игра окончена! Вы победили!\nНажмите кнопку 'Старт' для повторной игры";
                }
                else
                {
                    //компьютер выбирает новую ячейку отличную от предыдущих
                    do
                    {
                        kln = myRnd.Next(0, 99);
                    }
                    while (Convert.ToInt32(pole1.Controls[kln].Tag) == 3 || Convert.ToInt32(pole1.Controls[kln].Tag) == 1);
                    //если там был корабль то он становится подбитым и дается очко компьютеру
                    if (Convert.ToInt32(pole1.Controls[kln].Tag) == 2)
                    {
                        pole1.Controls[kln].BackgroundImage = Properties.Resources.popadanie;
                        pole1.Controls[kln].Tag = 3;
                        scorev++;
                    }
                    //если там ничего не было то ставится крестик
                    if (Convert.ToInt32(pole1.Controls[kln].Tag) == 0)
                    {
                        pole1.Controls[kln].BackgroundImage = Properties.Resources.krest;
                        pole1.Controls[kln].Tag = 1;
                    }
                    //если компьютер достигает 10 очков то игра завершается
                    if (scorev == 10)
                    {
                        L();
                        res.Visible = false;
                        res.Enabled = false;
                        start.Enabled = true;
                        start.Visible = true;
                    }
                }
            }
            //объявление счета
            lscore.Text = "Счет: " + Convert.ToInt32(scorev) + ":" + Convert.ToInt32(score);
        }
        private void kl_Click(object sender, EventArgs e)
        {
            PictureBox kl = (PictureBox)sender;
            s++;
            //если количество поставленных конраблей 10 то игра начинается
            if (s == 10)
            {
                status.Text = "Игра началась! Уничтожьте все корабли противника";
                pole1.Enabled = false;
                pole2.Enabled = true;
                res.Visible = true;
                res.Enabled = true;
                lshot.Text = "Выстрелов: " + Convert.ToInt32(shot);
                lscore.Text = "Счет: " + Convert.ToInt32(scorev) + ":" + Convert.ToInt32(score);
            }
            kl.BackgroundImage = Properties.Resources.ship;
            kl.Tag = 2;
            kl.Enabled = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            //обнуление всех переменных и подготовка к началу новой игры
            start.Enabled = false;
            start.Visible = false;
            status.Text = "Расставьте 10 кораблей по вашему полю";
            lscore.Text = null;
            lshot.Text = null;
            pole1.Enabled = true;
            int p, k, i, x, y, t;
            t = 0;
            x = 0;
            y = 0;
            p = 1;
            Random myRnd1 = new Random();
            List<int> shipv = new List<int>();
            shipv.Clear();
            pole1.Controls.Clear();
            pole2.Controls.Clear();
            s = 0;
            score = 0;
            scorev = 0;
            shot = 0;
            kln = 0;
            //компьютер выбирает 10 не повторяющихся ячеек для кораблей
            for (i = 1; i < 11; i++)
            {
                do
                {
                    t = myRnd1.Next(1, 100);
                }
                while (shipv.Contains(t) == true);
                shipv.Add(t);
            }
            for (k = 0; k < 10; k++)
            {
                //создание ячеек нашего поля
                for (i = 1; i < 11; i++)
                {
                    PictureBox kl = new PictureBox();
                    kl.Click += new System.EventHandler(this.kl_Click);
                    kl.MouseEnter += new System.EventHandler(this.kl_MouseEnter);
                    kl.MouseLeave += new System.EventHandler(this.kl_MouseLeave);
                    kl.SizeMode = PictureBoxSizeMode.StretchImage;
                    kl.BackColor = Color.FromArgb(127, 199, 255);
                    kl.Width = 30;
                    kl.Height = 30;
                    kl.Location = new Point(x, y);
                    kl.BorderStyle = BorderStyle.FixedSingle;
                    pole1.Controls.Add(kl);
                    kl.Name = "kl" + p;
                    x += 30;
                    p++;
                }
                y += 30;
                x = 0;
            }
            y = 0;
            p = 1;
            for (k = 0; k < 10; k++)
            {
                //создание ячеек поля врага
                for (i = 1; i < 11; i++)
                {
                    PictureBox klv = new PictureBox();
                    klv.Click += new System.EventHandler(this.klv_Click);
                    klv.MouseEnter += new System.EventHandler(this.klv_MouseEnter);
                    klv.MouseLeave += new System.EventHandler(this.klv_MouseLeave);
                    //если номер который выбрал компьютер совпадает с номером ячейки то в этой ячейке появится корабль
                    if (shipv.ElementAt(0) ==  p || shipv.ElementAt(1) == p || shipv.ElementAt(2) == p || shipv.ElementAt(3) == p || shipv.ElementAt(4) == p || shipv.ElementAt(5) == p || shipv.ElementAt(6) == p || shipv.ElementAt(7) == p || shipv.ElementAt(8) == p || shipv.ElementAt(9) == p)
                    {
                        klv.Tag = 2;
                    }
                    klv.SizeMode = PictureBoxSizeMode.StretchImage;
                    klv.BackColor = Color.FromArgb(127, 199, 255);
                    klv.Width = 30;
                    klv.Height = 30;
                    klv.Location = new Point(x, y);
                    klv.BorderStyle = BorderStyle.FixedSingle;
                    pole2.Controls.Add(klv);
                    klv.Name = "klv" + p;
                    x += 30;
                    p++;
                }
                y += 30;
                x = 0;
            }
            y = 0;
            p = 1;
            start.Enabled = false;
        }
        private void kl_MouseEnter(object sender, EventArgs e)
        {
            PictureBox kl = (PictureBox)sender;
            //при ведении мышки над вашим полем появляется корабль с уменьшенной прозрачностью
            if (s != 10)
            {
                kl.BackgroundImage = Properties.Resources.ship2;
            }
        }

        private void res_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сдаться?", "Сдаться", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //завершение игры и показ всех кораблей противника
                L();
                for (q = 0; q < 100; q++)
                {
                    if (Convert.ToInt32(pole1.Controls[q].Tag) == 2)
                    {
                        pole1.Controls[q].BackgroundImage = Properties.Resources.popadanie;
                    }
                }
                //воспроизведение звук
                if (sd == 1)
                {
                    popal.Play();
                }
                res.Visible = false;
                res.Enabled = false;
                start.Enabled = true;
                start.Visible = true;
            }
        }

        private void kl_MouseLeave(object sender, EventArgs e)
        {
            PictureBox kl = (PictureBox)sender;
            //когда мышь покидает ячейку то полупрозрачный корабль исчезает
            if (Convert.ToInt32(kl.Tag) != 2)
            {
                kl.BackgroundImage = null;
            }
        }

        private void rules_Click(object sender, EventArgs e)
        {
            //перенос на форму с правилами
            fhelp myFrm = new fhelp();
            myFrm.Show();
            this.Hide();
        }

        private void aboutme_Click(object sender, EventArgs e)
        {
            //перенос на форму с информацией об авторе
            fme myFrm3 = new fme();
            this.Hide();
            myFrm3.Show();
        }

        private void klv_MouseEnter(object sender, EventArgs e)
        {
            //появление прицела при наведении на поле противника
            PictureBox klv = (PictureBox)sender;
            klv.Image = Properties.Resources.aim;
        }
        private void klv_MouseLeave(object sender, EventArgs e)
        {
            //удаление прицела из ячейки
            PictureBox klv = (PictureBox)sender;
            klv.Image = null;
        }
        private void sound_CheckedChange(object sender, EventArgs e)
        {
            //включение и выключение звука
            if (sound.Checked==true)
            {
                sd = 1;
            }
            else
            {
                sd = 0;
            }
        }
        private void bcolor_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //смена цвета фона и цвета шрифта
            if (skyblue.Selected)
            {
                black.Checked = false;
                white.Checked = false;
                barv.Checked = false;
                darkblue.Checked = false;
                this.BackColor = Color.FromArgb(0, 191, 255);
                lshot.ForeColor = Color.FromArgb(0, 0, 128);
                status.ForeColor = Color.FromArgb(0, 0, 128);
                lscore.ForeColor = Color.FromArgb(0, 0, 128);
            }
            if (black.Selected)
            {
                skyblue.Checked = false;
                white.Checked = false;
                barv.Checked = false;
                darkblue.Checked = false;
                this.BackColor = Color.FromArgb(0, 0, 0);
                lshot.ForeColor = Color.FromArgb(255, 255, 255);
                status.ForeColor = Color.FromArgb(255, 255, 255);
                lscore.ForeColor = Color.FromArgb(255, 255, 255);
            }
            if (white.Selected)
            {
                black.Checked = false;
                skyblue.Checked = false;
                barv.Checked = false;
                darkblue.Checked = false;
                this.BackColor = Color.FromArgb(255, 255, 255);
                lshot.ForeColor = Color.FromArgb(0, 0, 0);
                status.ForeColor = Color.FromArgb(0, 0, 0);
                lscore.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if (barv.Selected)
            {
                black.Checked = false;
                white.Checked = false;
                skyblue.Checked = false;
                darkblue.Checked = false;
                this.BackColor = Color.FromArgb(204, 204, 255);
                lshot.ForeColor = Color.FromArgb(93, 118, 203);
                status.ForeColor = Color.FromArgb(93, 118, 203);
                lscore.ForeColor = Color.FromArgb(93, 118, 203);
            }
            if (darkblue.Selected)
            {
                black.Checked = false;
                white.Checked = false;
                barv.Checked = false;
                skyblue.Checked = false;
                this.BackColor = Color.FromArgb(0, 0, 128);
                lshot.ForeColor = Color.FromArgb(0, 191, 255);
                status.ForeColor = Color.FromArgb(0, 191, 255);
                lscore.ForeColor = Color.FromArgb(0, 191, 255);
            }
        }
        private void L()
        {
            //кусочек повторяющегося кода записанный в виде метода
            for (q = 0; q < 100; q++)
            {
                if (Convert.ToInt32(pole2.Controls[q].Tag) == 2)
                {
                    pole2.Controls[q].BackgroundImage = Properties.Resources.ship;
                }
            }
            pole2.Enabled = false;
            start.Enabled = true;
            status.Text = "Игра окончена! Победил компьютер...\nНажмите кнопку 'Старт' для повторной игры";
        }
    }
}

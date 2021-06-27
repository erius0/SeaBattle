using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class fhelp : Form
    {
        public fhelp()
        {
            InitializeComponent();
        }
        int i = 0;
        private void back_Click(object sender, EventArgs e)
        {
            //закрытие формы с правилами и возвращение на первоначальную форму
            form myFrm2 = new form();
            myFrm2.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            //смена событий при нажатии на кнопку после определенного кол-во нажатий
            if (i == 0)
            {
                phelp.Image = Properties.Resources.help2;
                lhelp.Text = "Компьютер случайным образом расставляет корабли по своему полю\nЦель игры: уничтожить все корабли противника\nНажатием левой кнопки мыши вы можете подбить вражеский корабль";
            }
            if (i == 1)
            {
                phelp.Image = Properties.Resources.help3;
                lhelp.Text = "Корабль обозначается небольшой желто-оранжевой точкой на поле\rВ случае промаха на месте клика появится красный крестик\rВ случае попадания по кораблю появится красная звездочка\rПобеждает тот, кто первее уничтожит все вражеские корабли";
                next.Text = "Назад";
                back.Visible = false;
                back.Enabled = false;
                elhelp.Text = null;
                yhelp.Text = null;
                hl1.Visible = true;
                hl2.Visible = true;
                hl3.Visible = true;
            }
            if (i == 2)
            {
                //закрытие формы с правилами и возвращение на первоначальную форму
                form myFrm2 = new form();
                this.Close();
                myFrm2.Show();
            }
            i++;
        }

        private void fhelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

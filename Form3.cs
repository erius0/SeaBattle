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
    public partial class fme : Form
    {
        public fme()
        {
            InitializeComponent();
        }

        private void backme_Click(object sender, EventArgs e)
        {
            //закрытие формы с информацией обо мне и возвращение к исходной форме
            form myFrm2 = new form();
            this.Close();
            myFrm2.Show();
        }
    }
}

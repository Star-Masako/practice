using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 中英打練習
{
    public partial class Form紀錄 : Form
    {

        public Form紀錄()
        {
            InitializeComponent();
            紀錄();
        }
        private void 紀錄() 
        {
            lblOutput3.Text +="\n"+Form遊戲畫面.instance.s紀錄.ToString();
        }

        private void Form紀錄_load(object sender, EventArgs e)
        {
        }


        private void btnClean3_Click(object sender, EventArgs e)
        {
            lblOutput3.Text = "---------------------------------";
        }
                   
        private void btnIndex3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

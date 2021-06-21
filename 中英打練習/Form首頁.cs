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
    public partial class Form首頁 : Form
    {

        public Form首頁()
        {
            InitializeComponent();
        }

        private void Form首頁_Load(object sender, EventArgs e)
        {
            cboLanguage.SelectedIndex = 0; //預設為中文
            cboDifficult.SelectedIndex = 1;  //預設為中等
            cboTime.SelectedIndex = 0; //預設為60秒
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此程式為中英打練習器\n選擇完語言、難易度、時間，方可開始遊玩\n依照上方文字內容，在下方輸入框輸入相同文字，將會幫玩家計算時間內輸入多少字，及正確率", "遊玩說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form遊戲畫面 f1 = new Form遊戲畫面();  //示例項化一個 Form遊戲畫面 視窗
            f1.lblTimeSet2.Text = cboTime.Text;  //設置 Form遊戲畫面 中 lblTimeSet2 的值
            f1.lblDifficult2.Text = cboDifficult.Text;  //設置 Form遊戲畫面 中 lblDifficult2 的值
            f1.lblLanguage2.Text = cboLanguage.Text;  //設置 Form遊戲畫面 中 lblLanguage2 的值
            f1.ShowDialog();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Form紀錄 f2 = new Form紀錄();
            f2.Visible = true;
        }
    }
}

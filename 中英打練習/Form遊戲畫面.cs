using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;



namespace 中英打練習
{
    public partial class Form遊戲畫面 : Form
    {
        public static Form遊戲畫面 instance;
        int t1 = 0;
        double a正確數 = 0, a完成率 = 0;
        public string s紀錄,m紀錄;
        public Form遊戲畫面()
        {
            InitializeComponent();
        }

        private void Form遊戲畫面_Load(object sender, EventArgs e)
        {
            t1 = Convert.ToInt32(lblTimeSet2.Text);
            OpenFileDialog openFile1 = new OpenFileDialog();  //創建一個 OpenFileDialog 來請求打開一個文件
            richArticle2.LoadFile("文章\\" + lblDifficult2.Text + lblLanguage2.Text + ".txt", RichTextBoxStreamType.PlainText);  // 將文件內容加載到 richArticle2 中
            System.IO.StreamReader srNoEncode = new System.IO.StreamReader("文章\\" + lblDifficult2.Text + lblLanguage2.Text + ".txt");
            richArticle2.Text = srNoEncode.ReadToEnd();
            instance = this;

        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            richArticle2.Enabled = true;
            Timer1.Enabled = true;
            txtInput2.Enabled = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            if (t1 != 0)
            {
                t1 -= 1;
                lblTimeSet2.Text = Convert.ToString(t1);
            }
            else if (t1 == 0)
            {
                Timer1.Enabled = false;
                int len = txtInput2.Text.Length;
                for (int i = 0; i < len; i++)
                {
                    if (txtInput2.Text.Substring(0, i) == richArticle2.Text.Substring(0, i))
                    {
                        a正確數 += 1;
                    }
                }
                a完成率 = (a正確數 / richArticle2.Text.Length) * 100;
                a完成率 = Math.Round(a完成率, 2);
                var result = MessageBox.Show("您一共打了 " + len + " 個字，完成率 " + a完成率 + " %\n再接再厲!!", "練習結束",    //問答視窗內容及標題
                                 MessageBoxButtons.OK,              //問答視窗內選項
                                 MessageBoxIcon.None);          //問答視窗內的圖案     
                s紀錄 += "\n字數 " + len + " 個字，完成率 " + a完成率;
                this.Visible = false;
                //m紀錄 += s紀錄;

            }
        }

        private void lblDifficult2_Click(object sender, EventArgs e)
        {

        }

        private void btnLeave2_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            int len = txtInput2.Text.Length;
            for (int i = 0; i < len+1; i++)
            {
                if (txtInput2.Text.Substring(0, i) == richArticle2.Text.Substring(0, i))
                {
                    a正確數 += 1;
                }
            }
            a完成率 = (a正確數 / richArticle2.Text.Length) * 100;
            a完成率 = Math.Round(a完成率, 2);         
            s紀錄 += "\n字數 " + len + " 個字，完成率 " + a完成率;
            //m紀錄 += s紀錄;


            var result = MessageBox.Show("您一共打了 " + len + " 個字，完成率 " + a完成率 + " %\n再接再厲!!", "練習結束",    //問答視窗內容及標題
                             MessageBoxButtons.OK,              //問答視窗內選項
                             MessageBoxIcon.None);          //問答視窗內的圖案     
            //Form紀錄 f2 = new Form紀錄();
            //f2.lblOutput3.Text += s紀錄;
            //f2.ShowDialog();
            this.Visible = false;
        }
    }
}

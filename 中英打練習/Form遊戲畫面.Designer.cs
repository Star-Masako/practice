namespace 中英打練習
{
    partial class Form遊戲畫面
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
            this.components = new System.ComponentModel.Container();
            this.btnLeave2 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.lblTimeSet2 = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.richArticle2 = new System.Windows.Forms.RichTextBox();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblSecond2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblDifficult2 = new System.Windows.Forms.Label();
            this.lblLanguage2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeave2
            // 
            this.btnLeave2.Location = new System.Drawing.Point(619, 24);
            this.btnLeave2.Name = "btnLeave2";
            this.btnLeave2.Size = new System.Drawing.Size(97, 23);
            this.btnLeave2.TabIndex = 14;
            this.btnLeave2.Text = "提前結束";
            this.btnLeave2.UseVisualStyleBackColor = true;
            this.btnLeave2.Click += new System.EventHandler(this.btnLeave2_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(296, 24);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(75, 23);
            this.btnStart2.TabIndex = 13;
            this.btnStart2.Text = "開始";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // lblTimeSet2
            // 
            this.lblTimeSet2.AutoSize = true;
            this.lblTimeSet2.Location = new System.Drawing.Point(485, 28);
            this.lblTimeSet2.Name = "lblTimeSet2";
            this.lblTimeSet2.Size = new System.Drawing.Size(21, 15);
            this.lblTimeSet2.TabIndex = 20;
            this.lblTimeSet2.Text = "60";
            // 
            // txtInput2
            // 
            this.txtInput2.Enabled = false;
            this.txtInput2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInput2.Location = new System.Drawing.Point(193, 401);
            this.txtInput2.Multiline = true;
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(622, 298);
            this.txtInput2.TabIndex = 11;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // richArticle2
            // 
            this.richArticle2.Enabled = false;
            this.richArticle2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richArticle2.Location = new System.Drawing.Point(193, 53);
            this.richArticle2.Name = "richArticle2";
            this.richArticle2.Size = new System.Drawing.Size(622, 289);
            this.richArticle2.TabIndex = 16;
            this.richArticle2.Text = "";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(442, 28);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(37, 15);
            this.lblTime2.TabIndex = 18;
            this.lblTime2.Text = "時間";
            // 
            // lblSecond2
            // 
            this.lblSecond2.AutoSize = true;
            this.lblSecond2.Location = new System.Drawing.Point(523, 28);
            this.lblSecond2.Name = "lblSecond2";
            this.lblSecond2.Size = new System.Drawing.Size(22, 15);
            this.lblSecond2.TabIndex = 19;
            this.lblSecond2.Text = "秒";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblDifficult2
            // 
            this.lblDifficult2.AutoSize = true;
            this.lblDifficult2.Location = new System.Drawing.Point(879, 62);
            this.lblDifficult2.Name = "lblDifficult2";
            this.lblDifficult2.Size = new System.Drawing.Size(37, 15);
            this.lblDifficult2.TabIndex = 20;
            this.lblDifficult2.Text = "難度";
            this.lblDifficult2.Click += new System.EventHandler(this.lblDifficult2_Click);
            // 
            // lblLanguage2
            // 
            this.lblLanguage2.AutoSize = true;
            this.lblLanguage2.Location = new System.Drawing.Point(879, 111);
            this.lblLanguage2.Name = "lblLanguage2";
            this.lblLanguage2.Size = new System.Drawing.Size(37, 15);
            this.lblLanguage2.TabIndex = 20;
            this.lblLanguage2.Text = "語言";
            // 
            // Form遊戲畫面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 742);
            this.Controls.Add(this.lblLanguage2);
            this.Controls.Add(this.lblDifficult2);
            this.Controls.Add(this.lblSecond2);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.richArticle2);
            this.Controls.Add(this.btnLeave2);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.lblTimeSet2);
            this.Controls.Add(this.txtInput2);
            this.Name = "Form遊戲畫面";
            this.Text = "中英打練習";
            this.Load += new System.EventHandler(this.Form遊戲畫面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnLeave2;
        internal System.Windows.Forms.Button btnStart2;
        internal System.Windows.Forms.Label lblTimeSet2;
        internal System.Windows.Forms.TextBox txtInput2;
        internal System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.RichTextBox richArticle2;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblSecond2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Label lblDifficult2;
        internal System.Windows.Forms.Label lblLanguage2;
    }
}
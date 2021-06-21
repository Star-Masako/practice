namespace 中英打練習
{
    partial class Form首頁
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboDifficult = new System.Windows.Forms.ComboBox();
            this.lblDifficult = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNote = new System.Windows.Forms.Button();
            this.lblSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(554, 343);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(121, 39);
            this.btnLeave.TabIndex = 19;
            this.btnLeave.Text = "離開";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(175, 343);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(121, 39);
            this.btnRecord.TabIndex = 18;
            this.btnRecord.Text = "查看紀錄";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(370, 326);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 56);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboTime
            // 
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "60",
            "180",
            "300"});
            this.cboTime.Location = new System.Drawing.Point(554, 248);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(63, 23);
            this.cboTime.TabIndex = 16;
            this.cboTime.Text = "60";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(551, 209);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 15);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "時間";
            // 
            // cboDifficult
            // 
            this.cboDifficult.FormattingEnabled = true;
            this.cboDifficult.Items.AddRange(new object[] {
            "簡單",
            "中等",
            "困難"});
            this.cboDifficult.Location = new System.Drawing.Point(370, 248);
            this.cboDifficult.Name = "cboDifficult";
            this.cboDifficult.Size = new System.Drawing.Size(121, 23);
            this.cboDifficult.TabIndex = 14;
            this.cboDifficult.Text = "中等";
            // 
            // lblDifficult
            // 
            this.lblDifficult.AutoSize = true;
            this.lblDifficult.Location = new System.Drawing.Point(367, 209);
            this.lblDifficult.Name = "lblDifficult";
            this.lblDifficult.Size = new System.Drawing.Size(37, 15);
            this.lblDifficult.TabIndex = 13;
            this.lblDifficult.Text = "難度";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(172, 209);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(37, 15);
            this.lblLanguage.TabIndex = 12;
            this.lblLanguage.Text = "文字";
            // 
            // cboLanguage
            // 
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "中文",
            "英文"});
            this.cboLanguage.Location = new System.Drawing.Point(175, 248);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(121, 23);
            this.cboLanguage.TabIndex = 11;
            this.cboLanguage.Text = "中文";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(317, 119);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 40);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "中英打練習";
            // 
            // btnNote
            // 
            this.btnNote.Location = new System.Drawing.Point(569, 132);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(106, 28);
            this.btnNote.TabIndex = 20;
            this.btnNote.Text = "說明";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(623, 251);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(22, 15);
            this.lblSecond.TabIndex = 21;
            this.lblSecond.Text = "秒";
            // 
            // Form首頁
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 518);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cboDifficult);
            this.Controls.Add(this.lblDifficult);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form首頁";
            this.Text = "中英打練習";
            this.Load += new System.EventHandler(this.Form首頁_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnLeave;
        internal System.Windows.Forms.Button btnRecord;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.ComboBox cboTime;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.ComboBox cboDifficult;
        internal System.Windows.Forms.Label lblDifficult;
        internal System.Windows.Forms.Label lblLanguage;
        internal System.Windows.Forms.ComboBox cboLanguage;
        internal System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Label lblSecond;
    }
}


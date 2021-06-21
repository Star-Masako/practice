namespace 中英打練習
{
    partial class Form紀錄
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
            this.btnClean3 = new System.Windows.Forms.Button();
            this.btnIndex3 = new System.Windows.Forms.Button();
            this.lblOutput3 = new System.Windows.Forms.Label();
            this.lblRecord3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClean3
            // 
            this.btnClean3.Location = new System.Drawing.Point(381, 330);
            this.btnClean3.Name = "btnClean3";
            this.btnClean3.Size = new System.Drawing.Size(75, 60);
            this.btnClean3.TabIndex = 7;
            this.btnClean3.Text = "清除紀錄";
            this.btnClean3.UseVisualStyleBackColor = true;
            this.btnClean3.Click += new System.EventHandler(this.btnClean3_Click);
            // 
            // btnIndex3
            // 
            this.btnIndex3.Location = new System.Drawing.Point(477, 330);
            this.btnIndex3.Name = "btnIndex3";
            this.btnIndex3.Size = new System.Drawing.Size(75, 60);
            this.btnIndex3.TabIndex = 6;
            this.btnIndex3.Text = "回到首頁";
            this.btnIndex3.UseVisualStyleBackColor = true;
            this.btnIndex3.Click += new System.EventHandler(this.btnIndex3_Click);
            // 
            // lblOutput3
            // 
            this.lblOutput3.AutoSize = true;
            this.lblOutput3.Location = new System.Drawing.Point(77, 91);
            this.lblOutput3.Name = "lblOutput3";
            this.lblOutput3.Size = new System.Drawing.Size(172, 15);
            this.lblOutput3.TabIndex = 5;
            this.lblOutput3.Text = "---------------------------------";
            // 
            // lblRecord3
            // 
            this.lblRecord3.AutoSize = true;
            this.lblRecord3.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRecord3.Location = new System.Drawing.Point(87, 46);
            this.lblRecord3.Name = "lblRecord3";
            this.lblRecord3.Size = new System.Drawing.Size(147, 33);
            this.lblRecord3.TabIndex = 4;
            this.lblRecord3.Text = "練習紀錄";
            // 
            // Form紀錄
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.btnClean3);
            this.Controls.Add(this.btnIndex3);
            this.Controls.Add(this.lblOutput3);
            this.Controls.Add(this.lblRecord3);
            this.Name = "Form紀錄";
            this.Text = "中英打練習";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnClean3;
        internal System.Windows.Forms.Button btnIndex3;
        internal System.Windows.Forms.Label lblOutput3;
        internal System.Windows.Forms.Label lblRecord3;
    }
}
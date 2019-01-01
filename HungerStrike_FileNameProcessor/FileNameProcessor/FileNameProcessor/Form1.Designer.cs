namespace FileNameProcessor
{
    partial class Form1
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
            this.textBox_EnterFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_StartDayDate = new System.Windows.Forms.TextBox();
            this.textBox_StartDayMonth = new System.Windows.Forms.TextBox();
            this.textBox_StartDayYear = new System.Windows.Forms.TextBox();
            this.textBox_EndDayYear = new System.Windows.Forms.TextBox();
            this.textBox_EndDayMonth = new System.Windows.Forms.TextBox();
            this.textBox_EndDayDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Debug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_EnterFileName
            // 
            this.textBox_EnterFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnterFileName.Location = new System.Drawing.Point(13, 55);
            this.textBox_EnterFileName.Name = "textBox_EnterFileName";
            this.textBox_EnterFileName.Size = new System.Drawing.Size(306, 31);
            this.textBox_EnterFileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type in file name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Extract Dates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Day Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Day Month:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start Day Year:";
            // 
            // textBox_StartDayDate
            // 
            this.textBox_StartDayDate.BackColor = System.Drawing.Color.White;
            this.textBox_StartDayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StartDayDate.Location = new System.Drawing.Point(182, 155);
            this.textBox_StartDayDate.Name = "textBox_StartDayDate";
            this.textBox_StartDayDate.ReadOnly = true;
            this.textBox_StartDayDate.Size = new System.Drawing.Size(138, 31);
            this.textBox_StartDayDate.TabIndex = 6;
            // 
            // textBox_StartDayMonth
            // 
            this.textBox_StartDayMonth.BackColor = System.Drawing.Color.White;
            this.textBox_StartDayMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StartDayMonth.Location = new System.Drawing.Point(182, 193);
            this.textBox_StartDayMonth.Name = "textBox_StartDayMonth";
            this.textBox_StartDayMonth.ReadOnly = true;
            this.textBox_StartDayMonth.Size = new System.Drawing.Size(138, 31);
            this.textBox_StartDayMonth.TabIndex = 7;
            // 
            // textBox_StartDayYear
            // 
            this.textBox_StartDayYear.BackColor = System.Drawing.Color.White;
            this.textBox_StartDayYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StartDayYear.Location = new System.Drawing.Point(182, 231);
            this.textBox_StartDayYear.Name = "textBox_StartDayYear";
            this.textBox_StartDayYear.ReadOnly = true;
            this.textBox_StartDayYear.Size = new System.Drawing.Size(138, 31);
            this.textBox_StartDayYear.TabIndex = 8;
            // 
            // textBox_EndDayYear
            // 
            this.textBox_EndDayYear.BackColor = System.Drawing.Color.White;
            this.textBox_EndDayYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EndDayYear.Location = new System.Drawing.Point(182, 373);
            this.textBox_EndDayYear.Name = "textBox_EndDayYear";
            this.textBox_EndDayYear.ReadOnly = true;
            this.textBox_EndDayYear.Size = new System.Drawing.Size(138, 31);
            this.textBox_EndDayYear.TabIndex = 14;
            // 
            // textBox_EndDayMonth
            // 
            this.textBox_EndDayMonth.BackColor = System.Drawing.Color.White;
            this.textBox_EndDayMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EndDayMonth.Location = new System.Drawing.Point(182, 335);
            this.textBox_EndDayMonth.Name = "textBox_EndDayMonth";
            this.textBox_EndDayMonth.ReadOnly = true;
            this.textBox_EndDayMonth.Size = new System.Drawing.Size(138, 31);
            this.textBox_EndDayMonth.TabIndex = 13;
            // 
            // textBox_EndDayDate
            // 
            this.textBox_EndDayDate.BackColor = System.Drawing.Color.White;
            this.textBox_EndDayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EndDayDate.Location = new System.Drawing.Point(182, 297);
            this.textBox_EndDayDate.Name = "textBox_EndDayDate";
            this.textBox_EndDayDate.ReadOnly = true;
            this.textBox_EndDayDate.Size = new System.Drawing.Size(138, 31);
            this.textBox_EndDayDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Day Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "End Day Month:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "End Day Date:";
            // 
            // textBox_Debug
            // 
            this.textBox_Debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Debug.Location = new System.Drawing.Point(13, 428);
            this.textBox_Debug.Name = "textBox_Debug";
            this.textBox_Debug.Size = new System.Drawing.Size(306, 31);
            this.textBox_Debug.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 476);
            this.Controls.Add(this.textBox_Debug);
            this.Controls.Add(this.textBox_EndDayYear);
            this.Controls.Add(this.textBox_EndDayMonth);
            this.Controls.Add(this.textBox_EndDayDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_StartDayYear);
            this.Controls.Add(this.textBox_StartDayMonth);
            this.Controls.Add(this.textBox_StartDayDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_EnterFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "HungerStrikes: Menu File Name Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_EnterFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_StartDayDate;
        private System.Windows.Forms.TextBox textBox_StartDayMonth;
        private System.Windows.Forms.TextBox textBox_StartDayYear;
        private System.Windows.Forms.TextBox textBox_EndDayYear;
        private System.Windows.Forms.TextBox textBox_EndDayMonth;
        private System.Windows.Forms.TextBox textBox_EndDayDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Debug;
    }
}


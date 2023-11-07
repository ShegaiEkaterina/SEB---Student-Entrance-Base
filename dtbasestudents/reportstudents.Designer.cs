namespace dtbasestudents
{
    partial class reportstudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportstudents));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelTotalRespectful = new System.Windows.Forms.Label();
            this.labelTotalFree = new System.Windows.Forms.Label();
            this.labelTotalSick = new System.Windows.Forms.Label();
            this.labelTotalExcused = new System.Windows.Forms.Label();
            this.labelTotalAbsent = new System.Windows.Forms.Label();
            this.labelTotalPresent = new System.Windows.Forms.Label();
            this.labelTotalStudents = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(358, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(659, 388);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Отчет о посещаемости студентов:\n\nКолледж/Институт/Организация: \nКурс/Мероприятие:" +
    " \nПериод: \n\nПреподаватель/Организатор: \nГруппа/Мероприятие: \n\nОбщая посещаемость" +
    " группы/мероприятия:\n\n\nКомментарии:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(659, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Вставить выбранную дату";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Вставить текущую дату";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Вставить шаблон";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(179, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "Вставить статистику о посещаемости";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelTotalRespectful
            // 
            this.labelTotalRespectful.AutoSize = true;
            this.labelTotalRespectful.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalRespectful.Location = new System.Drawing.Point(8, 421);
            this.labelTotalRespectful.Name = "labelTotalRespectful";
            this.labelTotalRespectful.Size = new System.Drawing.Size(229, 21);
            this.labelTotalRespectful.TabIndex = 13;
            this.labelTotalRespectful.Text = "По уважительной причине:";
            // 
            // labelTotalFree
            // 
            this.labelTotalFree.AutoSize = true;
            this.labelTotalFree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalFree.Location = new System.Drawing.Point(8, 400);
            this.labelTotalFree.Name = "labelTotalFree";
            this.labelTotalFree.Size = new System.Drawing.Size(195, 21);
            this.labelTotalFree.TabIndex = 12;
            this.labelTotalFree.Text = "Свободное посещение:";
            // 
            // labelTotalSick
            // 
            this.labelTotalSick.AutoSize = true;
            this.labelTotalSick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSick.Location = new System.Drawing.Point(8, 379);
            this.labelTotalSick.Name = "labelTotalSick";
            this.labelTotalSick.Size = new System.Drawing.Size(107, 21);
            this.labelTotalSick.TabIndex = 11;
            this.labelTotalSick.Text = "По болезни:";
            // 
            // labelTotalExcused
            // 
            this.labelTotalExcused.AutoSize = true;
            this.labelTotalExcused.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalExcused.Location = new System.Drawing.Point(8, 358);
            this.labelTotalExcused.Name = "labelTotalExcused";
            this.labelTotalExcused.Size = new System.Drawing.Size(85, 21);
            this.labelTotalExcused.TabIndex = 10;
            this.labelTotalExcused.Text = "Отпущен:";
            // 
            // labelTotalAbsent
            // 
            this.labelTotalAbsent.AutoSize = true;
            this.labelTotalAbsent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalAbsent.Location = new System.Drawing.Point(8, 337);
            this.labelTotalAbsent.Name = "labelTotalAbsent";
            this.labelTotalAbsent.Size = new System.Drawing.Size(106, 21);
            this.labelTotalAbsent.TabIndex = 9;
            this.labelTotalAbsent.Text = "Отсутствует:";
            // 
            // labelTotalPresent
            // 
            this.labelTotalPresent.AutoSize = true;
            this.labelTotalPresent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPresent.Location = new System.Drawing.Point(8, 315);
            this.labelTotalPresent.Name = "labelTotalPresent";
            this.labelTotalPresent.Size = new System.Drawing.Size(119, 21);
            this.labelTotalPresent.TabIndex = 8;
            this.labelTotalPresent.Text = "Присутствует:";
            // 
            // labelTotalStudents
            // 
            this.labelTotalStudents.AutoSize = true;
            this.labelTotalStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalStudents.Location = new System.Drawing.Point(8, 292);
            this.labelTotalStudents.Name = "labelTotalStudents";
            this.labelTotalStudents.Size = new System.Drawing.Size(140, 21);
            this.labelTotalStudents.TabIndex = 7;
            this.labelTotalStudents.Text = "Всего студентов:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Отчет.rtf";
            this.saveFileDialog1.Filter = "RTF-Документ|*.rtf";
            // 
            // reportstudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.labelTotalRespectful);
            this.Controls.Add(this.labelTotalFree);
            this.Controls.Add(this.labelTotalSick);
            this.Controls.Add(this.labelTotalExcused);
            this.Controls.Add(this.labelTotalAbsent);
            this.Controls.Add(this.labelTotalPresent);
            this.Controls.Add(this.labelTotalStudents);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "reportstudents";
            this.Text = "Составление отчета";
            this.Load += new System.EventHandler(this.reportstudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelTotalRespectful;
        private System.Windows.Forms.Label labelTotalFree;
        private System.Windows.Forms.Label labelTotalSick;
        private System.Windows.Forms.Label labelTotalExcused;
        private System.Windows.Forms.Label labelTotalAbsent;
        private System.Windows.Forms.Label labelTotalPresent;
        private System.Windows.Forms.Label labelTotalStudents;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
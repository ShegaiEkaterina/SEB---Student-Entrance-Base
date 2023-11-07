
namespace dtbasestudents
{
    partial class FormAnalizingStudent
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
            this.labelTotalStudents = new System.Windows.Forms.Label();
            this.labelTotalPresent = new System.Windows.Forms.Label();
            this.labelTotalAbsent = new System.Windows.Forms.Label();
            this.labelTotalExcused = new System.Windows.Forms.Label();
            this.labelTotalSick = new System.Windows.Forms.Label();
            this.labelTotalFree = new System.Windows.Forms.Label();
            this.labelTotalRespectful = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotalStudents
            // 
            this.labelTotalStudents.AutoSize = true;
            this.labelTotalStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalStudents.Location = new System.Drawing.Point(8, 82);
            this.labelTotalStudents.Name = "labelTotalStudents";
            this.labelTotalStudents.Size = new System.Drawing.Size(140, 21);
            this.labelTotalStudents.TabIndex = 0;
            this.labelTotalStudents.Text = "Всего студентов:";
            // 
            // labelTotalPresent
            // 
            this.labelTotalPresent.AutoSize = true;
            this.labelTotalPresent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPresent.Location = new System.Drawing.Point(8, 132);
            this.labelTotalPresent.Name = "labelTotalPresent";
            this.labelTotalPresent.Size = new System.Drawing.Size(119, 21);
            this.labelTotalPresent.TabIndex = 1;
            this.labelTotalPresent.Text = "Присутствует:";
            // 
            // labelTotalAbsent
            // 
            this.labelTotalAbsent.AutoSize = true;
            this.labelTotalAbsent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalAbsent.Location = new System.Drawing.Point(8, 153);
            this.labelTotalAbsent.Name = "labelTotalAbsent";
            this.labelTotalAbsent.Size = new System.Drawing.Size(106, 21);
            this.labelTotalAbsent.TabIndex = 2;
            this.labelTotalAbsent.Text = "Отсутствует:";
            // 
            // labelTotalExcused
            // 
            this.labelTotalExcused.AutoSize = true;
            this.labelTotalExcused.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalExcused.Location = new System.Drawing.Point(8, 174);
            this.labelTotalExcused.Name = "labelTotalExcused";
            this.labelTotalExcused.Size = new System.Drawing.Size(85, 21);
            this.labelTotalExcused.TabIndex = 3;
            this.labelTotalExcused.Text = "Отпущен:";
            // 
            // labelTotalSick
            // 
            this.labelTotalSick.AutoSize = true;
            this.labelTotalSick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSick.Location = new System.Drawing.Point(8, 195);
            this.labelTotalSick.Name = "labelTotalSick";
            this.labelTotalSick.Size = new System.Drawing.Size(107, 21);
            this.labelTotalSick.TabIndex = 4;
            this.labelTotalSick.Text = "По болезни:";
            // 
            // labelTotalFree
            // 
            this.labelTotalFree.AutoSize = true;
            this.labelTotalFree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalFree.Location = new System.Drawing.Point(8, 216);
            this.labelTotalFree.Name = "labelTotalFree";
            this.labelTotalFree.Size = new System.Drawing.Size(195, 21);
            this.labelTotalFree.TabIndex = 5;
            this.labelTotalFree.Text = "Свободное посещение:";
            // 
            // labelTotalRespectful
            // 
            this.labelTotalRespectful.AutoSize = true;
            this.labelTotalRespectful.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalRespectful.Location = new System.Drawing.Point(8, 237);
            this.labelTotalRespectful.Name = "labelTotalRespectful";
            this.labelTotalRespectful.Size = new System.Drawing.Size(229, 21);
            this.labelTotalRespectful.TabIndex = 6;
            this.labelTotalRespectful.Text = "По уважительной причине:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Анализ посещаемости студентов";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(396, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 160);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить диаграмму в PNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 62);
            this.panel1.TabIndex = 10;
            // 
            // FormAnalizingStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTotalRespectful);
            this.Controls.Add(this.labelTotalFree);
            this.Controls.Add(this.labelTotalSick);
            this.Controls.Add(this.labelTotalExcused);
            this.Controls.Add(this.labelTotalAbsent);
            this.Controls.Add(this.labelTotalPresent);
            this.Controls.Add(this.labelTotalStudents);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAnalizingStudent";
            this.Text = "Анализ посещаемости";
            this.Load += new System.EventHandler(this.FormAnalizingStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalStudents;
        private System.Windows.Forms.Label labelTotalPresent;
        private System.Windows.Forms.Label labelTotalAbsent;
        private System.Windows.Forms.Label labelTotalExcused;
        private System.Windows.Forms.Label labelTotalSick;
        private System.Windows.Forms.Label labelTotalFree;
        private System.Windows.Forms.Label labelTotalRespectful;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}
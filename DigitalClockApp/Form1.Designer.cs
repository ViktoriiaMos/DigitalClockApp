namespace DigitalClockApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            lblSecond = new Label();
            lblDay = new Label();
            lblDate = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Lucida Handwriting", 84F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(99, 43);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(499, 182);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:22";
            lblTime.Click += lblTime_Click;
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Lucida Handwriting", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSecond.ForeColor = Color.White;
            lblSecond.Location = new Point(576, 133);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(91, 61);
            lblSecond.TabIndex = 1;
            lblSecond.Text = "22";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Lucida Handwriting", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(517, 263);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(241, 57);
            lblDay.TabIndex = 2;
            lblDay.Text = "TUESDAY";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Lucida Handwriting", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(12, 259);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(458, 61);
            lblDate.TabIndex = 3;
            lblDate.Text = "AUGUST 08 2023";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 373);
            Controls.Add(lblDate);
            Controls.Add(lblDay);
            Controls.Add(lblSecond);
            Controls.Add(lblTime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblSecond;
        private Label lblDay;
        private Label lblDate;
        private System.Windows.Forms.Timer timer;
    }
}
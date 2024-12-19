namespace Гороскоп
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.resultLbl = new System.Windows.Forms.Label();
            this.buttonShowRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(70, 50);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.Location = new System.Drawing.Point(67, 23);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(198, 18);
            this.resultLbl.TabIndex = 5;
            this.resultLbl.Text = "ВЫБЕРИТЕ ДАТУ РОЖДЕНИЯ";
            // 
            // buttonShowRes
            // 
            this.buttonShowRes.Enabled = false;
            this.buttonShowRes.Location = new System.Drawing.Point(114, 215);
            this.buttonShowRes.Name = "buttonShowRes";
            this.buttonShowRes.Size = new System.Drawing.Size(81, 44);
            this.buttonShowRes.TabIndex = 6;
            this.buttonShowRes.Text = "Перейти к результатам";
            this.buttonShowRes.UseVisualStyleBackColor = true;
            this.buttonShowRes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 291);
            this.Controls.Add(this.buttonShowRes);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.monthCalendar);
            this.Name = "Form1";
            this.Text = "Выберите дату для гороскопа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button buttonShowRes;
    }
}


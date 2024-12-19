namespace Гороскоп
{
    partial class Results
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.topLbl = new System.Windows.Forms.Label();
            this.buttonLoadRes = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.TextBox();
            this.buttonEXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(102, 353);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 42);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранение";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Enabled = false;
            this.buttonDel.Location = new System.Drawing.Point(191, 353);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 42);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить результат";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Location = new System.Drawing.Point(12, 60);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(385, 271);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topLbl.Location = new System.Drawing.Point(86, 9);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(253, 38);
            this.topLbl.TabIndex = 9;
            this.topLbl.Text = "Ваш знак зодиака";
            // 
            // buttonLoadRes
            // 
            this.buttonLoadRes.Location = new System.Drawing.Point(12, 353);
            this.buttonLoadRes.Name = "buttonLoadRes";
            this.buttonLoadRes.Size = new System.Drawing.Size(84, 42);
            this.buttonLoadRes.TabIndex = 10;
            this.buttonLoadRes.Text = "Загрузить результат!";
            this.buttonLoadRes.UseVisualStyleBackColor = true;
            this.buttonLoadRes.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.Location = new System.Drawing.Point(403, 60);
            this.resultLbl.Multiline = true;
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.ReadOnly = true;
            this.resultLbl.Size = new System.Drawing.Size(385, 121);
            this.resultLbl.TabIndex = 12;
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Location = new System.Drawing.Point(713, 396);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(75, 42);
            this.buttonEXIT.TabIndex = 13;
            this.buttonEXIT.Text = "Закрыть";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.buttonLoadRes);
            this.Controls.Add(this.topLbl);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonSave);
            this.Name = "Results";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.Button buttonLoadRes;
        private System.Windows.Forms.TextBox resultLbl;
        private System.Windows.Forms.Button buttonEXIT;
    }
}
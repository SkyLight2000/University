namespace Lab_8
{
    partial class MainForm
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
            this.tbAnimalInfo = new System.Windows.Forms.TextBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAnimalInfo
            // 
            this.tbAnimalInfo.Location = new System.Drawing.Point(11, 10);
            this.tbAnimalInfo.Multiline = true;
            this.tbAnimalInfo.Name = "tbAnimalInfo";
            this.tbAnimalInfo.ReadOnly = true;
            this.tbAnimalInfo.Size = new System.Drawing.Size(459, 239);
            this.tbAnimalInfo.TabIndex = 0;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(478, 10);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(77, 35);
            this.btnAddAnimal.TabIndex = 1;
            this.btnAddAnimal.Text = "Добавить животное";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(478, 223);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.tbAnimalInfo);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAnimalInfo;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnClose;
    }
}


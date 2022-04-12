
namespace bdgilyazova
{
    partial class date_of_driver
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llbPassportData = new System.Windows.Forms.LinkLabel();
            this.lbFullname = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBirth);
            this.groupBox1.Controls.Add(this.lbHeight);
            this.groupBox1.Controls.Add(this.llbPassportData);
            this.groupBox1.Controls.Add(this.lbFullname);
            this.groupBox1.Controls.Add(this.btnOut);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные пользователя";
            // 
            // llbPassportData
            // 
            this.llbPassportData.AutoSize = true;
            this.llbPassportData.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.llbPassportData.Location = new System.Drawing.Point(12, 51);
            this.llbPassportData.Name = "llbPassportData";
            this.llbPassportData.Size = new System.Drawing.Size(117, 13);
            this.llbPassportData.TabIndex = 2;
            this.llbPassportData.TabStop = true;
            this.llbPassportData.Text = "Пасспортные данные";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(12, 26);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(34, 13);
            this.lbFullname.TabIndex = 1;
            this.lbFullname.Text = "ФИО";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(275, 246);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Выйти";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(12, 80);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(31, 13);
            this.lbHeight.TabIndex = 3;
            this.lbHeight.Text = "Рост";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(12, 110);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(86, 13);
            this.lbBirth.TabIndex = 4;
            this.lbBirth.Text = "Дата рождения";
            // 
            // date_of_driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "date_of_driver";
            this.Text = "date_of_driver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.LinkLabel llbPassportData;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbHeight;
    }
}

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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnInfoCar = new System.Windows.Forms.Button();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbBirth = new System.Windows.Forms.TextBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbPassportData = new System.Windows.Forms.TextBox();
            this.lbPaaspotrData = new System.Windows.Forms.Label();
            this.btnAnother = new System.Windows.Forms.Button();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnInfoCar);
            this.gbInfo.Controls.Add(this.tbHeight);
            this.gbInfo.Controls.Add(this.tbBirth);
            this.gbInfo.Controls.Add(this.tbFIO);
            this.gbInfo.Controls.Add(this.tbPassportData);
            this.gbInfo.Controls.Add(this.lbPaaspotrData);
            this.gbInfo.Controls.Add(this.btnAnother);
            this.gbInfo.Controls.Add(this.lbBirth);
            this.gbInfo.Controls.Add(this.lbHeight);
            this.gbInfo.Controls.Add(this.lbFullname);
            this.gbInfo.Controls.Add(this.btnOut);
            this.gbInfo.Location = new System.Drawing.Point(0, 0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(414, 269);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Данные пользователя";
            this.gbInfo.Enter += new System.EventHandler(this.gbInfo_Enter);
            // 
            // btnInfoCar
            // 
            this.btnInfoCar.Location = new System.Drawing.Point(98, 246);
            this.btnInfoCar.Name = "btnInfoCar";
            this.btnInfoCar.Size = new System.Drawing.Size(122, 23);
            this.btnInfoCar.TabIndex = 10;
            this.btnInfoCar.Text = "Информация об авто";
            this.btnInfoCar.UseVisualStyleBackColor = true;
            this.btnInfoCar.Click += new System.EventHandler(this.btnInfoCar_Click);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(153, 87);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 9;
            // 
            // tbBirth
            // 
            this.tbBirth.Location = new System.Drawing.Point(153, 124);
            this.tbBirth.Name = "tbBirth";
            this.tbBirth.Size = new System.Drawing.Size(100, 20);
            this.tbBirth.TabIndex = 8;
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(153, 23);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(201, 20);
            this.tbFIO.TabIndex = 1;
            // 
            // tbPassportData
            // 
            this.tbPassportData.Location = new System.Drawing.Point(153, 55);
            this.tbPassportData.Name = "tbPassportData";
            this.tbPassportData.Size = new System.Drawing.Size(100, 20);
            this.tbPassportData.TabIndex = 7;
            // 
            // lbPaaspotrData
            // 
            this.lbPaaspotrData.AutoSize = true;
            this.lbPaaspotrData.Location = new System.Drawing.Point(12, 55);
            this.lbPaaspotrData.Name = "lbPaaspotrData";
            this.lbPaaspotrData.Size = new System.Drawing.Size(117, 13);
            this.lbPaaspotrData.TabIndex = 6;
            this.lbPaaspotrData.Text = "Пасспортные данные";
            // 
            // btnAnother
            // 
            this.btnAnother.Location = new System.Drawing.Point(216, 246);
            this.btnAnother.Name = "btnAnother";
            this.btnAnother.Size = new System.Drawing.Size(126, 23);
            this.btnAnother.TabIndex = 5;
            this.btnAnother.Text = "Другие пользователи";
            this.btnAnother.UseVisualStyleBackColor = true;
            this.btnAnother.Click += new System.EventHandler(this.btnAnother_Click);
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(12, 124);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(86, 13);
            this.lbBirth.TabIndex = 4;
            this.lbBirth.Text = "Дата рождения";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(12, 87);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(31, 13);
            this.lbHeight.TabIndex = 3;
            this.lbHeight.Text = "Рост";
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
            this.btnOut.Location = new System.Drawing.Point(333, 246);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Выйти";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // date_of_driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 273);
            this.Controls.Add(this.gbInfo);
            this.Name = "date_of_driver";
            this.Text = "date_of_driver";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Button btnAnother;
        private System.Windows.Forms.Label lbPaaspotrData;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbBirth;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbPassportData;
        private System.Windows.Forms.Button btnInfoCar;
    }
}
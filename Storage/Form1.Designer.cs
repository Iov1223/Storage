namespace Storage
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.dataGridViewPaper = new System.Windows.Forms.DataGridView();
            this.labelPaper = new System.Windows.Forms.Label();
            this.dataGridViewWriting = new System.Windows.Forms.DataGridView();
            this.labelWriting = new System.Windows.Forms.Label();
            this.dataGridViewUSB = new System.Windows.Forms.DataGridView();
            this.labelUSB = new System.Windows.Forms.Label();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUaserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(1061, 28);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(285, 20);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключится к БД/Отключится от БД";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // dataGridViewPaper
            // 
            this.dataGridViewPaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaper.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewPaper.Name = "dataGridViewPaper";
            this.dataGridViewPaper.Size = new System.Drawing.Size(1334, 150);
            this.dataGridViewPaper.TabIndex = 3;
            this.dataGridViewPaper.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaper_CellEndEdit);
            // 
            // labelPaper
            // 
            this.labelPaper.AutoSize = true;
            this.labelPaper.Location = new System.Drawing.Point(9, 75);
            this.labelPaper.Name = "labelPaper";
            this.labelPaper.Size = new System.Drawing.Size(47, 13);
            this.labelPaper.TabIndex = 4;
            this.labelPaper.Text = "Бумага:";
            // 
            // dataGridViewWriting
            // 
            this.dataGridViewWriting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWriting.Location = new System.Drawing.Point(12, 286);
            this.dataGridViewWriting.Name = "dataGridViewWriting";
            this.dataGridViewWriting.Size = new System.Drawing.Size(1334, 150);
            this.dataGridViewWriting.TabIndex = 5;
            this.dataGridViewWriting.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWriting_CellEndEdit);
            // 
            // labelWriting
            // 
            this.labelWriting.AutoSize = true;
            this.labelWriting.Location = new System.Drawing.Point(9, 270);
            this.labelWriting.Name = "labelWriting";
            this.labelWriting.Size = new System.Drawing.Size(146, 13);
            this.labelWriting.TabIndex = 6;
            this.labelWriting.Text = "Пишущие принадлежности:";
            // 
            // dataGridViewUSB
            // 
            this.dataGridViewUSB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUSB.Location = new System.Drawing.Point(12, 478);
            this.dataGridViewUSB.Name = "dataGridViewUSB";
            this.dataGridViewUSB.Size = new System.Drawing.Size(1334, 150);
            this.dataGridViewUSB.TabIndex = 7;
            this.dataGridViewUSB.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUSB_CellEndEdit);
            // 
            // labelUSB
            // 
            this.labelUSB.AutoSize = true;
            this.labelUSB.Location = new System.Drawing.Point(9, 462);
            this.labelUSB.Name = "labelUSB";
            this.labelUSB.Size = new System.Drawing.Size(103, 13);
            this.labelUSB.TabIndex = 8;
            this.labelUSB.Text = "Флэш-накопители:";
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.Location = new System.Drawing.Point(12, 677);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(1334, 23);
            this.buttonShowReport.TabIndex = 9;
            this.buttonShowReport.Text = "Показать/обновить отчёт за день";
            this.buttonShowReport.UseVisualStyleBackColor = true;
            this.buttonShowReport.Click += new System.EventHandler(this.buttonShowReport_Click);
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(12, 27);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(347, 21);
            this.comboBoxServer.TabIndex = 10;
            this.comboBoxServer.Text = "Выбор сервера";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(536, 27);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(141, 20);
            this.textBoxUserName.TabIndex = 11;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(873, 28);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(159, 20);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUaserName
            // 
            this.labelUaserName.AutoSize = true;
            this.labelUaserName.Location = new System.Drawing.Point(381, 30);
            this.labelUaserName.Name = "labelUaserName";
            this.labelUaserName.Size = new System.Drawing.Size(149, 13);
            this.labelUaserName.TabIndex = 13;
            this.labelUaserName.Text = "Введите имя пользователя:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(702, 30);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(165, 13);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Введите пароль пользователя:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 749);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUaserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.comboBoxServer);
            this.Controls.Add(this.buttonShowReport);
            this.Controls.Add(this.labelUSB);
            this.Controls.Add(this.dataGridViewUSB);
            this.Controls.Add(this.labelWriting);
            this.Controls.Add(this.dataGridViewWriting);
            this.Controls.Add(this.labelPaper);
            this.Controls.Add(this.dataGridViewPaper);
            this.Controls.Add(this.buttonConnect);
            this.MinimumSize = new System.Drawing.Size(1377, 788);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.DataGridView dataGridViewPaper;
        private System.Windows.Forms.Label labelPaper;
        private System.Windows.Forms.DataGridView dataGridViewWriting;
        private System.Windows.Forms.Label labelWriting;
        private System.Windows.Forms.DataGridView dataGridViewUSB;
        private System.Windows.Forms.Label labelUSB;
        private System.Windows.Forms.Button buttonShowReport;
        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUaserName;
        private System.Windows.Forms.Label labelPassword;
    }
}


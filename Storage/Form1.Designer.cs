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
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.dataGridViewPaper = new System.Windows.Forms.DataGridView();
            this.labelPaper = new System.Windows.Forms.Label();
            this.dataGridViewWriting = new System.Windows.Forms.DataGridView();
            this.labelWriting = new System.Windows.Forms.Label();
            this.dataGridViewUSB = new System.Windows.Forms.DataGridView();
            this.labelUSB = new System.Windows.Forms.Label();
            this.buttonShowReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(344, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(99, 20);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подкл/Откл";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(12, 12);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(306, 20);
            this.textBoxServerName.TabIndex = 1;
            // 
            // dataGridViewPaper
            // 
            this.dataGridViewPaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaper.Location = new System.Drawing.Point(12, 155);
            this.dataGridViewPaper.Name = "dataGridViewPaper";
            this.dataGridViewPaper.Size = new System.Drawing.Size(1698, 150);
            this.dataGridViewPaper.TabIndex = 3;
            this.dataGridViewPaper.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaper_CellEndEdit);
            // 
            // labelPaper
            // 
            this.labelPaper.AutoSize = true;
            this.labelPaper.Location = new System.Drawing.Point(9, 139);
            this.labelPaper.Name = "labelPaper";
            this.labelPaper.Size = new System.Drawing.Size(47, 13);
            this.labelPaper.TabIndex = 4;
            this.labelPaper.Text = "Бумага:";
            // 
            // dataGridViewWriting
            // 
            this.dataGridViewWriting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWriting.Location = new System.Drawing.Point(12, 345);
            this.dataGridViewWriting.Name = "dataGridViewWriting";
            this.dataGridViewWriting.Size = new System.Drawing.Size(1698, 150);
            this.dataGridViewWriting.TabIndex = 5;
            this.dataGridViewWriting.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWriting_CellEndEdit);
            // 
            // labelWriting
            // 
            this.labelWriting.AutoSize = true;
            this.labelWriting.Location = new System.Drawing.Point(9, 329);
            this.labelWriting.Name = "labelWriting";
            this.labelWriting.Size = new System.Drawing.Size(146, 13);
            this.labelWriting.TabIndex = 6;
            this.labelWriting.Text = "Пишущие принадлежности:";
            // 
            // dataGridViewUSB
            // 
            this.dataGridViewUSB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUSB.Location = new System.Drawing.Point(12, 534);
            this.dataGridViewUSB.Name = "dataGridViewUSB";
            this.dataGridViewUSB.Size = new System.Drawing.Size(1698, 150);
            this.dataGridViewUSB.TabIndex = 7;
            this.dataGridViewUSB.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUSB_CellEndEdit);
            // 
            // labelUSB
            // 
            this.labelUSB.AutoSize = true;
            this.labelUSB.Location = new System.Drawing.Point(9, 518);
            this.labelUSB.Name = "labelUSB";
            this.labelUSB.Size = new System.Drawing.Size(103, 13);
            this.labelUSB.TabIndex = 8;
            this.labelUSB.Text = "Флэш-накопители:";
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.Location = new System.Drawing.Point(12, 744);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(1698, 23);
            this.buttonShowReport.TabIndex = 9;
            this.buttonShowReport.Text = "Показать отчёт за день";
            this.buttonShowReport.UseVisualStyleBackColor = true;
            this.buttonShowReport.Click += new System.EventHandler(this.buttonShowReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 933);
            this.Controls.Add(this.buttonShowReport);
            this.Controls.Add(this.labelUSB);
            this.Controls.Add(this.dataGridViewUSB);
            this.Controls.Add(this.labelWriting);
            this.Controls.Add(this.dataGridViewWriting);
            this.Controls.Add(this.labelPaper);
            this.Controls.Add(this.dataGridViewPaper);
            this.Controls.Add(this.textBoxServerName);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.DataGridView dataGridViewPaper;
        private System.Windows.Forms.Label labelPaper;
        private System.Windows.Forms.DataGridView dataGridViewWriting;
        private System.Windows.Forms.Label labelWriting;
        private System.Windows.Forms.DataGridView dataGridViewUSB;
        private System.Windows.Forms.Label labelUSB;
        private System.Windows.Forms.Button buttonShowReport;
    }
}


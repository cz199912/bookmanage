namespace BookManageSystem
{
    partial class frmBookInfoAddOrUpdate
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
            this.lValidate = new System.Windows.Forms.Label();
            this.lBookSortMark = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.cbBookSortID = new System.Windows.Forms.ComboBox();
            this.dtpBookResDate = new System.Windows.Forms.DateTimePicker();
            this.rtbBookSummary = new System.Windows.Forms.RichTextBox();
            this.tbLendNum = new System.Windows.Forms.TextBox();
            this.tbBookRealNum = new System.Windows.Forms.TextBox();
            this.tbBookPrice = new System.Windows.Forms.TextBox();
            this.tbBookPublish = new System.Windows.Forms.TextBox();
            this.tbBookAutor = new System.Windows.Forms.TextBox();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEnter = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.formStatus1 = new BookManageSystem.FormStatus();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lValidate);
            this.groupBox1.Controls.Add(this.lBookSortMark);
            this.groupBox1.Controls.Add(this.dtpPublishDate);
            this.groupBox1.Controls.Add(this.cbBookSortID);
            this.groupBox1.Controls.Add(this.dtpBookResDate);
            this.groupBox1.Controls.Add(this.rtbBookSummary);
            this.groupBox1.Controls.Add(this.tbLendNum);
            this.groupBox1.Controls.Add(this.tbBookRealNum);
            this.groupBox1.Controls.Add(this.tbBookPrice);
            this.groupBox1.Controls.Add(this.tbBookPublish);
            this.groupBox1.Controls.Add(this.tbBookAutor);
            this.groupBox1.Controls.Add(this.tbBookID);
            this.groupBox1.Controls.Add(this.tbBookName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(724, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // lValidate
            // 
            this.lValidate.AutoSize = true;
            this.lValidate.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lValidate.ForeColor = System.Drawing.Color.Blue;
            this.lValidate.Location = new System.Drawing.Point(429, 241);
            this.lValidate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lValidate.Name = "lValidate";
            this.lValidate.Size = new System.Drawing.Size(0, 14);
            this.lValidate.TabIndex = 12;
            // 
            // lBookSortMark
            // 
            this.lBookSortMark.AutoSize = true;
            this.lBookSortMark.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lBookSortMark.ForeColor = System.Drawing.Color.Blue;
            this.lBookSortMark.Location = new System.Drawing.Point(468, 61);
            this.lBookSortMark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBookSortMark.Name = "lBookSortMark";
            this.lBookSortMark.Size = new System.Drawing.Size(0, 14);
            this.lBookSortMark.TabIndex = 11;
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublishDate.Location = new System.Drawing.Point(105, 161);
            this.dtpPublishDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(221, 25);
            this.dtpPublishDate.TabIndex = 5;
            // 
            // cbBookSortID
            // 
            this.cbBookSortID.FormattingEnabled = true;
            this.cbBookSortID.Location = new System.Drawing.Point(467, 32);
            this.cbBookSortID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBookSortID.Name = "cbBookSortID";
            this.cbBookSortID.Size = new System.Drawing.Size(224, 23);
            this.cbBookSortID.TabIndex = 1;
            this.cbBookSortID.TextChanged += new System.EventHandler(this.cbBookSortID_TextChanged);
            // 
            // dtpBookResDate
            // 
            this.dtpBookResDate.Enabled = false;
            this.dtpBookResDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookResDate.Location = new System.Drawing.Point(105, 380);
            this.dtpBookResDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBookResDate.Name = "dtpBookResDate";
            this.dtpBookResDate.Size = new System.Drawing.Size(221, 25);
            this.dtpBookResDate.TabIndex = 10;
            this.dtpBookResDate.Value = new System.DateTime(2020, 5, 28, 0, 0, 0, 0);
            this.dtpBookResDate.ValueChanged += new System.EventHandler(this.dtpBookResDate_ValueChanged);
            // 
            // rtbBookSummary
            // 
            this.rtbBookSummary.Location = new System.Drawing.Point(107, 261);
            this.rtbBookSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbBookSummary.Name = "rtbBookSummary";
            this.rtbBookSummary.Size = new System.Drawing.Size(584, 102);
            this.rtbBookSummary.TabIndex = 9;
            this.rtbBookSummary.Text = "";
            // 
            // tbLendNum
            // 
            this.tbLendNum.Location = new System.Drawing.Point(429, 211);
            this.tbLendNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLendNum.Name = "tbLendNum";
            this.tbLendNum.Size = new System.Drawing.Size(261, 25);
            this.tbLendNum.TabIndex = 8;
            // 
            // tbBookRealNum
            // 
            this.tbBookRealNum.Location = new System.Drawing.Point(105, 211);
            this.tbBookRealNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookRealNum.Name = "tbBookRealNum";
            this.tbBookRealNum.Size = new System.Drawing.Size(221, 25);
            this.tbBookRealNum.TabIndex = 7;
            // 
            // tbBookPrice
            // 
            this.tbBookPrice.Location = new System.Drawing.Point(429, 162);
            this.tbBookPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookPrice.Name = "tbBookPrice";
            this.tbBookPrice.Size = new System.Drawing.Size(261, 25);
            this.tbBookPrice.TabIndex = 6;
            // 
            // tbBookPublish
            // 
            this.tbBookPublish.Location = new System.Drawing.Point(429, 120);
            this.tbBookPublish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookPublish.Name = "tbBookPublish";
            this.tbBookPublish.Size = new System.Drawing.Size(261, 25);
            this.tbBookPublish.TabIndex = 4;
            // 
            // tbBookAutor
            // 
            this.tbBookAutor.Location = new System.Drawing.Point(105, 120);
            this.tbBookAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookAutor.Name = "tbBookAutor";
            this.tbBookAutor.Size = new System.Drawing.Size(221, 25);
            this.tbBookAutor.TabIndex = 3;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(105, 32);
            this.tbBookID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(221, 25);
            this.tbBookID.TabIndex = 0;
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(105, 76);
            this.tbBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(585, 25);
            this.tbBookName.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 385);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "登记日期";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "借出数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "定价";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "内容摘要";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "出版社";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "图书类别编号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "实际数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "出版日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "作者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "图书名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书编号";
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(221, 460);
            this.btEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(123, 29);
            this.btEnter.TabIndex = 11;
            this.btEnter.Text = "添加或修改";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(403, 460);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(123, 29);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // formStatus1
            // 
            this.formStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatus1.Location = new System.Drawing.Point(0, 504);
            this.formStatus1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.formStatus1.Name = "formStatus1";
            this.formStatus1.Size = new System.Drawing.Size(775, 32);
            this.formStatus1.TabIndex = 1;
            // 
            // frmBookInfoAddOrUpdate
            // 
            this.AcceptButton = this.btEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(775, 536);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.formStatus1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookInfoAddOrUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加新卡片";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBookInfoAddOrUpdate_FormClosing);
            this.Load += new System.EventHandler(this.frmBookInfoAddOrUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBookResDate;
        private System.Windows.Forms.RichTextBox rtbBookSummary;
        private System.Windows.Forms.TextBox tbLendNum;
        private System.Windows.Forms.TextBox tbBookRealNum;
        private System.Windows.Forms.TextBox tbBookPrice;
        private System.Windows.Forms.TextBox tbBookPublish;
        private System.Windows.Forms.TextBox tbBookAutor;
        private System.Windows.Forms.ComboBox cbBookSortID;
        private FormStatus formStatus1;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label lBookSortMark;
        private System.Windows.Forms.Label lValidate;
    }
}
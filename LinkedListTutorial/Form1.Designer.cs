namespace LinkedListTutorial
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBackBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.AddBackValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddFrontBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AddFrontValue = new System.Windows.Forms.TextBox();
            this.BtnClearList = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Addindex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDelWithIndex = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DelWithIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnDelWithVal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DelWithVal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Addvalue = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AddBackBtn);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.AddBackValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddFrontBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddFrontValue);
            this.panel1.Controls.Add(this.BtnClearList);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Addindex);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BtnDelWithIndex);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DelWithIndex);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BtnDelWithVal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DelWithVal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ShowList);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Addvalue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 648);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Qiymat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddBackBtn
            // 
            this.AddBackBtn.Location = new System.Drawing.Point(236, 273);
            this.AddBackBtn.Name = "AddBackBtn";
            this.AddBackBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBackBtn.TabIndex = 28;
            this.AddBackBtn.Text = "Qo\'shish";
            this.AddBackBtn.UseVisualStyleBackColor = true;
            this.AddBackBtn.Click += new System.EventHandler(this.AddBackBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Oxiridan qo\'shish";
            // 
            // AddBackValue
            // 
            this.AddBackValue.Location = new System.Drawing.Point(95, 274);
            this.AddBackValue.Name = "AddBackValue";
            this.AddBackValue.Size = new System.Drawing.Size(108, 22);
            this.AddBackValue.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Qiymat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddFrontBtn
            // 
            this.AddFrontBtn.Location = new System.Drawing.Point(236, 175);
            this.AddFrontBtn.Name = "AddFrontBtn";
            this.AddFrontBtn.Size = new System.Drawing.Size(75, 23);
            this.AddFrontBtn.TabIndex = 24;
            this.AddFrontBtn.Text = "Qo\'shish";
            this.AddFrontBtn.UseVisualStyleBackColor = true;
            this.AddFrontBtn.Click += new System.EventHandler(this.AddFrontBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Boshidan qo\'shish";
            // 
            // AddFrontValue
            // 
            this.AddFrontValue.Location = new System.Drawing.Point(95, 176);
            this.AddFrontValue.Name = "AddFrontValue";
            this.AddFrontValue.Size = new System.Drawing.Size(108, 22);
            this.AddFrontValue.TabIndex = 22;
            // 
            // BtnClearList
            // 
            this.BtnClearList.Location = new System.Drawing.Point(794, 529);
            this.BtnClearList.Name = "BtnClearList";
            this.BtnClearList.Size = new System.Drawing.Size(85, 23);
            this.BtnClearList.TabIndex = 21;
            this.BtnClearList.Text = "Tozalash";
            this.BtnClearList.UseVisualStyleBackColor = true;
            this.BtnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Index";
            // 
            // Addindex
            // 
            this.Addindex.Location = new System.Drawing.Point(95, 61);
            this.Addindex.Name = "Addindex";
            this.Addindex.Size = new System.Drawing.Size(108, 22);
            this.Addindex.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Index";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnDelWithIndex
            // 
            this.BtnDelWithIndex.Location = new System.Drawing.Point(236, 483);
            this.BtnDelWithIndex.Name = "BtnDelWithIndex";
            this.BtnDelWithIndex.Size = new System.Drawing.Size(75, 23);
            this.BtnDelWithIndex.TabIndex = 17;
            this.BtnDelWithIndex.Text = "O\'chirish";
            this.BtnDelWithIndex.UseVisualStyleBackColor = true;
            this.BtnDelWithIndex.Click += new System.EventHandler(this.BtnDelWithIndex_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "O\'chirish (index)";
            // 
            // DelWithIndex
            // 
            this.DelWithIndex.Location = new System.Drawing.Point(95, 484);
            this.DelWithIndex.Name = "DelWithIndex";
            this.DelWithIndex.Size = new System.Drawing.Size(108, 22);
            this.DelWithIndex.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Qiymat";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnDelWithVal
            // 
            this.BtnDelWithVal.Location = new System.Drawing.Point(236, 371);
            this.BtnDelWithVal.Name = "BtnDelWithVal";
            this.BtnDelWithVal.Size = new System.Drawing.Size(75, 23);
            this.BtnDelWithVal.TabIndex = 13;
            this.BtnDelWithVal.Text = "O\'chirish";
            this.BtnDelWithVal.UseVisualStyleBackColor = true;
            this.BtnDelWithVal.Click += new System.EventHandler(this.BtnDelWithVal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "O\'chirish (qiymat bo\'yicha)";
            // 
            // DelWithVal
            // 
            this.DelWithVal.Location = new System.Drawing.Point(95, 372);
            this.DelWithVal.Name = "DelWithVal";
            this.DelWithVal.Size = new System.Drawing.Size(108, 22);
            this.DelWithVal.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qiymat";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowList
            // 
            this.ShowList.FormattingEnabled = true;
            this.ShowList.ItemHeight = 16;
            this.ShowList.Location = new System.Drawing.Point(646, 23);
            this.ShowList.Name = "ShowList";
            this.ShowList.Size = new System.Drawing.Size(233, 500);
            this.ShowList.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(236, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Qo\'shish";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yangi qiymat qo\'shish";
            // 
            // Addvalue
            // 
            this.Addvalue.Location = new System.Drawing.Point(95, 89);
            this.Addvalue.Name = "Addvalue";
            this.Addvalue.Size = new System.Drawing.Size(108, 22);
            this.Addvalue.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 648);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Addvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ShowList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnDelWithIndex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DelWithIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnDelWithVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DelWithVal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Addindex;
        private System.Windows.Forms.Button BtnClearList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBackBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AddBackValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddFrontBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddFrontValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


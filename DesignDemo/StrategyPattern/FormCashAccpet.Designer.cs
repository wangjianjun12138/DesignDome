namespace StrategyPattern
{
    partial class FormCashAccpet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_textBoxPrice = new System.Windows.Forms.TextBox();
            this.m_textBoxCount = new System.Windows.Forms.TextBox();
            this.m_buttonOk = new System.Windows.Forms.Button();
            this.m_buttonReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.m_comboBox = new System.Windows.Forms.ComboBox();
            this.m_listBoxItems = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单价";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量";
            // 
            // m_textBoxPrice
            // 
            this.m_textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxPrice.Location = new System.Drawing.Point(75, 12);
            this.m_textBoxPrice.Name = "m_textBoxPrice";
            this.m_textBoxPrice.Size = new System.Drawing.Size(169, 21);
            this.m_textBoxPrice.TabIndex = 2;
            // 
            // m_textBoxCount
            // 
            this.m_textBoxCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxCount.Location = new System.Drawing.Point(75, 39);
            this.m_textBoxCount.Name = "m_textBoxCount";
            this.m_textBoxCount.Size = new System.Drawing.Size(169, 21);
            this.m_textBoxCount.TabIndex = 3;
            // 
            // m_buttonOk
            // 
            this.m_buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_buttonOk.Location = new System.Drawing.Point(261, 10);
            this.m_buttonOk.Name = "m_buttonOk";
            this.m_buttonOk.Size = new System.Drawing.Size(75, 23);
            this.m_buttonOk.TabIndex = 4;
            this.m_buttonOk.Text = "确认";
            this.m_buttonOk.UseVisualStyleBackColor = true;
            this.m_buttonOk.Click += new System.EventHandler(this.m_buttonOk_Click);
            // 
            // m_buttonReset
            // 
            this.m_buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_buttonReset.Location = new System.Drawing.Point(261, 39);
            this.m_buttonReset.Name = "m_buttonReset";
            this.m_buttonReset.Size = new System.Drawing.Size(75, 23);
            this.m_buttonReset.TabIndex = 5;
            this.m_buttonReset.Text = "重置";
            this.m_buttonReset.UseVisualStyleBackColor = true;
            this.m_buttonReset.Click += new System.EventHandler(this.m_buttonReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "优惠活动";
            // 
            // m_comboBox
            // 
            this.m_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_comboBox.FormattingEnabled = true;
            this.m_comboBox.Location = new System.Drawing.Point(75, 67);
            this.m_comboBox.Name = "m_comboBox";
            this.m_comboBox.Size = new System.Drawing.Size(169, 20);
            this.m_comboBox.TabIndex = 7;
            // 
            // m_listBoxItems
            // 
            this.m_listBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_listBoxItems.FormattingEnabled = true;
            this.m_listBoxItems.ItemHeight = 12;
            this.m_listBoxItems.Location = new System.Drawing.Point(14, 93);
            this.m_listBoxItems.Name = "m_listBoxItems";
            this.m_listBoxItems.Size = new System.Drawing.Size(322, 76);
            this.m_listBoxItems.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "总计:";
            // 
            // m_labelTotal
            // 
            this.m_labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_labelTotal.AutoSize = true;
            this.m_labelTotal.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_labelTotal.Location = new System.Drawing.Point(115, 201);
            this.m_labelTotal.Name = "m_labelTotal";
            this.m_labelTotal.Size = new System.Drawing.Size(82, 24);
            this.m_labelTotal.TabIndex = 10;
            this.m_labelTotal.Text = "label5";
            // 
            // FormCashAccpet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 263);
            this.Controls.Add(this.m_labelTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_listBoxItems);
            this.Controls.Add(this.m_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_buttonReset);
            this.Controls.Add(this.m_buttonOk);
            this.Controls.Add(this.m_textBoxCount);
            this.Controls.Add(this.m_textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCashAccpet";
            this.Text = "超市收银系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_textBoxPrice;
        private System.Windows.Forms.TextBox m_textBoxCount;
        private System.Windows.Forms.Button m_buttonOk;
        private System.Windows.Forms.Button m_buttonReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_comboBox;
        private System.Windows.Forms.ListBox m_listBoxItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_labelTotal;
    }
}
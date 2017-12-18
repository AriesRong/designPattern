namespace StrategyPattren
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.typecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.amount_textBox = new System.Windows.Forms.TextBox();
            this.unitPrice_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.typecomboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.Clear_button);
            this.panel1.Controls.Add(this.ok_button);
            this.panel1.Controls.Add(this.amount_textBox);
            this.panel1.Controls.Add(this.unitPrice_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 293);
            this.panel1.TabIndex = 2;
            // 
            // typecomboBox
            // 
            this.typecomboBox.FormattingEnabled = true;
            this.typecomboBox.Items.AddRange(new object[] {
            "正常收费",
            "九折优惠",
            "八折优惠",
            "七折优惠",
            "满300减50",
            "满400减70",
            "满500减100",
            "满900减200"});
            this.typecomboBox.Location = new System.Drawing.Point(94, 79);
            this.typecomboBox.Name = "typecomboBox";
            this.typecomboBox.Size = new System.Drawing.Size(121, 20);
            this.typecomboBox.TabIndex = 9;
            this.typecomboBox.Text = "正常收费";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "收费方式：";
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultLabel.Location = new System.Drawing.Point(47, 219);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(233, 62);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "0.00";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "总计：";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(25, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 100);
            this.listBox1.TabIndex = 6;
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(215, 44);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(45, 23);
            this.Clear_button.TabIndex = 5;
            this.Clear_button.Text = "重置";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(215, 10);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(45, 23);
            this.ok_button.TabIndex = 4;
            this.ok_button.Text = "确认";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // amount_textBox
            // 
            this.amount_textBox.Location = new System.Drawing.Point(70, 46);
            this.amount_textBox.Name = "amount_textBox";
            this.amount_textBox.Size = new System.Drawing.Size(126, 21);
            this.amount_textBox.TabIndex = 3;
            this.amount_textBox.Text = "1";
            this.amount_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // unitPrice_textBox
            // 
            this.unitPrice_textBox.Location = new System.Drawing.Point(70, 12);
            this.unitPrice_textBox.Name = "unitPrice_textBox";
            this.unitPrice_textBox.Size = new System.Drawing.Size(126, 21);
            this.unitPrice_textBox.TabIndex = 2;
            this.unitPrice_textBox.Text = "0.00";
            this.unitPrice_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单价：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 293);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox typecomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox amount_textBox;
        private System.Windows.Forms.TextBox unitPrice_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


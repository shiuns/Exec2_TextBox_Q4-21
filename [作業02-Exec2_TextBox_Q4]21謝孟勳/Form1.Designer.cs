﻿namespace _作業02_Exec2_TextBox_Q4_21謝孟勳
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CarTextBox = new System.Windows.Forms.TextBox();
            this.PeopleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowLabel
            // 
            this.ShowLabel.AutoSize = true;
            this.ShowLabel.Location = new System.Drawing.Point(25, 197);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(41, 15);
            this.ShowLabel.TabIndex = 0;
            this.ShowLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarTextBox
            // 
            this.CarTextBox.Location = new System.Drawing.Point(12, 100);
            this.CarTextBox.Name = "CarTextBox";
            this.CarTextBox.Size = new System.Drawing.Size(100, 25);
            this.CarTextBox.TabIndex = 2;
            this.CarTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PeopleTextBox
            // 
            this.PeopleTextBox.Location = new System.Drawing.Point(178, 100);
            this.PeopleTextBox.Name = "PeopleTextBox";
            this.PeopleTextBox.Size = new System.Drawing.Size(100, 25);
            this.PeopleTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 377);
            this.Controls.Add(this.PeopleTextBox);
            this.Controls.Add(this.CarTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CarTextBox;
        private System.Windows.Forms.TextBox PeopleTextBox;
    }
}


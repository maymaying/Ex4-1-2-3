﻿namespace Ex4_1
{
    partial class MyForm
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
            this.radioButton_lan = new System.Windows.Forms.RadioButton();
            this.radioButton_lv = new System.Windows.Forms.RadioButton();
            this.radioButton_Hong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_zi = new System.Windows.Forms.CheckBox();
            this.checkBox_huang = new System.Windows.Forms.CheckBox();
            this.checkBox_cheng = new System.Windows.Forms.CheckBox();
            this.checkBox_lan = new System.Windows.Forms.CheckBox();
            this.checkBox_lv = new System.Windows.Forms.CheckBox();
            this.checkBox_hong = new System.Windows.Forms.CheckBox();
            this.YourColor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_lan);
            this.groupBox1.Controls.Add(this.radioButton_lv);
            this.groupBox1.Controls.Add(this.radioButton_Hong);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "背景颜色";
            // 
            // radioButton_lan
            // 
            this.radioButton_lan.AutoSize = true;
            this.radioButton_lan.Location = new System.Drawing.Point(17, 84);
            this.radioButton_lan.Name = "radioButton_lan";
            this.radioButton_lan.Size = new System.Drawing.Size(35, 16);
            this.radioButton_lan.TabIndex = 2;
            this.radioButton_lan.TabStop = true;
            this.radioButton_lan.Text = "蓝";
            this.radioButton_lan.UseVisualStyleBackColor = true;
            this.radioButton_lan.CheckedChanged += new System.EventHandler(this.radioButton_lan_CheckedChanged);
            // 
            // radioButton_lv
            // 
            this.radioButton_lv.AutoSize = true;
            this.radioButton_lv.Location = new System.Drawing.Point(17, 51);
            this.radioButton_lv.Name = "radioButton_lv";
            this.radioButton_lv.Size = new System.Drawing.Size(35, 16);
            this.radioButton_lv.TabIndex = 1;
            this.radioButton_lv.TabStop = true;
            this.radioButton_lv.Text = "绿";
            this.radioButton_lv.UseVisualStyleBackColor = true;
            this.radioButton_lv.CheckedChanged += new System.EventHandler(this.radioButton_lv_CheckedChanged);
            // 
            // radioButton_Hong
            // 
            this.radioButton_Hong.AutoSize = true;
            this.radioButton_Hong.Location = new System.Drawing.Point(17, 20);
            this.radioButton_Hong.Name = "radioButton_Hong";
            this.radioButton_Hong.Size = new System.Drawing.Size(35, 16);
            this.radioButton_Hong.TabIndex = 0;
            this.radioButton_Hong.TabStop = true;
            this.radioButton_Hong.Text = "红";
            this.radioButton_Hong.UseVisualStyleBackColor = true;
            this.radioButton_Hong.CheckedChanged += new System.EventHandler(this.radioButton_Hong_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_zi);
            this.groupBox2.Controls.Add(this.checkBox_huang);
            this.groupBox2.Controls.Add(this.checkBox_cheng);
            this.groupBox2.Controls.Add(this.checkBox_lan);
            this.groupBox2.Controls.Add(this.checkBox_lv);
            this.groupBox2.Controls.Add(this.checkBox_hong);
            this.groupBox2.Location = new System.Drawing.Point(94, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "你喜欢的颜色";
            // 
            // checkBox_zi
            // 
            this.checkBox_zi.AutoSize = true;
            this.checkBox_zi.Location = new System.Drawing.Point(118, 85);
            this.checkBox_zi.Name = "checkBox_zi";
            this.checkBox_zi.Size = new System.Drawing.Size(36, 16);
            this.checkBox_zi.TabIndex = 5;
            this.checkBox_zi.Text = "紫";
            this.checkBox_zi.UseVisualStyleBackColor = true;
            this.checkBox_zi.CheckedChanged += new System.EventHandler(this.checkBox_zi_CheckedChanged);
            // 
            // checkBox_huang
            // 
            this.checkBox_huang.AutoSize = true;
            this.checkBox_huang.Location = new System.Drawing.Point(118, 52);
            this.checkBox_huang.Name = "checkBox_huang";
            this.checkBox_huang.Size = new System.Drawing.Size(36, 16);
            this.checkBox_huang.TabIndex = 4;
            this.checkBox_huang.Text = "黄";
            this.checkBox_huang.UseVisualStyleBackColor = true;
            this.checkBox_huang.CheckedChanged += new System.EventHandler(this.checkBox_huang_CheckedChanged);
            // 
            // checkBox_cheng
            // 
            this.checkBox_cheng.AutoSize = true;
            this.checkBox_cheng.Location = new System.Drawing.Point(118, 21);
            this.checkBox_cheng.Name = "checkBox_cheng";
            this.checkBox_cheng.Size = new System.Drawing.Size(36, 16);
            this.checkBox_cheng.TabIndex = 3;
            this.checkBox_cheng.Text = "橙";
            this.checkBox_cheng.UseVisualStyleBackColor = true;
            this.checkBox_cheng.CheckedChanged += new System.EventHandler(this.checkBox_cheng_CheckedChanged);
            // 
            // checkBox_lan
            // 
            this.checkBox_lan.AutoSize = true;
            this.checkBox_lan.Location = new System.Drawing.Point(29, 85);
            this.checkBox_lan.Name = "checkBox_lan";
            this.checkBox_lan.Size = new System.Drawing.Size(36, 16);
            this.checkBox_lan.TabIndex = 2;
            this.checkBox_lan.Text = "蓝";
            this.checkBox_lan.UseVisualStyleBackColor = true;
            this.checkBox_lan.CheckedChanged += new System.EventHandler(this.checkBox_lan_CheckedChanged);
            // 
            // checkBox_lv
            // 
            this.checkBox_lv.AutoSize = true;
            this.checkBox_lv.Location = new System.Drawing.Point(29, 52);
            this.checkBox_lv.Name = "checkBox_lv";
            this.checkBox_lv.Size = new System.Drawing.Size(36, 16);
            this.checkBox_lv.TabIndex = 1;
            this.checkBox_lv.Text = "绿";
            this.checkBox_lv.UseVisualStyleBackColor = true;
            this.checkBox_lv.CheckedChanged += new System.EventHandler(this.checkBox_lv_CheckedChanged);
            // 
            // checkBox_hong
            // 
            this.checkBox_hong.AutoSize = true;
            this.checkBox_hong.Location = new System.Drawing.Point(29, 20);
            this.checkBox_hong.Name = "checkBox_hong";
            this.checkBox_hong.Size = new System.Drawing.Size(36, 16);
            this.checkBox_hong.TabIndex = 0;
            this.checkBox_hong.Text = "红";
            this.checkBox_hong.UseVisualStyleBackColor = true;
            this.checkBox_hong.CheckedChanged += new System.EventHandler(this.checkBox_hong_CheckedChanged);
            // 
            // YourColor
            // 
            this.YourColor.Location = new System.Drawing.Point(12, 129);
            this.YourColor.Multiline = true;
            this.YourColor.Name = "YourColor";
            this.YourColor.Size = new System.Drawing.Size(285, 97);
            this.YourColor.TabIndex = 2;
            this.YourColor.Text = "你喜欢的颜色：";
            this.YourColor.TextChanged += new System.EventHandler(this.YourColor_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YourColor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_lan;
        private System.Windows.Forms.RadioButton radioButton_lv;
        private System.Windows.Forms.RadioButton radioButton_Hong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_zi;
        private System.Windows.Forms.CheckBox checkBox_huang;
        private System.Windows.Forms.CheckBox checkBox_cheng;
        private System.Windows.Forms.CheckBox checkBox_lan;
        private System.Windows.Forms.CheckBox checkBox_lv;
        private System.Windows.Forms.CheckBox checkBox_hong;
        private System.Windows.Forms.TextBox YourColor;
        private System.Windows.Forms.Button button1;
    }
}